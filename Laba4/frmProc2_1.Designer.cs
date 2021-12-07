namespace Laba4
{
    partial class frmProc2_1
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.command2_1 = new System.Data.SqlClient.SqlCommand();
            this.txt_res = new System.Windows.Forms.RichTextBox();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.txt_stud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=PETARA94-W11;Initial Catalog=ivanovPS_idb19-05;Integrated Security=Tr" +
    "ue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // command2_1
            // 
            this.command2_1.CommandText = "proc2_1";
            this.command2_1.CommandType = System.Data.CommandType.StoredProcedure;
            this.command2_1.Connection = this.sqlConnection1;
            this.command2_1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@stud_fam", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@newgroup", System.Data.SqlDbType.VarChar),
            new System.Data.SqlClient.SqlParameter("@res", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(12, 99);
            this.txt_res.Name = "txt_res";
            this.txt_res.ReadOnly = true;
            this.txt_res.Size = new System.Drawing.Size(360, 90);
            this.txt_res.TabIndex = 0;
            this.txt_res.Text = "";
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(74, 49);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(100, 20);
            this.txt_group.TabIndex = 1;
            // 
            // txt_stud
            // 
            this.txt_stud.Location = new System.Drawing.Point(74, 17);
            this.txt_stud.Name = "txt_stud";
            this.txt_stud.Size = new System.Drawing.Size(100, 20);
            this.txt_stud.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сообщение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_stud);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.txt_res);
            this.Name = "frmProc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProc2_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand command2_1;
        private System.Windows.Forms.RichTextBox txt_res;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.TextBox txt_stud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}