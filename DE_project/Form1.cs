using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DE_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            up.Hide();
            up1.Hide();
        
        }

        private void NewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void SignIn_Click(object sender, EventArgs e)
        {
            string msg = "";
            Boolean indicator = true;
            if ((textBox1.Text == string.Empty && textBox2.Text == string.Empty))
            {
                indicator = false;
                msg = msg + "Enter Username and Password";
            }
            if (textBox1.Text == ""&& indicator)
            {
                msg = " Enter Username";
                indicator = false;

            }
            if (textBox2.Text == "" && indicator)
            {
                msg = msg + " Enter Password";
                indicator = false;
            }
            
            
                        
                up.Text = msg;
                up.Show();
            
            Boolean flag = true;
            string str = @"Data Source=.\SQLEXPRESS01;Integrated Security=True;";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users",con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Object email = rdr["Email"];
                Object Password = rdr["Password"];
                if ( Convert.ToString(email)== textBox1.Text && Convert.ToString(Password) == textBox2.Text)
                {
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                    flag = false;
                    
                }
            }
            if (flag && indicator)
            {
                up1.Text = "Invalid Id and Password";
                up1.Show();
            }

            //this.Hide();

        }
    }
}
