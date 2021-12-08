namespace Laba4
{
    partial class frmProc2_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_res = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.date_exam = new System.Windows.Forms.DateTimePicker();
            this.txt_stud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.txt_subj = new System.Windows.Forms.TextBox();
            this.txt_mark = new System.Windows.Forms.TextBox();
            this.txt_lect = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(12, 221);
            this.txt_res.Name = "txt_res";
            this.txt_res.ReadOnly = true;
            this.txt_res.Size = new System.Drawing.Size(184, 28);
            this.txt_res.TabIndex = 2;
            this.txt_res.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_exam
            // 
            this.date_exam.Location = new System.Drawing.Point(76, 66);
            this.date_exam.Name = "date_exam";
            this.date_exam.Size = new System.Drawing.Size(120, 20);
            this.date_exam.TabIndex = 4;
            // 
            // txt_stud
            // 
            this.txt_stud.Location = new System.Drawing.Point(76, 14);
            this.txt_stud.Margin = new System.Windows.Forms.Padding(5);
            this.txt_stud.Name = "txt_stud";
            this.txt_stud.Size = new System.Drawing.Size(120, 20);
            this.txt_stud.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Лектор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Оценка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Дата";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(26, 44);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(42, 13);
            this.lb2.TabIndex = 44;
            this.lb2.Text = "Группа";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 18);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(56, 13);
            this.lb1.TabIndex = 43;
            this.lb1.Text = "Фамилия";
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(76, 41);
            this.txt_group.Margin = new System.Windows.Forms.Padding(5);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(120, 20);
            this.txt_group.TabIndex = 49;
            // 
            // txt_subj
            // 
            this.txt_subj.Location = new System.Drawing.Point(76, 94);
            this.txt_subj.Margin = new System.Windows.Forms.Padding(5);
            this.txt_subj.Name = "txt_subj";
            this.txt_subj.Size = new System.Drawing.Size(120, 20);
            this.txt_subj.TabIndex = 51;
            // 
            // txt_mark
            // 
            this.txt_mark.Location = new System.Drawing.Point(76, 145);
            this.txt_mark.Margin = new System.Windows.Forms.Padding(5);
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(120, 20);
            this.txt_mark.TabIndex = 53;
            // 
            // txt_lect
            // 
            this.txt_lect.Location = new System.Drawing.Point(76, 118);
            this.txt_lect.Margin = new System.Windows.Forms.Padding(5);
            this.txt_lect.Name = "txt_lect";
            this.txt_lect.Size = new System.Drawing.Size(120, 20);
            this.txt_lect.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Сообщение";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=PETARA94-W11;Initial Catalog=ivanovPS_idb19-05;Integrated Security=Tr" +
    "ue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "proc2_2";
            this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@s_fam", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@s_gr", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@ex_date", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@subj", System.Data.SqlDbType.VarChar, 20),
            new System.Data.SqlClient.SqlParameter("@l_fam", System.Data.SqlDbType.VarChar, 25),
            new System.Data.SqlClient.SqlParameter("@mark", System.Data.SqlDbType.Int),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // frmProc2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(209, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mark);
            this.Controls.Add(this.txt_lect);
            this.Controls.Add(this.txt_subj);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.txt_stud);
            this.Controls.Add(this.date_exam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_res);
            this.Name = "frmProc2_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProc2_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txt_res;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_exam;
        private System.Windows.Forms.TextBox txt_stud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.TextBox txt_subj;
        private System.Windows.Forms.TextBox txt_mark;
        private System.Windows.Forms.TextBox txt_lect;
        private System.Windows.Forms.Label label4;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
    }
}