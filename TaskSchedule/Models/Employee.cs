using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskSchedule.Models
{
    public class Employee
    {
        public Employee()
        {
            AssignedTasks = new List<Task>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Task> AssignedTasks { get; set; }
    }
}
