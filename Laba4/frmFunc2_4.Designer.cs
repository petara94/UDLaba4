namespace Laba4
{
    partial class frmFunc2_4
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
            this.txt_group = new System.Windows.Forms.TextBox();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(90, 14);
            this.txt_group.Margin = new System.Windows.Forms.Padding(5);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(100, 20);
            this.txt_group.TabIndex = 2;
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(90, 77);
            this.txt_res.Margin = new System.Windows.Forms.Padding(5);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(100, 20);
            this.txt_res.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Количество";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(38, 17);
            this.lb2.Margin = new System.Windows.Forms.Padding(5);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(42, 13);
            this.lb2.TabIndex = 25;
            this.lb2.Text = "Группа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT dbo.func2_4(@group)";
            this.sqlCommand1.Connection = this.sqlConnection1;
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@group", System.Data.SqlDbType.VarChar, 20)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=PETARA94-W11;Initial Catalog=ivanovPS_idb19-05;Integrated Security=Tr" +
    "ue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // frmFunc2_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(204, 111);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.txt_group);
            this.Name = "frmFunc2_4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFunc2_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button button1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}