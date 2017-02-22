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
    public partial class UpdateAccount : Form
    {
        public UpdateAccount()
        {
            InitializeComponent();
        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eQRSDataSet.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter.Fill(this.eQRSDataSet.ADMIN);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MEW-PC;Initial Catalog=EQRS;Integrated Security=True");
            string query = "SELECT * FROM dbo.Admin";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int strID = reader.GetInt32(0);
                

                comboBox1.Text = strID.ToString();
                
            }

            string FName = reader.GetString(1);
            string LName = reader.GetString(2);
            int age = reader.GetInt32(3);
            DateTime birthDate = reader.GetDateTime(4);
            string address = reader.GetString(5);
            long contNum = reader.GetInt64(7);
            string userName = reader.GetString(8);
            string passWord = reader.GetString(9);

            textBox1.Text = FName;
            textBox2.Text = LName;
            textBox3.Text = age.ToString();
            textBox4.Text = birthDate.ToShortDateString();
            textBox5.Text = address;
            textBox6.Text = contNum.ToString();
            textBox7.Text = userName;
            textBox8.Text = passWord;

        }
    }
}
