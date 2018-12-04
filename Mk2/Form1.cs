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

        private void buttonCreateDB_Click(object sender, EventArgs e)
        {
            var connection = new SQLiteConnection("Data Source = prova.sqlite; Version=3;");
            var sql = "CREATE TABLE IF NOT EXISTS customers (id INTEGER PRIMARY KEY, firstName TEXT NOT NULL, lastName TEXT NOT NULL, address TEXT, phone TEXT, email TEXT, notes TEXT)";
            var command = new SQLiteCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void buttonRecoverDB_Click(object sender, EventArgs e)
        {
            var dataTable = Database.RecoverDB();
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = dataTable;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Database.AddCustomer("Nome", "Cognome");
        }

        private void buttonRecoverByIndex_Click(object sender, EventArgs e)
        {
            var dataTable = Database.RecoverByIndex(comboBox1.Text);
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = dataTable;
            }
        }

        private void buttonRemoveByIndex_Click(object sender, EventArgs e)
        {
            var dataTable = Database.RemoveByIndex(comboBox1.Text);
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = dataTable;
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }
    }
}
