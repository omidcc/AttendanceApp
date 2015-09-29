using System;
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
                    


                }
                if (flag == 1)
                    MessageBox.Show("Invalid username or password");
            }




        }
        StuffManager aStuffManager=new StuffManager();
        List<Stuff>aStuffList=new List<Stuff>(); 
        void getAllUser()
        {
            aStuffList = aStuffManager.GetAllStuff();

        }
    }
}
