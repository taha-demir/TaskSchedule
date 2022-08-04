using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSchedule.Models
{
    public class EmployeeTask
    {
        public Employee Employee { get; set; }
        public Task Task { get; set; }
        public int Day { get; set; }

        public override string ToString()
        {
            return $"{Day} - {Employee.Name} - {Task.Name}";
        }
    }
}
