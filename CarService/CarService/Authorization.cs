using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarService
{
    public partial class Authorization : Form
    {
        string captcha;
        int countV;
        public Authorization()
        {
            InitializeComponent();
            textBoxLogin.Text = string.Empty;
            textBoxPass.Text = string.Empty;
            pictureBoxLogo.Image = Image.FromFile("Logo.png");
            pictureBoxPass.Image = Image.FromFile("Глаз.png");
            pictureBoxUpCaptcha.Image = Image.FromFile("Обновить.png");
            textBoxCaptcha.Visible = false;
            pictureBoxCaptcha.Visible = false;
            pictureBoxUpCaptcha.Visible = false;
            countV = 0;
            this.TopMost = true;
        }

        private void pictureBoxPass_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = false;
        }

        private void pictureBoxPass_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            bool entered = false;
            if (textBoxCaptcha.Visible == true)
            {
                if ((!textBoxCaptcha.Text.Equals(captcha, StringComparison.OrdinalIgnoreCase)) || (textBoxCaptcha.Text == string.Empty))
                {
                    MessageBox.Show("Неверно введена капча!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCaptcha.Text = string.Empty;
                    GenerateCaptcha();
                    return;
                }
            }
            if ((textBoxLogin.Text != string.Empty) && (textBoxPass.Text != string.Empty))
            {
                var passReal = dataBase.SelectInfoToQuery($" Select (Convert(Nvarchar(max), DecryptByPassphrase('MyPassword', password))) from [user] where login='{textBoxLogin.Text}'");
                entered = passReal == textBoxPass.Text;
                if (entered)
                {
                    if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Your"))
                        Application.OpenForms["Your"].Dispose();
                    Form frm = new Your(textBoxLogin.Text);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    countV++;
                    if (countV==2)
                    {
                        MessageBox.Show("Неверные входные данные!\nВремя ожидания до следующей попытки 3 минуты", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBoxCaptcha.Text = string.Empty;
                        timer1.Start();
                        buttonV.Enabled = false;
                    }
                    else if (countV == 3)
                    {
                        MessageBox.Show("Превышен лимит попыток входа!\nПриложение будет перезапущено", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Dispose();
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Неверные входные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxCaptcha.Visible = true;
                        pictureBoxCaptcha.Visible = true;
                        pictureBoxUpCaptcha.Visible = true;
                    }
                    GenerateCaptcha();
                }
            }
            else
            {
                MessageBox.Show("Пустые поля недопустимы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string ComDel = $" Insert into history(time, login, entered) values ('{Convert.ToDateTime(DateTime.Now)}','{textBoxLogin.Text}', '{entered}')";
            SqlCommand cmd1 = new SqlCommand(ComDel, dataBase.GetConection());
            dataBase.OpenConection();
            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch 
            {
                MessageBox.Show("Данные не были сохранены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataBase.CloseConection();
            }
        }


        private void GenerateCaptcha()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            captcha = new string(Enumerable.Repeat(chars, 4)
                                                  .Select(s => s[random.Next(s.Length)]).ToArray());
            Bitmap bmp = new Bitmap(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                for (int i = 0; i < 50; i++)
                {
                    int x = random.Next(bmp.Width);
                    int y = random.Next(bmp.Height);
                    bmp.SetPixel(x, y, Color.Gray);
                }

                using (Font font = new Font("Times New Roman", 14, FontStyle.Bold))
                {
                    for (int i = 0; i < captcha.Length; i++)
                    {
                        int x = i * 20 + random.Next(-5, 5);
                        int y = random.Next(0, 10);
                        g.DrawString(captcha[i].ToString(), font, Brushes.Black, new Point(x, y));
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        int x1 = random.Next(bmp.Width);
                        int y1 = random.Next(bmp.Height);
                        int x2 = random.Next(bmp.Width);
                        int y2 = random.Next(bmp.Height);
                        g.DrawLine(Pens.Gray, x1, y1, x2, y2);
                    }
                }
            }
            pictureBoxCaptcha.Image = bmp;
        }

        private void pictureBoxUpCaptcha_Click(object sender, EventArgs e)
        {
            textBoxCaptcha.Text = string.Empty;
            GenerateCaptcha();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonV.Enabled = true;
        }
    }
}
