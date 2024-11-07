using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarService
{
    public partial class Your : Form
    {
        Dictionary<string, int> info = new Dictionary<string, int>();
        public Your(string log)
        {
            InitializeComponent();
            pictureBoxIcon.Image = Image.FromFile("user.png");

            DataBase dataBase = new DataBase();

            SqlCommand command = new SqlCommand($"SELECT * FROM [user] where login = '{log}'", dataBase.GetConection());
            dataBase.OpenConection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                labelUserName.Text = reader[1].ToString() +" "+ reader[2].ToString() +" "+ reader[3].ToString();
                labelUserPhone.Text = reader[4].ToString();
                info.Add("userID",  Convert.ToInt32(reader[0]));
                info.Add("rol", Convert.ToInt32(reader[7]));
            }
            dataBase.CloseConection();
            labelUserType.Text = dataBase.SelectInfoToQuery($"SELECT typeName FROM [type] where typeID = (select typeID from [user] where login = '{log}')");
            
            timer1.Start();
        }
        

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Menu"))
                Application.OpenForms["Menu"].Dispose();
            Form frm = new Menu(info);
            frm.Show();
            timer1.Stop();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f.Name == "Menu"))
                Application.OpenForms["Menu"].Dispose();
            Form frm = new Menu(info);
            frm.Show();
            timer1.Stop();
            this.Dispose();
        }

    }
}
