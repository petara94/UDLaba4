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
    public partial class frmFunc2_3 : Form
    {
        public frmFunc2_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand1.Parameters["@group"].Value = txt_group.Text;

            sqlConnection1.Open();

            var res = new DataTable();
            res.Load(sqlCommand1.ExecuteReader());

            datagrid_res.DataSource = res;

            sqlConnection1.Close();
        }
    }
}
