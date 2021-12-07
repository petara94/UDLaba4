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
    public partial class frmProc2_1 : Form
    {
        public frmProc2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command2_1.Parameters["@stud_fam"].Value = this.txt_stud.Text;
            command2_1.Parameters["@newgroup"].Value = this.txt_group.Text;

            sqlConnection1.Open();

            command2_1.ExecuteNonQuery();

            sqlConnection1.Close();

            int res = (int)command2_1.Parameters["@res"].Value;
            string txt_res = "";

            switch (res)
            {
                case 1:
                    txt_res = "Перевод в другую группу успешно выполнен";
                    break;
                case -1:
                    txt_res = "Перевод в другую группу не выполнен! Нет такого студента";
                    break;
                case -2:
                    txt_res = "Перевод в другую группу не выполнен! Нет такой группы";
                    break;
                default:
                    txt_res = "Неизвестная ошибка";
                    break;
            }

            this.txt_res.Text = txt_res;
        }
    }
}
