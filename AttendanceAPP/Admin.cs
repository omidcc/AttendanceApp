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
           
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            monthListComboBox.SelectedIndex = 0;
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
              
            }
            nameComboBox.SelectedIndex = 0;
            
        }

        public void LoadComboZ()
        {
            
        }
        List<string>myAttendanceList=new List<string>();
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
            
        }
        
      

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
    }
}
