using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace le_cantine
{
    public partial class ConnectAdmin : Form
    {
        public ConnectAdmin()
        {
            InitializeComponent();
            BDD.GetConnexion();
        }

        private void ConnectAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void TabModifUser_Click(object sender, EventArgs e)
        {

        }

    }
}
