using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibraryCarService
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
                throw new Exception("Неудалось подключиться к базе данных!\nПриложение будет перезапущено");
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
