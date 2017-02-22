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
    public partial class ACCOUNT : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=MEW-PC;Initial Catalog=EQRS;Integrated Security=True");
        public ACCOUNT()
        {
            InitializeComponent();
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            AddAccount frm = new AddAccount();
            frm.Show();
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            UpdateAccount frm = new UpdateAccount();
            frm.Show();
        }

        private void ACCOUNT_Load(object sender, EventArgs e)
        {
            disp_dataAcc();
        }

        public void disp_dataAcc()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select FirstName, LastName, Age, Birthday, Address, Email, ContactNumber from ADMIN";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
