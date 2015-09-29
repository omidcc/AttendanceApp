﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceAPP.BLL;
using AttendanceAPP.Model;

namespace AttendanceAPP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            getAllUser();
<<<<<<< HEAD
<<<<<<< HEAD
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string message="";
            if (username == "admin" && password == "admin")
            {
                
                Admin admin=new Admin();
                this.Hide();

                admin.Closed+=(s,args)=>this.Close();
=======
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
            IntialCondition();

        }

        private DateTime timeStart = DateTime.Parse("6:00");
        private DateTime timeEnd = DateTime.Parse("12:00");
        private string role="Employee";
        
        private void IntialCondition()
        {
            userComboBox.Items.Add("Employee");
            userComboBox.Items.Add("Admin");
            userComboBox.SelectedIndex = 0;


            TimeChecker();


        }

        private void TimeChecker()
        {
            DateTime currentTime = DateTime.Now;
            if ((currentTime >= timeStart) && (currentTime <= timeEnd))
            {
                logOutButton.Enabled = false;
                logOnButton.Enabled = true;
            }
            else
            {
                logOnButton.Enabled = false;
                logOutButton.Enabled = true;
            }
        }

        public void AdminRole()
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string message = "";
            if (username == "admin" && password == "admin")
            {

                Admin admin = new Admin();
                this.Hide();

                admin.Closed += (s, args) => this.Close();
<<<<<<< HEAD
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
                admin.Show();
            }
            else
            {
                int flag = 1;
                foreach (Stuff stuff in aStuffList)
                {
                    if ((stuff.Username == username) && (stuff.Password == password))
                    {
                        DateTime aDateTime = DateTime.Today.Date.Date;
                        aStuffManager.AttendanceSubmit(aDateTime, stuff.Id, out message);
                        MessageBox.Show(message);
                        userNameTextBox.Text = passwordTextBox.Text = "";
                        flag = 0;
                        break;
                    }
<<<<<<< HEAD
<<<<<<< HEAD
                    
=======

>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======

>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c


                }
                if (flag == 1)
                    MessageBox.Show("Invalid username or password");
            }


<<<<<<< HEAD
<<<<<<< HEAD


=======
 
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
 
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
        }
        StuffManager aStuffManager=new StuffManager();
        List<Stuff>aStuffList=new List<Stuff>(); 
        void getAllUser()
        {
            aStuffList = aStuffManager.GetAllStuff();

        }
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c

        private void logOutButton_MouseEnter(object sender, EventArgs e)
        {
            logOutButton.BackColor = Color.LightGray;
        }

        private void logOutButton_MouseLeave(object sender, EventArgs e)
        {
            logOutButton.BackColor = Color.WhiteSmoke;
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userComboBox.SelectedIndex == 0)
            {

                logOutButton.Text = "Log Out";
                remarkLabel.Show();
                remarksTextBox.Show();
                logOnButton.Show();
                TimeChecker();
                




            }
            else
            {
                remarkLabel.Hide();
                remarksTextBox.Hide();
                logOutButton.Text = "Submit";
                logOnButton.Hide();
                if (logOutButton.Enabled == false)
                {
                    logOutButton.Enabled = true;
                }
              
            }
        }

        private Attendance myAttendance;
        private Stuff myStuff;
        private void logOnButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hide Work");
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string remark = remarksTextBox.Text;
            foreach (Stuff stuff in aStuffList)
            {
                if (username == stuff.Username && password == stuff.Password)
                {
                    string date = DateTime.Now.ToString();
                   aStuffManager.submitAttendance(stuff.Id,date);

                    int id=aStuffManager.getCurrentDateId(stuff.Id,date);

                    DateTime time=DateTime.Now.ToLocalTime();
                    aStuffManager.SubmitLogin(id,time,remark);
                   


                }
            }
           

            
        }

       

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logOutButton.PerformClick();
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            if (userComboBox.SelectedIndex == 0)
            {

            }
            else
            {
                AdminRole();
            }
        }

        private void logOutButton_MouseHover(object sender, EventArgs e)
        {
            logOutButton.BackColor = Color.LightGray;
        }

        
<<<<<<< HEAD
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
    }
}
