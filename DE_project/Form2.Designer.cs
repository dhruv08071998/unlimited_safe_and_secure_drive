namespace DE_project
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.UName = new System.Windows.Forms.Label();
            this.EmailId = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Confirm_Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Already_Registered = new System.Windows.Forms.LinkLabel();
            this.SignUp = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNo = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.errors = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // UName
            // 
            this.UName.AutoSize = true;
            this.UName.Location = new System.Drawing.Point(116, 110);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(53, 17);
            this.UName.TabIndex = 0;
            this.UName.Text = "Name :";
            // 
            // EmailId
            // 
            this.EmailId.AutoSize = true;
            this.EmailId.Location = new System.Drawing.Point(116, 167);
            this.EmailId.Name = "EmailId";
            this.EmailId.Size = new System.Drawing.Size(65, 17);
            this.EmailId.TabIndex = 1;
            this.EmailId.Text = "Email Id :";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(116, 284);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(77, 17);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password :";
            // 
            // Confirm_Password
            // 
            this.Confirm_Password.AutoSize = true;
            this.Confirm_Password.Location = new System.Drawing.Point(116, 333);
            this.Confirm_Password.Name = "Confirm_Password";
            this.Confirm_Password.Size = new System.Drawing.Size(129, 17);
            this.Confirm_Password.TabIndex = 3;
            this.Confirm_Password.Text = "Confirm Password :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(295, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(181, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(295, 328);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(181, 22);
            this.textBox4.TabIndex = 7;
            // 
            // Already_Registered
            // 
            this.Already_Registered.AutoSize = true;
            this.Already_Registered.Location = new System.Drawing.Point(85, 477);
            this.Already_Registered.Name = "Already_Registered";
            this.Already_Registered.Size = new System.Drawing.Size(141, 17);
            this.Already_Registered.TabIndex = 8;
            this.Already_Registered.TabStop = true;
            this.Already_Registered.Text = "Already Registered ?";
            this.Already_Registered.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Already_Registered_LinkClicked);
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(119, 406);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(82, 33);
            this.SignUp.TabIndex = 9;
            this.SignUp.Text = "SignUp";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(388, 406);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(88, 33);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click_1);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(496, 328);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(151, 17);
            this.Error.TabIndex = 11;
            this.Error.Text = "Password is Not Match";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unlimited Safe and Secured Drive";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PhoneNo
            // 
            this.PhoneNo.AutoSize = true;
            this.PhoneNo.Location = new System.Drawing.Point(116, 228);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(75, 17);
            this.PhoneNo.TabIndex = 13;
            this.PhoneNo.Text = "PhoneNo :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(295, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 22);
            this.textBox5.TabIndex = 14;
            // 
            // errors
            // 
            this.errors.AutoSize = true;
            this.errors.ForeColor = System.Drawing.Color.Red;
            this.errors.Location = new System.Drawing.Point(41, 369);
            this.errors.Name = "errors";
            this.errors.Size = new System.Drawing.Size(46, 17);
            this.errors.TabIndex = 15;
            this.errors.Text = "label2";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 529);
            this.Controls.Add(this.errors);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.PhoneNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.Already_Registered);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Confirm_Password);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.EmailId);
            this.Controls.Add(this.UName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "USSD";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UName;
        private System.Windows.Forms.Label EmailId;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Confirm_Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.LinkLabel Already_Registered;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PhoneNo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label errors;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}