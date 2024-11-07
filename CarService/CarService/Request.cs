using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CarService
{
    public partial class Request : Form
    {
        Dictionary<string, int> infoForm = new Dictionary<string, int>();
        DataBase dataBase = new DataBase();
        int countRows;
        public Request(Dictionary<string, int> infoForm)
        {
            InitializeComponent();
            this.infoForm = infoForm;
        }

        private void Request_Load(object sender, EventArgs e)
        {
            UpDataTable();
            switch (infoForm["rol"])
            {
                case 1:
                    buttonCreateR.Visible = false;
                    buttonUpDateR.Text = "Регистрация заявки";
                    break;
                case 2:
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    buttonCreateR.Visible = false;
                    break;
                case 3:
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    break;
                case 4:
                    buttonCreateR.Visible = false;
                    buttonUpDateR.Text = "Регистрация заявки";
                    break;
            }
        }

        public void UpDataTable()
        {
            numericUpDownRID.Value = 0;
            string querst = string.Empty;
            switch (infoForm["rol"])
            {
                case 1:
                    querst = $"SELECT * FROM [Requests]";
                    break;
                case 2:
                    querst = $"SELECT * FROM [Requests] where [Номер мастера] = '{infoForm["userID"]}'";
                    break;
                case 3:
                    querst = $"SELECT * FROM [Requests] where [Номер клиента] = '{infoForm["userID"]}'";
                    break;
                case 4:
                    querst = $"SELECT * FROM [Requests]";
                    break;
            }
            SqlCommand command = new SqlCommand(querst, dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataAdapter reader = new SqlDataAdapter(querst, dataBase.GetConection());
            DataSet ds = new DataSet();
            reader.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            countRows = ds.Tables[0].Rows.Count;
            labelCountR.Text = "строк " + ds.Tables[0].Rows.Count.ToString() + " из " + countRows;
            dataBase.CloseConection();
        }

        private void buttonCreateR_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "CreateRequest"))
                Application.OpenForms["CreateRequest"].Dispose();
            Form frm = new CreateRequest(infoForm);
            frm.Show();
            frm.Activate();
            this.Dispose();
        }

        private void buttonUpDateR_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Dictionary<string, string> info = new Dictionary<string, string>();
                info["type"] = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                info["model"] = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                info["problem"] = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                info["status"] = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                info["master"] = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                info["comment"] = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                info["part"] = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                info["requestID"] = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                info["dateFinish"] = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                info["startDate"] = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                switch (infoForm["rol"])
                {
                    case 1:
                        if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "RegRequestMeneger"))
                            Application.OpenForms["RegRequestMeneger"].Dispose();
                        Form frm3 = new RegRequestMeneger(info, infoForm);
                        frm3.Show();
                        frm3.Activate();
                        this.Dispose();
                        break;
                    case 2:
                        if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "UpDateRequestMaster"))
                            Application.OpenForms["UpDateRequestMaster"].Dispose();
                        Form frm = new UpDateRequestMaster(info, infoForm);
                        frm.Show();
                        frm.Activate();
                        this.Dispose();
                        break;
                    case 3:
                        if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "UpDateRequest"))
                            Application.OpenForms["UpDateRequest"].Dispose();
                        Form frm1 = new UpDateRequest(info, infoForm);
                        frm1.Show();
                        frm1.Activate();
                        this.Dispose();
                        break;
                    case 4:
                        if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "RegRequest"))
                            Application.OpenForms["RegRequest"].Dispose();
                        Form frm2 = new RegRequest(info, infoForm);
                        frm2.Show();
                        frm2.Activate();
                        this.Dispose();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Menu"))
                Application.OpenForms["Menu"].Dispose();
            Form frm = new Menu(infoForm);
            frm.Show();
            frm.Activate();
            this.Dispose();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (numericUpDownRID.Value != 0)
            {
                string querst = string.Empty;
                switch (infoForm["rol"])
                {
                    case 1:
                        querst = $"SELECT * FROM [Requests] where Номер = {numericUpDownRID.Value}";
                        break;
                    case 2:
                        querst = $"SELECT * FROM [Requests] where Номер = {numericUpDownRID.Value} and [Номер мастера] = '{infoForm["userID"]}'";
                        break;
                    case 3:
                        querst = $"SELECT * FROM [Requests] where Номер = {numericUpDownRID.Value} and [Номер клиента] = '{infoForm["userID"]}'";
                        break;
                    case 4:
                        querst = $"SELECT * FROM [Requests] where Номер = {numericUpDownRID.Value}";
                        break;
                }
                SqlCommand command = new SqlCommand(querst, dataBase.GetConection());
                dataBase.OpenConection();
                SqlDataAdapter reader = new SqlDataAdapter(querst, dataBase.GetConection());
                DataSet ds = new DataSet();
                reader.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                labelCountR.Text = "строк "+ds.Tables[0].Rows.Count.ToString() + " из " + countRows;
                if(ds.Tables[0].Rows.Count==0)
                    MessageBox.Show("Такой заявки нет!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataBase.CloseConection();
            }
            else
            {
                MessageBox.Show("Выберите номер заявки для поиска!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpDataTable_Click(object sender, EventArgs e)
        {
            UpDataTable();
        }

        private void Request_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Menu"))
                Application.OpenForms["Menu"].Dispose();
            Form frm = new Menu(infoForm);
            frm.Show();
            frm.Activate();
            this.Dispose();
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
                    filter += $"[Дата начала] = '{dateValue:yyyy-MM-dd}'OR"+
                        $"[Дата окончания] = '{dateValue:yyyy-MM-dd}'";
                }
                else
                {
                    filter += $"[Модель] LIKE '%{keyword}%' OR " +
                    $"[Тип машины] LIKE '%{keyword}%' OR" +
                    $"[Проблема] LIKE '%{keyword}%' OR " +
                    $"[Статус] LIKE '%{keyword}%' OR " +
                    $"[Дата окончания] LIKE '%{keyword}%' OR " +
                    $"[Запчасти] LIKE '%{keyword}%' OR " +
                    $"[Мастер] LIKE '%{keyword}%'OR" +
                    $"[Клиент] LIKE '%{keyword}%'";
                }

            }
            string querst = string.Empty;
            switch (infoForm["rol"])
            {
                case 1:
                    querst = $"SELECT * FROM [Requests] where {filter}";
                    break;
                case 2:
                    querst = $"SELECT * FROM [Requests] where [Номер мастера] = {infoForm["userID"]} and ({filter})";
                    break;
                case 3:
                    querst = $"SELECT * FROM [Requests] where [Номер клиента] = {infoForm["userID"]} and  ({filter})";
                    break;
                case 4:
                    querst = $"SELECT * FROM [Requests] where {filter}";
                    break;
            }
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
    }
}
