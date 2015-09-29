using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceAPP.DAL;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using AttendanceAPP.Model;
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
using AttendanceAPP.Model;
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c

namespace AttendanceAPP.BLL
{
    class StuffManager
    {
        StuffGateway aStuffGateway=new StuffGateway();
        internal List<Model.Stuff> GetAllStuff()
        {
            return aStuffGateway.GetAllStuff();
        }

        public void AttendanceSubmit(DateTime aDateTime, int id, out string message)
        {
            if (aStuffGateway.CheckAttendance(aDateTime,id)==true)
            {
                message = "You cannot submit attendance more than one times a day";
            }
            else
            {
                aStuffGateway.GetAttendance(aDateTime, id);
                message = "Attendance Submitted";
            }
        }


<<<<<<< HEAD
<<<<<<< HEAD
        public List<string> GetAllAttendance(int myId)
        {
            return aStuffGateway.GetAllAttendance(myId);
=======
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
       

        public List<string> GetStuffAttendanceList(string name, string firstDate,string lastDate)
        {
            List<Stuff> stuffList = aStuffGateway.GetAllStuff();
            int id = 0;
            foreach (Stuff stuff in stuffList)
            {
                if (stuff.Name == name)
                {
                    id = stuff.Id;
                    break;
                }
            }
            List<string> dateList = aStuffGateway.GetAttendanceList(id, firstDate, lastDate);
            return dateList;


        }


       

        internal void submitAttendance(int p, string date)
        {
            aStuffGateway.SubmitAttendance(p,date);
        }

        public int getCurrentDateId(int id, string date)
        {
            return aStuffGateway.GetCurrentId(id,date);
        }

        public void SubmitLogin(int id, DateTime time, string remark)
        {
            aStuffGateway.SubmitLogin(id,time,remark);
<<<<<<< HEAD
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
=======
>>>>>>> a640082b294a1601a6267f275da3d884eee2ab5c
        }
    }
}
