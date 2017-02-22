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
    public partial class AdminForm : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=MEW-PC;Initial Catalog=EQRS;Integrated Security=True");
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ACCOUNT frm = new ACCOUNT();
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            REPORT frm = new REPORT();
            frm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
