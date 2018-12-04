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

        public static void AddCustomer(Customer customer)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO customers (firstName, lastName, address, phone, email, notes) VALUES (@firstName, @lastName, @address, @phone, @email, @notes)";
            command.Parameters.AddWithValue("@firstName", customer.FirstName);
            command.Parameters.AddWithValue("@lastName", customer.LastName);
            command.Parameters.AddWithValue("@address", customer.Address);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@email", customer.Email);
            command.Parameters.AddWithValue("@notes", customer.Notes);

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

        public static DataTable RecoverDB()
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM customers";

            var dataAdapter = new SQLiteDataAdapter();
            var dataTable = new DataTable();

            connection.Open();
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }

        public static DataTable RemoveByIndex(string index)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM customers WHERE id = @index";
            command.Parameters.AddWithValue("@index", index);
            var command2 = connection.CreateCommand();
            command2.CommandText = "SELECT * FROM customers";

            var dataAdapter = new SQLiteDataAdapter();
            var dataTable = new DataTable();

            connection.Open();
            command.ExecuteNonQuery();
            dataAdapter.SelectCommand = command2;
            dataAdapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }
        //end methods
    }
}
