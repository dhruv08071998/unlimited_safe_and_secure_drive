using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DE_project
{
    public partial class Form3 : Form
    {
        Timer t = new Timer();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            error.Hide();
            Fexist.Hide();
            ctime.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            Schedule.Enabled = false;  
            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.t_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method
 
        }

         public OpenFileDialog op1;
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            label5.Text = time;
            
            if (Schedule.Enabled == false)
            {
                               
                if (time == textBox2.Text)
                {
                    string destinationFile = op1.FileName;
                    string[] paths = destinationFile.Split('\\');
                    
                   int count = 0;
                    string[] FName;
                    foreach (string s in op1.FileNames)
                    {
                        FName = s.Split('\\');
                        File.Copy(s, "C:\\file\\" + FName[FName.Length - 1]);
                        count++;
                    }
                    
                    if (1==1)
                    {
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.Icon = new System.Drawing.Icon(@"C:\Users\Dhruv\Desktop\DE_project\images_5SO_icon.ico");
                        notifyIcon1.BalloonTipText = "Your File is "+paths[paths.Length - 1]+" Uploded";
                        notifyIcon1.BalloonTipTitle = "USSD";
                        notifyIcon1.Text = "USSD";
                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(1000);
                    }
                    
                    try
                    {
                        File.Delete(op1.FileName);
                    }
                    catch (IOException iox)
                    {
                        Console.WriteLine(iox.Message);
                    }
                }
                    
                    if (Schedule.Enabled == false)
                    {
                        if (time == textBox3.Text)
                        {
                            string destinationFile = op1.FileName;
                            string[] paths = destinationFile.Split('\\');
                            string str = "";
                            string dpath = "C:\\file\\" + paths[paths.Length - 1];
                            for (int i = 0; i < paths.Length - 1; i++)
                            {
                                str = str + paths[i] + "\\";
                            }
                            str = str + paths[paths.Length - 1];
                            File.Copy(dpath, str);
                            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                            notifyIcon1.Icon = new System.Drawing.Icon(@"C:\Users\Dhruv\Desktop\DE_project\images_5SO_icon.ico");
                            notifyIcon1.BalloonTipText = "You File is "+paths[paths.Length - 1]+ " Download as per previous location";
                            notifyIcon1.BalloonTipTitle = "USSD";
                            notifyIcon1.Text = "USSD";
                            notifyIcon1.Visible = true;
                            notifyIcon1.ShowBalloonTip(1000);
                            textBox1.Enabled = true;
                            textBox2.Enabled = true;
                            textBox3.Enabled = true;
                            Schedule.Enabled = true;
                            Browse.Enabled = true;
                        }
                    }
                }
            }
        

        private void Schedule_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            string msg="";
            
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex
                   (@"^(?:([01]?\d|2[0-3]):([0-5]?\d):)?([0-5]?\d)$");
            if (textBox2.Text != string.Empty)
            {
                if ((!expr.IsMatch(textBox2.Text)))
                {
                    flag = false;
                    msg = msg + "Enter Upload time proper format";
                }    
            }
            else
            {
                flag = false;
                msg = msg + " ,Enter Upload time ";
            }
            if (textBox3.Text != string.Empty)
            {
                if (!expr.IsMatch(textBox3.Text))
                {
                    flag = false;
                    msg = msg + " ,Enter Download time proper format";
                }
            }
            else
            {
                flag = false;
                msg = msg + " ,Enter Download time";

            }
            if (flag==false)
            {
                error.Text = msg;
                error.Show();
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            if (flag)
            {
                Schedule.Enabled = false;
                Browse.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                ctime.Enabled = true;
                error.Hide();
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            op1 = new OpenFileDialog();
            op1.Multiselect = true;
            op1.ShowDialog();
            op1.Filter = "allfiles|*.xls";
            textBox1.Text = op1.FileName;
            string destinationFile = op1.FileName;
            string[] paths = destinationFile.Split('\\');
            string dpath = "C:\\file\\" + paths[paths.Length - 1];
            if (File.Exists(dpath))
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                Schedule.Enabled = false;
                Fexist.Show();
                Fexist.Text = "File Already Exist";
            }
            else
            {
                Fexist.Hide();
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                Schedule.Enabled = true;
            }
            
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void ctime_Click(object sender, EventArgs e)
        {
            Schedule.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            Browse.Enabled = true;
            textBox1.Enabled = true;
        }

       

       
    }
}
