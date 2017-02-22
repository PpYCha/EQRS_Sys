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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MEW-PC;Initial Catalog=EQRS;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ADMIN where Username = '"+textBox1.Text+"'and password = '"+textBox2.Text+"'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                AdminForm frm = new AdminForm();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            GuestForm frm = new GuestForm();
            frm.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
    }
}
