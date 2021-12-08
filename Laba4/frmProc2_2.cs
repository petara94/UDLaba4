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
    public partial class frmProc2_2 : Form
    {
        public frmProc2_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sqlCommand1.Parameters["@s_fam"].Value = this.txt_stud.Text;
            sqlCommand1.Parameters["@s_gr"].Value = this.txt_group.Text;
            sqlCommand1.Parameters["@ex_date"].Value = this.date_exam.Text;
            sqlCommand1.Parameters["@subj"].Value = this.txt_subj.Text;
            sqlCommand1.Parameters["@l_fam"].Value = this.txt_lect.Text;
            sqlCommand1.Parameters["@mark"].Value = this.txt_mark.Text;


            sqlConnection1.Open();

            sqlCommand1.ExecuteNonQuery();

            sqlConnection1.Close();

            int res = (int)sqlCommand1.Parameters["@res"].Value;
            string txt_res = "";

            switch (res)
            {
                case 1:
                    txt_res = "Запись добавлена";
                    break;
                case 2:
                    txt_res = "Запись обновлена";
                    break;
                default:
                    txt_res = "Неизвестная ошибка";
                    break;
            }
            this.txt_res.Text = txt_res;
        }

    }
}
