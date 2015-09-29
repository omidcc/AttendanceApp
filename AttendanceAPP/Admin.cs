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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadComboBox();
<<<<<<< HEAD
<<<<<<< HEAD
=======
            
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
            
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
           
        }

        private void Admin_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            LoadComboBox();
            monthListComboBox.SelectedIndex = 0;
=======
            
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
            
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
        }
        List<Stuff>myStuffList=new List<Stuff>();
        StuffManager aStuffManager=new StuffManager();
        private void LoadComboBox()
        {
            myStuffList = aStuffManager.GetAllStuff();
            nameComboBox.Items.Clear();
            foreach (Stuff stuff in myStuffList)
            {
                nameComboBox.Items.Add(stuff.Name);
<<<<<<< HEAD
<<<<<<< HEAD
=======
               
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
               
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
              
            }
            nameComboBox.SelectedIndex = 0;
            
        }

        public void LoadComboZ()
        {
            
        }
        List<string>myAttendanceList=new List<string>();
<<<<<<< HEAD
<<<<<<< HEAD
        List<string> selectedDateList = new List<string>(); 
        private void searchButton_Click(object sender, EventArgs e)
        {
            
            string nameSearch = nameComboBox.SelectedItem.ToString();
            string monthSearch = monthListComboBox.SelectedItem.ToString();

            CallForAttendance(nameSearch);
            dateListView.Items.Clear();

            string test = month(monthSearch);
            foreach (string ss in myAttendanceList)
            {
                if (ss[0] == test[0])
                {
                    selectedDateList.Add(ss);
                }
                dateListView.Items.Add(ss);
            }
            
=======
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
        List<string> selectedDateList = new List<string>();
        private string firstDate;
        private string lastDate;

        private void searchButton_Click(object sender, EventArgs e)
        {
            dateListView.Items.Clear();

            string name = nameComboBox.SelectedItem.ToString();
            //month(monthListComboBox.SelectedItem.ToString());
            


            
            List<string> datList= aStuffManager.GetStuffAttendanceList(name,firstDate,lastDate );
            if (datList.Count <= 0)
            {
                MessageBox.Show(String.Format("In this month , {0} is not attended a single day", name));
            }
            else
            {
               
            }




<<<<<<< HEAD
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
        }
        
      

<<<<<<< HEAD
<<<<<<< HEAD
        void CallForAttendance(string nameSearch)
        {
            int myId = 0;

            foreach (Stuff stuff in myStuffList)
            {
                if (nameSearch == stuff.Name)
                {
                    myId = stuff.Id;
                    break;
                }
                
            }
            myAttendanceList = aStuffManager.GetAllAttendance(myId);
           
         
        }

        string month(string ss)
        {

             if (ss == "January")
                return "1";
             else if (ss == "February")
                 return "2";
             else if (ss == "March")
                 return "3";
             else if (ss == "April")
                 return "4";
             else if (ss == "May")
                 return "5";
             else if (ss == "June")
                 return "6";
             else if (ss == "July")
                 return "7";
             else if (ss == "August")
                 return "8";
             else if (ss == "September")
                 return "9";
             else if (ss == "October")
                 return "10";
             else if (ss == "November")
                 return "11";
           
             else return "12";
        }
=======
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
        


      public void month(string ss)
        {

          if (ss == "January")
          {
              firstDate = DateTime.Now.Year + "-01-01";
              lastDate = DateTime.Now.Year + "-01-31";
          }
             else if (ss == "February")
             {
                 string yr = null;
                 yr+=(DateTime.Now.Year);
                 int year = int.Parse(yr);

                 if ((year%400) == 0 || ((year%100 != 0) && (year%4 == 0)))
                 {
                     {
                         firstDate = DateTime.Now.Year + "-02-01";
                         lastDate = DateTime.Now.Year + "-02-29";
                     }
                 }
                 else
                 {
                     {
                         firstDate = DateTime.Now.Year + "-02-01";
                         lastDate = DateTime.Now.Year + "-02-28";
                     }
                 }
             }
             else if (ss == "March")
          {
              firstDate = DateTime.Now.Year + "-03-01";
              lastDate = DateTime.Now.Year + "-03-31";
          }
             else if (ss == "April")
          {
              firstDate = DateTime.Now.Year + "-04-01";
              lastDate = DateTime.Now.Year + "-04-30";
          }
             else if (ss == "May")
          {
              firstDate = DateTime.Now.Year + "-05-01";
              lastDate = DateTime.Now.Year + "-05-31";
          }
             else if (ss == "June")
          {
              firstDate = DateTime.Now.Year + "-06-01";
              lastDate = DateTime.Now.Year + "-06-30";
          }
             else if (ss == "July")
          {
              firstDate = DateTime.Now.Year + "-07-01";
              lastDate = DateTime.Now.Year + "-07-31";
          }
             else if (ss == "August")
          {
              firstDate = DateTime.Now.Year + "-08-01";
              lastDate = DateTime.Now.Year + "-08-31";
          }
             else if (ss == "September")
          {
              firstDate = DateTime.Now.Year + "-09-01";
              lastDate = DateTime.Now.Year + "-09-30";
          }
             else if (ss == "October")
          {
              firstDate = DateTime.Now.Year + "-10-01";
              lastDate = DateTime.Now.Year + "-10-31";
          }
             else if (ss == "November")
          {
              firstDate = DateTime.Now.Year + "-11-01";
              lastDate = DateTime.Now.Year + "-11-30";
          }

          else
          {
              firstDate = DateTime.Now.Year + "-12-01";
              lastDate = DateTime.Now.Year + "-12-31";
          }
        }

      private void logOutButton_Click(object sender, EventArgs e)
      {
          Login login = new Login();
          this.Hide();

          login.Closed += (s, args) => this.Close();
          login.Show();
      }


<<<<<<< HEAD
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
    }
}
