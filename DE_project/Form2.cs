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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void Already_Registered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            string msg = "";
            if (textBox1.Text == string.Empty)
            {
                flag = false;
                msg = "Enter Name";
            }
            if (textBox2.Text != string.Empty)
            {
                System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex
                    (@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (!expr.IsMatch(textBox2.Text))
                {
                    flag = false;
                    msg = msg + " ,Email Id is not valid";
                }
                string str = @"Data Source=.\SQLEXPRESS01;Integrated Security=True;";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Users", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Object email = rdr["Email"];
                    if (Convert.ToString(email) == textBox2.Text)
                    {
                        flag = false;
                        msg = msg + " ,Email Id is Already Exist";
                    }
                }

            }
            else
            {
                flag = false;
                msg = msg + " ,Enter Email";
            }
            double no = 0;
            if (textBox5.Text != string.Empty)
            {
                if (!double.TryParse(textBox5.Text, out no))
                {
                    msg = msg + " ,Phone no is not Character";
                    flag = false;
                }
                else if (textBox5.Text.Length != 10)
                {
                    flag = false;
                    msg = msg + " ,PhoneNo must be 10 Digits";
                }
            }
            else
            {
                flag = false;
                msg = msg + " ,Enter PhoneNo";
            }
            if (textBox3.Text == string.Empty)
            {
                flag = false;
                msg = msg + " ,Enter Password";
            }
            if (textBox4.Text == string.Empty)
            {
                flag = false;
                msg = msg + " ,Enter Confirm Password";
            }
            
            if (textBox3.Text == textBox4.Text && flag)
            {
                errors.Hide();
                string str = @"Data Source=.\SQLEXPRESS01;Integrated Security=True;";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                string s = @"insert into Users(Name,Email,Password,PhoneNo) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"
                    + textBox5.Text + "')";
                SqlCommand sc = new SqlCommand(s, con);
                DataSet ds = new DataSet();
                sc.ExecuteNonQuery();
                MessageBox.Show("You are Registered");
            }
            else if(flag)
            {
                Error.Show();
            }
            errors.Text = msg;
            errors.Show();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            Error.Hide();
            errors.Hide();
                      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

      

       
    }
}
