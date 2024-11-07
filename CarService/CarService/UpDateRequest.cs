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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace CarService
{
    public partial class UpDateRequest : Form
    {
        Dictionary<string, string> info = new Dictionary<string, string>();
        DataBase dataBase = new DataBase();
        Dictionary<int, string> problems = new Dictionary<int, string>();
        Dictionary<int, string> models = new Dictionary<int, string>();
        Dictionary<string, int> infoForm = new Dictionary<string, int>();
        public UpDateRequest(Dictionary<string, string> info, Dictionary<string, int> infoForm)
        {
            InitializeComponent();
            this.info = info;
            this.infoForm = infoForm;
            if (info["type"] == "Легковая")
            {
                radioButtonL.Checked = true;
                radioButtonG.Checked = false;
            }
            else
            {
                radioButtonL.Checked = false;
                radioButtonG.Checked = true;
            }
            models.Clear();
            problems.Clear();
            comboBoxModel.Text = info["model"];
            comboBoxProdlem.Text = info["problem"];

            SqlCommand command = new SqlCommand($"SELECT * FROM [carModel]", dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataReader reader = command.ExecuteReader();
            comboBoxModel.Items.Clear();
            while (reader.Read())
            {
                comboBoxModel.Items.Add(reader.GetString(1));
                models.Add(reader.GetInt32(0), reader.GetString(1));
            }
            dataBase.CloseConection();
        }

        private void UpDateRequest_Load(object sender, EventArgs e)
        {
            int carTypeID = radioButtonL.Checked ? 1 : 2;
            ListCarModel(carTypeID);

            SqlCommand command1 = new SqlCommand($"SELECT * FROM [problemDescryption]", dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataReader reader1 = command1.ExecuteReader();
            comboBoxProdlem.Items.Clear();
            while (reader1.Read())
            {
                comboBoxProdlem.Items.Add(reader1.GetString(1));
                problems.Add(reader1.GetInt32(0), reader1.GetString(1));
            }
            dataBase.CloseConection();
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

        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            if((comboBoxProdlem.Text!=string.Empty) && (comboBoxModel.Text != string.Empty))
            {
            int carModelID = models.Where(x => x.Value == comboBoxModel.Text.ToString()).FirstOrDefault().Key;
            int problemID = problems.Where(x => x.Value == comboBoxProdlem.Text.ToString()).FirstOrDefault().Key;
            string ComDel = $" UpDate request set carModelID = {carModelID}, problemDescryptionID= {problemID} where requestID  = {Convert.ToInt32(info["requestID"])}";
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

        private void radioButtonL_CheckedChanged(object sender, EventArgs e)
        {
            int carTypeID = radioButtonL.Checked ? 1 : 2;
            ListCarModel(carTypeID);
            comboBoxModel.Text = string.Empty;
        }

        public void ListCarModel(int carTypeID)
        {
            SqlCommand command = new SqlCommand($"SELECT carModelName FROM [carModel] where carModel.carTypeID = {carTypeID}", dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataReader reader = command.ExecuteReader();
            comboBoxModel.Items.Clear();
            while (reader.Read())
            {
                comboBoxModel.Items.Add(reader.GetString(0));
            }
            dataBase.CloseConection();
        }

        private void comboBoxModel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            radioButtonG.Enabled = false;
            radioButtonL.Enabled = false;
            comboBoxModel.Text = string.Empty;
        }

        private void comboBoxModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                comboBoxModel.DroppedDown = false;
                if (comboBoxModel.Text.Length == 0)
                {
                    radioButtonG.Enabled = true;
                    radioButtonL.Enabled = true;
                }
            }
        }

        private void UpDateRequest_FormClosed(object sender, FormClosedEventArgs e)
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
