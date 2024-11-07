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

namespace CarService
{
    public partial class History : Form
    {
        DataBase dataBase = new DataBase();
        int countRows;
        Dictionary<string, int> infoForm = new Dictionary<string, int>();
        public History(Dictionary<string, int> infoForm)
        {
            InitializeComponent();
            UpDataTable();
            this.infoForm = infoForm;
        }

        public void UpDataTable()
        {
            string querst = $"SELECT * FROM [history]";
            SqlCommand command = new SqlCommand(querst, dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataAdapter reader = new SqlDataAdapter(querst, dataBase.GetConection());
            DataSet ds = new DataSet();
            reader.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Время захода";
            dataGridView1.Columns[2].HeaderText = "Логин";
            dataGridView1.Columns[3].HeaderText = "Удачная попытка?";
            countRows = ds.Tables[0].Rows.Count;
            labelCountR.Text = "строк " + ds.Tables[0].Rows.Count.ToString() + " из " + countRows;
            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("Такой записи нет!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.CloseConection();
            numericUpDownRID.Value = 0;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Menu"))
                Application.OpenForms["Menu"].Dispose();
            Form frm = new Menu(infoForm);
            frm.Show();
            this.Dispose();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (numericUpDownRID.Value != 0)
            {
                string querst = $"SELECT * FROM [history] where historyID = {numericUpDownRID.Value}";
                dataBase.OpenConection();
                SqlDataAdapter reader = new SqlDataAdapter(querst, dataBase.GetConection());
                DataSet ds = new DataSet();
                reader.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                labelCountR.Text = "строк " + ds.Tables[0].Rows.Count.ToString() + " из " + countRows;
                if (ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("Такой записи нет!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataBase.CloseConection();
            }
            else
            {
                MessageBox.Show("Выберите номер заявки для поиска!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFiltr_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;
            string[] keywords = textBoxFiltr.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var keyword in keywords)
            {
                if (keyword.Length == 2)
                    continue;
                if (filter.Length > 0)
                {
                    filter += " AND ";

                }
                DateTime dateValue;
                if (DateTime.TryParse(keyword, out dateValue))
                {
                    filter += $"[time] = '{dateValue:yyyy-MM-dd}'";
                }
                else
                {
                    filter += $"[login] LIKE '%{keyword}%'";
                }
            }
            string querst = $"SELECT * FROM [history] where {filter}";
            dataBase.OpenConection();
            SqlDataAdapter reader = new SqlDataAdapter(querst, dataBase.GetConection());
            DataSet ds = new DataSet();
            reader.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            labelCountR.Text = "строк " + ds.Tables[0].Rows.Count.ToString() + " из " + countRows;
            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("Такой записи нет!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.CloseConection();
        }

        private void History_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Menu"))
                Application.OpenForms["Menu"].Dispose();
            Form frm = new Menu(infoForm);
            frm.Show();
            this.Dispose();
        }

        private void buttonUpDataTable_Click(object sender, EventArgs e)
        {
            UpDataTable();
        }
    }
}