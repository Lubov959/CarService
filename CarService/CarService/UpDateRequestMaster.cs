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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CarService
{
    public partial class UpDateRequestMaster : Form
    {
        Dictionary<string, string> info = new Dictionary<string, string>();
        DataBase dataBase = new DataBase();
        Dictionary<int, string> parts = new Dictionary<int, string>();
        Dictionary<int, string> comments = new Dictionary<int, string>();
        Dictionary<string, int> infoForm = new Dictionary<string, int>();

        public UpDateRequestMaster(Dictionary<string, string> info, Dictionary<string, int> infoForm)
        {
            InitializeComponent();
            this.info = info;
            this.infoForm = infoForm;
            if (info["status"] == "Готова к выдаче")
            {
                checkBoxFinish.Checked = true;
            }
            else
            {
                checkBoxFinish.Checked = false;
            }
            parts.Clear();
            comments.Clear();
            comboBoxComment.Text = info["comment"];
            comboBoxPart.Text = info["part"].ToString();

            SqlCommand command = new SqlCommand($"SELECT * FROM [repairParts]", dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataReader reader = command.ExecuteReader();
            comboBoxPart.Items.Clear();
            while (reader.Read())
            {
                comboBoxPart.Items.Add(reader.GetString(1));
                if (!parts.ContainsKey(reader.GetInt32(0)))
                {
                    parts.Add(reader.GetInt32(0), reader.GetString(1));
                }
                else
                {
                    MessageBox.Show($"Запись с Id {reader.GetInt32(0)} уже существует. Пропускаем добавление.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            dataBase.CloseConection();

            SqlCommand command1 = new SqlCommand($"SELECT * FROM [comment]", dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataReader reader1 = command1.ExecuteReader();
            comboBoxComment.Items.Clear();
            while (reader1.Read())
            {
                comboBoxComment.Items.Add(reader1.GetString(1));
                comments.Add(reader1.GetInt32(0), reader1.GetString(1));
            }
            dataBase.CloseConection();

        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Request"))
                Application.OpenForms["Request"].Dispose();
            Form frm2 = new Request(infoForm);
            frm2.Show();
            frm2.Activate();
            this.Dispose();
        }

        private void UpDateRequestMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Request"))
                Application.OpenForms["Request"].Dispose();
            Form frm2 = new Request(infoForm);
            frm2.Show();
            frm2.Activate();
            this.Dispose();
        }

        private void buttonUpDataRequest_Click(object sender, EventArgs e)
        {
            if ((comboBoxComment.Text != string.Empty) && (comboBoxPart.Text != string.Empty))
            {
                int comment = comments.Where(x => x.Value == comboBoxComment.Text.ToString()).FirstOrDefault().Key;
                int partID = parts.Where(x => x.Value == comboBoxPart.Text.ToString()).FirstOrDefault().Key;
                string ComDel;
                if (checkBoxFinish.Checked)
                    ComDel = $" UpDate request set completionDate = '{Convert.ToDateTime(DateTime.Now)}', repairPartsID = {partID}, requestStatusID = 2 where requestID = {Convert.ToInt32(info["requestID"])}";
                else
                    ComDel = $" UpDate request set completionDate = null, repairPartsID = {partID}, requestStatusID = 1 where requestID = {Convert.ToInt32(info["requestID"])}";
                string ComDel1;
                if (info["comment"] != string.Empty)
                    ComDel1 = $"UpDate comment set message = '{comboBoxComment.Text}' where requestID = {Convert.ToInt32(info["requestID"])}";
                else
                    ComDel1 = $"Insert INTO comment(message, requestID) values ('{comboBoxComment.Text}',{Convert.ToInt32(info["requestID"])})";
                SqlCommand cmd1 = new SqlCommand(ComDel, dataBase.GetConection());
                SqlCommand cmd = new SqlCommand(ComDel1, dataBase.GetConection());
                dataBase.OpenConection();
                try
                {
                    cmd.ExecuteNonQuery();
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
                dataBase.OpenConection();

                if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Request"))
                    Application.OpenForms["Request"].Dispose();
                Form frm2 = new Request(infoForm);
                frm2.Show();
                frm2.Activate();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
