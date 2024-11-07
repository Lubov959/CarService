using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCarService
{
    public class CarService_DataInTadle
    {
        DataBase dataBase = new DataBase();
        public void InsertDataInTablecarType(string type)
        {
            string ComDel = $" Insert into carType(carTypeName) values ('{type}')";
            SqlCommand cmd1 = new SqlCommand(ComDel, dataBase.GetConection());
            dataBase.OpenConection();
            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Данные не были сохранены!");
            }
            finally
            {
                dataBase.CloseConection();
            }
        }

        public void UpDateDataInTablecarType(int id, string type)
        {
            string ComDel = $" UpDate carType set carTypeName = '{type}' where carTypeID = {id}";
            SqlCommand cmd1 = new SqlCommand(ComDel, dataBase.GetConection());
            dataBase.OpenConection();
            try
            {
                cmd1.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Данные не были сохранены!");
            }
            finally
            {
                dataBase.CloseConection();
            }
        }
    }
}
