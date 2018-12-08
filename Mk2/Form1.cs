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
            var sql = "CREATE TABLE IF NOT EXISTS customers (id INTEGER PRIMARY KEY, firstName TEXT, lastName TEXT, address TEXT, phone TEXT, email TEXT, notes TEXT); " +
                      "CREATE TABLE IF NOT EXISTS orders (id INTEGER PRIMARY KEY, product TEXT, date TEXT, customerId INTEGER, FOREIGN KEY (customerId) REFERENCES customers(id))";
            var command = new SQLiteCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageCustomer)
            {
                var customer = new Customer()
                {
                    FirstName = TextBoxFirstName.Text,
                    LastName = TextBoxLastName.Text,
                    Address = TextBoxAddress.Text,
                    Phone = TextBoxPhone.Text,
                    Email = TextBoxEmail.Text,
                    Notes = TextBoxNotes.Text
                };

                if (!String.IsNullOrEmpty(TextBoxFirstName.Text) && !String.IsNullOrEmpty(TextBoxLastName.Text))
                {
                    Database.CreateCustomer(customer);
                }
                else
                {
                    MessageBox.Show("First name and last name required");
                }
                ClearText();
            }
            else
            {
                var order = new Order()
                {
                    Product = TextBoxProduct.Text,
                    Date = TextBoxDate.Text,
                    CustomerId = Convert.ToInt16(TextBoxCustomerId.Text)
                };

                if (!String.IsNullOrEmpty(TextBoxProduct.Text) && !String.IsNullOrEmpty(TextBoxCustomerId.Text))
                {
                    Database.CreateOrder(order);
                }
                else
                {
                    MessageBox.Show("Product and Customer Id required");
                }
                ClearText();
            }
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageCustomer)
            {
                List<TextBox> textBoxes = new List<TextBox>()
            {
                TextBoxFirstName,
                TextBoxLastName,
                TextBoxAddress,

                TextBoxPhone,
                TextBoxEmail,
                TextBoxNotes
            };

                if (textBoxes.All(p => string.IsNullOrWhiteSpace(p.Text)))
                {
                    var dataTable = Database.ReadDB("customers");
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.Refresh();
                        dataGridView1.DataSource = dataTable;
                    }
                }
                else
                {
                    var customer = new Customer()
                    {
                        FirstName = TextBoxFirstName.Text,
                        LastName = TextBoxLastName.Text,
                        Address = TextBoxAddress.Text,
                        Phone = TextBoxPhone.Text,
                        Email = TextBoxEmail.Text,
                        Notes = TextBoxNotes.Text
                    };

                    var dataTable = Database.ReadCustomer(customer);
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.Refresh();
                        dataGridView1.DataSource = dataTable;
                    }
                    ClearText();
                }
            }
            else
            {
                var dataTable = Database.ReadDB("orders");
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Id = Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
                FirstName = TextBoxFirstName.Text,
                LastName = TextBoxLastName.Text,
                Address = TextBoxAddress.Text,
                Phone = TextBoxPhone.Text,
                Email = TextBoxEmail.Text,
                Notes = TextBoxNotes.Text
            };

            Database.UpdateCustomer(customer);
            ClearText();
            ButtonUpdate.Enabled = false;
            ButtonDelete.Enabled = false;

            var dataTable = Database.ReadDB("customers");
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = dataTable;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Id = Convert.ToInt16(dataGridView1.Tag)
            };

            Database.DeleteCustomer(customer);
            ClearText();
            ButtonUpdate.Enabled = false;
            ButtonDelete.Enabled = false;

            var dataTable = Database.ReadDB("customers");
            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            TextBoxFirstName.Text = row.Cells[1].Value.ToString();
            TextBoxLastName.Text = row.Cells[2].Value.ToString();
            TextBoxAddress.Text = row.Cells[3].Value.ToString();
            TextBoxPhone.Text = row.Cells[4].Value.ToString();
            TextBoxEmail.Text = row.Cells[5].Value.ToString();
            TextBoxNotes.Text = row.Cells[6].Value.ToString();
            dataGridView1.Tag = row.Cells[0].Value.ToString();

            ButtonUpdate.Enabled = true;
            ButtonDelete.Enabled = true;
        }
        
        //Helper methods
        private void ClearText()
        {
            List<TextBox> textBoxes = new List<TextBox>()
            {
                TextBoxFirstName,
                TextBoxLastName,
                TextBoxAddress,
                TextBoxPhone,
                TextBoxEmail,
                TextBoxNotes
            };

            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        //End helper methods
    }
}
