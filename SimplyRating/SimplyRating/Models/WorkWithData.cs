using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace SimplyRating.Models
{
    public class WorkWithData
    {
         public static void DataConnection()
        {
            string connectionString = @"Data Source=.\DATABASE_1; Initial Catalog=Raitinger; Integrates Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void AddUserData(string firstName, string lastName, string email)

        {
            // устанавливаем связь с сервером
            string connectionString = @"Data Source=.\DATABASE_1; Initial Catalog=Raitinger; Integrates Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //вставка данных в таблицу Users 
            SqlCommand incert = connection.CreateCommand();
            incert.CommandText = "INSERT Users (FirstName, LastName) VALUES ('Alla', 'Blokh') go";
            incert.CommandText = "INSERT Users (FirstName, LastName) VALUES ('Alla', 'Blokh') go";

            // закрываем соединение
            connection.Close();
        }
    }
}