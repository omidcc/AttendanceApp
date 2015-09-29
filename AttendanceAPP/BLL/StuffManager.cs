using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceAPP.DAL;

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


        public List<string> GetAllAttendance(int myId)
        {
            return aStuffGateway.GetAllAttendance(myId);
        }
    }
}
