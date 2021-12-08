using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class frmFunc2_4 : Form
    {
        public frmFunc2_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand1.Parameters["@group"].Value = txt_group.Text;

            sqlConnection1.Open();

            txt_res.Text = sqlCommand1.ExecuteScalar().ToString();

            sqlConnection1.Close();
        }
    }
}
