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
    public partial class frmInd : Form
    {
        public frmInd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var N = 1 + float.Parse(txt_N.Text) * 0.01;

            sqlCommand1.Parameters["@persent"].Value = N.ToString();
            sqlCommand1.Parameters["@min_stip"].Value = txt_M.Text;

            sqlConnection1.Open();

            sqlCommand1.ExecuteNonQuery();

            sqlConnection1.Close();

            txt_M.Text = "";
            txt_N.Text = "";
        }
    }
}
