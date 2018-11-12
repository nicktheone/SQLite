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
    public partial class Form1 : Form
    {
        private SQLiteConnection conn = new SQLiteConnection("Data Source=prova.sqlite;Version=3;");
        private SQLiteCommand command;
        private string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection.CreateFile("prova.sqlite");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "CREATE TABLE clienti (indice INTEGER, nome VARCHAR, cognome VARCHAR, indirizzo VARCHAR, telefono VARCHAR, email VARCHAR, note VARCHAR)";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "INSERT INTO clienti (nome, cognome) VALUES ('nome1', 'cognome1')";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
            sql = "INSERT INTO clienti (nome, cognome) VALUES ('nome2', 'cognome2')";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
            sql = "INSERT INTO clienti (nome, cognome) VALUES ('nome3', 'cognome3')";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "SELECT * FROM clienti";
            command = new SQLiteCommand(sql, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            conn.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            aggCliente f = new aggCliente();
            f.ShowDialog();
        }
    }
}
