using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CarService
{
    public partial class RegRequestMeneger : Form
    {
        DataBase dataBase = new DataBase();
        Dictionary<int, string> masters = new Dictionary<int, string>();
        Dictionary<int, string> statuses = new Dictionary<int, string>();
        Dictionary<string, string> info = new Dictionary<string, string>();
        Dictionary<string, int> infoForm = new Dictionary<string, int>();
        public RegRequestMeneger(Dictionary<string, string> info, Dictionary<string, int> infoForm)
        {
            InitializeComponent();
            this.info = info;
            this.infoForm = infoForm;
            masters.Clear();
            statuses.Clear();
            comboBoxMaster.Text = info["master"];
            maskedTextBoxDate.Text = info["dateFinish"];
            if (maskedTextBoxDate.Text == "  .  .")
            {
                maskedTextBoxDate.Enabled = false;
            }
            else
            {
                maskedTextBoxDate.Enabled = true;
            }

            SqlCommand command = new SqlCommand($"SELECT * FROM [user] where typeID = 2", dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataReader reader = command.ExecuteReader();
            comboBoxMaster.Items.Clear();
            while (reader.Read())
            {
                comboBoxMaster.Items.Add(reader.GetString(1));
                masters.Add(reader.GetInt32(0), reader.GetString(1));
            }
            dataBase.CloseConection();
        }

        private void buttonUpData_Click(object sender, EventArgs e)
        {
            if (comboBoxMaster.Text != string.Empty)
            {
                int masterID = masters.Where(x => x.Value == comboBoxMaster.Text.ToString()).FirstOrDefault().Key;
                string ComDel = string.Empty;
                if (maskedTextBoxDate.Enabled == true) 
                {
                    var dataFinish = Convert.ToDateTime(maskedTextBoxDate.Text);
                    var startDate = Convert.ToDateTime(info["startDate"]);
                    if (dataFinish >= startDate)
                    {
                        ComDel = $" UpDate request set [completionDate] = '{dataFinish}' , masterID = {masterID} where requestID = {Convert.ToInt32(info["requestID"])}";
                    }
                    else
                    {
                        MessageBox.Show("Дата окончания должна быть позже чем дата начала работ!\nДата не будет изменена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ComDel = $" UpDate request set masterID = {masterID} where requestID = {Convert.ToInt32(info["requestID"])}";
                    }
                }
                else
                    ComDel = $" UpDate request set masterID = {masterID} where requestID = {Convert.ToInt32(info["requestID"])}";
                SqlCommand cmd1 = new SqlCommand(ComDel, dataBase.GetConection());
                dataBase.OpenConection();
                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Данные были сохранены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Данные не были сохранены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dataBase.CloseConection();
                }

                if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Request"))
                    Application.OpenForms["Request"].Dispose();
                Form frm2 = new Request(infoForm);
                frm2.Show();
                frm2.Activate();
                this.Dispose();
            }

            else
            {
                MessageBox.Show("Поле мастера является обязательным для заполнения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Request"))
                Application.OpenForms["Request"].Dispose();
            Form frm2 = new Request(infoForm);
            frm2.Show();
            frm2.Activate();
            this.Dispose();
        }

        private void RegRequestMeneger_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Request"))
                Application.OpenForms["Request"].Dispose();
            Form frm2 = new Request(infoForm);
            frm2.Show();
            frm2.Activate();
            this.Dispose();
        }
    }
}
