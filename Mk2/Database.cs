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
        public static void CreateCustomer(Customer customer)
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

        public static DataTable ReadDB()
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

        public static DataTable ReadCustomer(Customer customer)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");

            var command = connection.CreateCommand();
            //command.CommandText = "SELECT * FROM customers WHERE firstName = @firstName OR lastName = @lastName OR address = @address OR phone = @phone OR email = @email OR notes = @notes";
            command.CommandText = "SELECT * FROM customers WHERE (IFNULL(@firstName, '') <> '' AND firstName = @firstName) OR (IFNULL(@lastName, '') <> '' AND lastName = @lastName) OR (IFNULL(@address, '') <> '' AND address = @address) OR (IFNULL(@phone, '') <> '' AND phone = @phone) OR (IFNULL(@email, '') <> '' AND email = @email) OR (IFNULL(@notes, '') <> '' AND notes = @notes)";
            command.Parameters.AddWithValue("@firstName", customer.FirstName);
            command.Parameters.AddWithValue("@lastName", customer.LastName);
            command.Parameters.AddWithValue("@address", customer.Address);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@email", customer.Email);
            command.Parameters.AddWithValue("@notes", customer.Notes);

            var dataAdapter = new SQLiteDataAdapter();
            var dataTable = new DataTable();

            connection.Open();
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            connection.Close();

            return dataTable;
        }

        public static void UpdateCustomer(Customer customer)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE customers SET firstName = @firstName, lastName = @lastName, address = @address, phone = @phone, email = @email, notes = @notes WHERE id = @id";
            command.Parameters.AddWithValue("@id", customer.Id);
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

        public static void DeleteCustomer(Customer customer)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM customers WHERE id = @id";
            command.Parameters.AddWithValue("@id", customer.Id);

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
