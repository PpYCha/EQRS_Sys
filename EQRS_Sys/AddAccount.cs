using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EQRS_Sys
{
    public partial class AddAccount : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2H9N6CS;Initial Catalog=EQRS_4H;Integrated Security=True");

        public AddAccount()
        {
            InitializeComponent();
        }

        private void btnCancelAcc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveAcc_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ADMIN(FirstName, LastName, Age, Birthday, Address, ContactNumber,Email, Username, Password)"
                + "values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"') ";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Account saved successfully!");
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
