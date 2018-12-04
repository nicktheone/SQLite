using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mk2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
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
            Database.AddCustomer(customer);
        }
    }
}
