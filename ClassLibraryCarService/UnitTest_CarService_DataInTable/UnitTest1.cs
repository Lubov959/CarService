using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryCarService;
using System.Data.SqlClient;

namespace UnitTest_CarService_DataInTable
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_GetConnection()
        {
            DataBase dataBase = new DataBase();
            SqlConnection result = dataBase.GetConection();
            SqlConnection delive = new SqlConnection(@"Data Source = ADCLG1; Initial catalog = z111; Integrated Security=True;");
            Assert.AreEqual(result.ToString(), delive.ToString());
        }

        [TestMethod]
        public void TestMethod_SelectInfoToQuery_Positiv()
        {
            DataBase dataBase = new DataBase();
            string login = "login1";
            string result = dataBase.SelectInfoToQuery($" Select (Convert(Nvarchar(max), DecryptByPassphrase('MyPassword', password))) from [user] where login='{login}'");
            string delive = "pass1";
            Assert.AreEqual(result, delive);
        }

        [TestMethod]
        public void TestMethod_SelectInfoToQuery_Negativ()
        {
            DataBase dataBase = new DataBase();
            string login = "login10";
            string result = dataBase.SelectInfoToQuery($" Select (Convert(Nvarchar(max), DecryptByPassphrase('MyPassword', password))) from [user] where login='{login}'");
            string delive = string.Empty;
            Assert.AreEqual(result, delive);
        }

        [TestMethod]
        public void TestMethod_InsertDataInTablecarType_Positiv()
        {
            DataBase dataBase = new DataBase();
            CarService_DataInTadle dataInTadle = new CarService_DataInTadle();
            int countRowsInTable = int.Parse(dataBase.SelectInfoToQuery($"Select count(*) from [carType]"));
            string type = "Лендровер";
            dataInTadle.InsertDataInTablecarType(type);
            int result = int.Parse(dataBase.SelectInfoToQuery($"Select count(*) from [carType]"));
            int delive = countRowsInTable+1;
            Assert.AreEqual(result, delive);
        }

        [TestMethod]
        public void TestMethod_UpDateDataInTablecarType_Positiv()
        {
            DataBase dataBase = new DataBase();
            CarService_DataInTadle dataInTadle = new CarService_DataInTadle();
            int id = 4;
            string type = "Сидан";
            dataInTadle.UpDateDataInTablecarType(id, type);
            string result = dataBase.SelectInfoToQuery($"Select carTypeName from [carType] where carTypeID = {id}");
            string delive = type;
            Assert.AreEqual(result, delive);
        }
    }
}
