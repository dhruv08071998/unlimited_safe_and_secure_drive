namespace DE_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Label();
            this.up1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(130, 143);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(81, 17);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Username :";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(130, 202);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(77, 17);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 202);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(187, 22);
            this.textBox2.TabIndex = 3;
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(132, 302);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(75, 29);
            this.SignIn.TabIndex = 4;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(385, 302);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 28);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewUser
            // 
            this.NewUser.AutoSize = true;
            this.NewUser.Location = new System.Drawing.Point(63, 379);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(145, 17);
            this.NewUser.TabIndex = 6;
            this.NewUser.TabStop = true;
            this.NewUser.Text = "New User Click Here?";
            this.NewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewUser_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unlimited Safe and Secured Drive";
            // 
            // up
            // 
            this.up.AutoSize = true;
            this.up.ForeColor = System.Drawing.Color.Red;
            this.up.Location = new System.Drawing.Point(265, 241);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(46, 17);
            this.up.TabIndex = 10;
            this.up.Text = "label1";
            // 
            // up1
            // 
            this.up1.AutoSize = true;
            this.up1.ForeColor = System.Drawing.Color.Red;
            this.up1.Location = new System.Drawing.Point(265, 275);
            this.up1.Name = "up1";
            this.up1.Size = new System.Drawing.Size(46, 17);
            this.up1.TabIndex = 11;
            this.up1.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 455);
            this.Controls.Add(this.up1);
            this.Controls.Add(this.up);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "USSD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.LinkLabel NewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label up1;
    }
}

