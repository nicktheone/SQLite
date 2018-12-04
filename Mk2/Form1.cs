using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Mk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");
            var sql = "CREATE TABLE IF NOT EXISTS customers (id INTEGER PRIMARY KEY, firstName TEXT NOT NULL, lastName TEXT NOT NULL, address TEXT, phone TEXT, email TEXT, notes TEXT)";
            var command = new SQLiteCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");
            var sql = "SELECT * FROM customers";
            var command = new SQLiteCommand(sql, connection);
            var dataAdapter = new SQLiteDataAdapter();
            var dataTable = new DataTable();
            connection.Open();
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = dataTable;
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.AddCustomer("Nome", "Cognome");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dataTable = Database.RecoverByIndex(comboBox1.Text);
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
