using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Mk2
{
    class Database
    {
        //methods
        public static void AddCustomer(string firstName, string lastName)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO customers (firstName, lastName) VALUES (@firstName, @lastName)";
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable RecoverByIndex(string index)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM customers WHERE id = @index";
            command.Parameters.AddWithValue("@index", index);

            var dataAdapter = new SQLiteDataAdapter();
            var dataTable = new DataTable();
            connection.Open();
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }
        //end methods
    }
}
