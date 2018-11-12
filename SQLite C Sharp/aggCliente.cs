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

namespace SQLite_C_Sharp
{
    public partial class aggCliente : Form
    {

        public aggCliente()
        {
            InitializeComponent();
        }

        private void aggCliente_Load(object sender, EventArgs e)
        {
            //svuota i textbox
            foreach (Control a in this.Controls)
            {
                if (a is TextBox)
                {
                    a.Text = "";
                }
            }

        }

        private void aggCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //conn.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //SQLiteCommand command = new SQLiteCommand("INSERT INTO clienti (nome, cognome, indirizzo, telefono, email, note) VALUES (@nome, @cognome, @indirizzo, @telefono, @email, @note)", conn);
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = "INSERT INTO clienti (nome, cognome, indirizzo, telefono, email, note) VALUES (@nome, @cognome, @indirizzo, @telefono, @email, @note)";
            command.Parameters.AddWithValue("@nome", TextBox1.Text);
            command.Parameters.AddWithValue("@cognome", TextBox2.Text);
            command.Parameters.AddWithValue("@indirizzo", TextBox3.Text);
            command.Parameters.AddWithValue("@telefono", TextBox4.Text);
            command.Parameters.AddWithValue("@email", TextBox5.Text);
            command.Parameters.AddWithValue("@note", TextBox6.Text);
            command.Connection = new SQLiteConnection("Data Source=prova.sqlite;Version=3;");
            command.Connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
