namespace IT481_Unit3_Woodbury
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnConnect = new Button();
            tbUser = new TextBox();
            tbPassword = new TextBox();
            tbServer = new TextBox();
            tbDatabase = new TextBox();
            btnQuery1 = new Button();
            btnQuery4 = new Button();
            btnQuery2 = new Button();
            btnQuery5 = new Button();
            btnQuery3 = new Button();
            btnQuery6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "USER:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(424, 60);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 2;
            label3.Text = "SERVER:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(397, 116);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 3;
            label4.Text = "DATABASE:";
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(287, 197);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(238, 33);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "CONNECT";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbUser.Location = new Point(169, 52);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(210, 33);
            tbUser.TabIndex = 5;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(169, 108);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(210, 33);
            tbPassword.TabIndex = 6;
            // 
            // tbServer
            // 
            tbServer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbServer.Location = new Point(539, 57);
            tbServer.Name = "tbServer";
            tbServer.Size = new Size(249, 33);
            tbServer.TabIndex = 7;
            // 
            // tbDatabase
            // 
            tbDatabase.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDatabase.Location = new Point(539, 110);
            tbDatabase.Name = "tbDatabase";
            tbDatabase.Size = new Size(249, 33);
            tbDatabase.TabIndex = 8;
            // 
            // btnQuery1
            // 
            btnQuery1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery1.Location = new Point(22, 308);
            btnQuery1.Name = "btnQuery1";
            btnQuery1.Size = new Size(238, 38);
            btnQuery1.TabIndex = 9;
            btnQuery1.Text = "Get Customer Count";
            btnQuery1.UseVisualStyleBackColor = true;
            btnQuery1.Click += btnQuery1_Click;
            // 
            // btnQuery4
            // 
            btnQuery4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery4.Location = new Point(22, 367);
            btnQuery4.Name = "btnQuery4";
            btnQuery4.Size = new Size(238, 38);
            btnQuery4.TabIndex = 10;
            btnQuery4.Text = "Get Order Ship Names";
            btnQuery4.UseVisualStyleBackColor = true;
            btnQuery4.Click += btnQuery4_Click;
            // 
            // btnQuery2
            // 
            btnQuery2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery2.Location = new Point(287, 308);
            btnQuery2.Name = "btnQuery2";
            btnQuery2.Size = new Size(238, 38);
            btnQuery2.TabIndex = 11;
            btnQuery2.Text = "Get Company Names";
            btnQuery2.UseVisualStyleBackColor = true;
            btnQuery2.Click += btnQuery2_Click;
            // 
            // btnQuery5
            // 
            btnQuery5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery5.Location = new Point(287, 367);
            btnQuery5.Name = "btnQuery5";
            btnQuery5.Size = new Size(238, 38);
            btnQuery5.TabIndex = 12;
            btnQuery5.Text = "Get Employee Count";
            btnQuery5.UseVisualStyleBackColor = true;
            btnQuery5.Click += btnQuery5_Click;
            // 
            // btnQuery3
            // 
            btnQuery3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery3.Location = new Point(550, 308);
            btnQuery3.Name = "btnQuery3";
            btnQuery3.Size = new Size(238, 38);
            btnQuery3.TabIndex = 13;
            btnQuery3.Text = "Get Order Count";
            btnQuery3.UseVisualStyleBackColor = true;
            btnQuery3.Click += btnQuery3_Click;
            // 
            // btnQuery6
            // 
            btnQuery6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuery6.Location = new Point(550, 367);
            btnQuery6.Name = "btnQuery6";
            btnQuery6.Size = new Size(238, 38);
            btnQuery6.TabIndex = 14;
            btnQuery6.Text = "Get Employee Names";
            btnQuery6.UseVisualStyleBackColor = true;
            btnQuery6.Click += btnQuery6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuery6);
            Controls.Add(btnQuery3);
            Controls.Add(btnQuery5);
            Controls.Add(btnQuery2);
            Controls.Add(btnQuery4);
            Controls.Add(btnQuery1);
            Controls.Add(tbDatabase);
            Controls.Add(tbServer);
            Controls.Add(tbPassword);
            Controls.Add(tbUser);
            Controls.Add(btnConnect);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Northwind App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConnect;
        private TextBox tbUser;
        private TextBox tbPassword;
        private TextBox tbServer;
        private TextBox tbDatabase;
        private Button btnQuery1;
        private Button btnQuery4;
        private Button btnQuery2;
        private Button btnQuery5;
        private Button btnQuery3;
        private Button btnQuery6;
    }
}