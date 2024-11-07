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

namespace CarService
{
    public partial class AllReadline : Form
    {
        DataBase dataBase = new DataBase();
        int countRows;
        string table;
        public AllReadline(string table, string tableName)
        {
            InitializeComponent();
            this.table = table;
            UpDataTable();
            this.Name = tableName;
        }

        public void UpDataTable()
        {
            string querst = $"SELECT * FROM [{table}]";
            SqlCommand command = new SqlCommand(querst, dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataAdapter reader = new SqlDataAdapter(querst, dataBase.GetConection());
            DataSet ds = new DataSet();
            reader.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];                    
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            countRows = ds.Tables[0].Rows.Count;
            labelCountR.Text = "строк " + ds.Tables[0].Rows.Count.ToString() + " из " + countRows;
            if (ds.Tables[0].Rows.Count == 0)
                MessageBox.Show("Такой записи нет!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataBase.CloseConection();
            numericUpDownRID.Value = 0;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Menu"].Show();
            Application.OpenForms["Menu"].Activate();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (numericUpDownRID.Value != 0)
            {
                string querst = $"SELECT * FROM [{table}] where {table}ID = {numericUpDownRID.Value}";
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
                filter += $"[{table}ID] LIKE '%{keyword}%' OR "+
                    $"[{table}Name] LIKE '%{keyword}%'";
            }
            string querst = $"SELECT * FROM [{table}] where {filter}";
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

        private void AllReadline_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Menu"].Show();
            Application.OpenForms["Menu"].Activate();
            this.Hide();
        }

        private void buttonUpDataTable_Click(object sender, EventArgs e)
        {
            UpDataTable();
        }
    }
}
