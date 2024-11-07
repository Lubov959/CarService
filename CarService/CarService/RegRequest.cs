using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CarService
{
    public partial class RegRequest : Form
    {
        DataBase dataBase = new DataBase();
        Dictionary<int, string> masters = new Dictionary<int, string>();
        Dictionary<int, string> statuses = new Dictionary<int, string>();
        Dictionary<string, string> info = new Dictionary<string, string>();
        Dictionary<string, int> infoForm = new Dictionary<string, int>();
        public RegRequest(Dictionary<string, string> info, Dictionary<string, int> infoForm)
        {
            InitializeComponent();
            this.info = info;
            this.infoForm = infoForm;
            masters.Clear();
            statuses.Clear();
            comboBoxMaster.Text = info["master"];
            comboBoxStatus.Text = info["status"];

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

            SqlCommand command1 = new SqlCommand($"SELECT * FROM [requestStatus]", dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataReader reader1 = command1.ExecuteReader();
            comboBoxStatus.Items.Clear();
            while (reader1.Read())
            {
                comboBoxStatus.Items.Add(reader1.GetString(1));
                statuses.Add(reader1.GetInt32(0), reader1.GetString(1));
            }
            dataBase.CloseConection();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if ((comboBoxMaster.Text != string.Empty) && (comboBoxStatus.Text != string.Empty))
            {
                int masterID = masters.Where(x => x.Value == comboBoxMaster.Text.ToString()).FirstOrDefault().Key;
                int statusID = statuses.Where(x => x.Value == comboBoxStatus.Text.ToString()).FirstOrDefault().Key;
                string ComDel;
                if (info["status"] == "Новая заявка")
                    ComDel = $" UpDate request set [startDate] = '{Convert.ToDateTime(DateTime.Now)}' , masterID = {masterID}, requestStatusID = {statusID} where requestID = {Convert.ToInt32(info["requestID"])}";
                else
                    ComDel = $" UpDate request set masterID = {masterID}, requestStatusID = {statusID} where requestID = {Convert.ToInt32(info["requestID"])}";
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
                MessageBox.Show("Поля не должны быть пустыми!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void RegRequest_FormClosed(object sender, FormClosedEventArgs e)
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
