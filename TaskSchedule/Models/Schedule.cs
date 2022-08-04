using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSchedule.Models
{
    public class Schedule
    {

        public Schedule()
        {
            FirstDay = new List<EmployeeTask>();
            SecondDay = new List<EmployeeTask>();
            ThirdDay = new List<EmployeeTask>();
            FourthDay = new List<EmployeeTask>();
            FifthDay = new List<EmployeeTask>();
        }

        public List<EmployeeTask> FirstDay { get; set; }
        public List<EmployeeTask> SecondDay { get; set; }
        public List<EmployeeTask> ThirdDay { get; set; }
        public List<EmployeeTask> FourthDay { get; set; }
        public List<EmployeeTask> FifthDay { get; set; }

    }
}
