using System.Data;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace CarService
{
    public class DataBase
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HG8OBH6\SQLEXPRESS;Initial Catalog=z111;Integrated Security=True;");
        SqlConnection conn = new SqlConnection(@"Data Source = ADCLG1; Initial catalog = z111; Integrated Security=True;");

        public void OpenConection()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
            }
            catch
            {
                MessageBox.Show("Неудалось подключиться к базе данных!\nПриложение будет перезапущено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
                Application.Restart();
            }
        }
        public void CloseConection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public string SelectInfoToQuery(string query)
        {
            DataBase dataBase = new DataBase();
            SqlCommand command = new SqlCommand(query, dataBase.GetConection());
            dataBase.OpenConection();
            string result = command.ExecuteScalar() == null ? string.Empty : command.ExecuteScalar().ToString();
            dataBase.CloseConection();
            return result;
        }

        public SqlConnection GetConection() => conn;

    }

}
