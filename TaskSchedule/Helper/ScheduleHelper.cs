using System;
using System.Collections.Generic;
using System.Linq;
using TaskSchedule.Models;

namespace TaskSchedule.Helper
{
    public static class ScheduleHelper
    {
        private static List<Employee> Employees = new List<Employee>()
            {
                new Employee() { Name = "Ferman", Surname = "AKGÜL"},
                new Employee() { Name = "Harun", Surname = "TEKİN"},
                new Employee() { Name = "Kaan", Surname = "TANGÖZE"},
                new Employee() { Name = "Erhan", Surname = "GÜLERYÜZ"},
                new Employee() { Name = "Tuna", Surname = "VELİBAŞOĞLU"},
                new Employee() { Name = "Gökhan", Surname = "ÖZOĞUZ"}
            };

        private static List<Task> tasks = new List<Task>()
            {
                new Task() {Name = "Görev 1", Score = 8},
                new Task() {Name = "Görev 2", Score = 11},
                new Task() {Name = "Görev 3", Score = 15},
                new Task() {Name = "Görev 4", Score = 19},
                new Task() {Name = "Görev 5", Score = 20},
                new Task() {Name = "Görev 6", Score = 24},
            };

        private static List<EmployeeTask> EmployeeTasks = new List<EmployeeTask>();

        public static List<EmployeeTask> AssignToEmployee()
        {
            if (EmployeeTasks.Any())
            {
                EmployeeTasks.ToList().ForEach(x => EmployeeTasks.Remove(x));
                foreach (var employee in Employees)
                    employee.AssignedTasks.ToList().ForEach(x => employee.AssignedTasks.Remove(x));
            }
             

            foreach (var employee in Employees.OrderBy(x => Guid.NewGuid()).ToList()) //Her çalışana sırayla 5 günlük görev atanacak
            {
                for (int i = 1; i <= 5; i++)
                    AssignDay(employee, i);
            }

            return EmployeeTasks;
        }

        private static void ChangeTask(Employee employee, Task task, int day)
        {
            if (employee.AssignedTasks.Where(x => x == task).Count() == 2) //Bir görevi bir çalışana 2'den fazla kez vermek istemiyorum.
            {
                var otherEmployeeTaskList = EmployeeTasks.Where(x => x.Day == day && x.Employee != employee);
                var employeeTask = otherEmployeeTaskList.ElementAt(new Random().Next(0, otherEmployeeTaskList.Count() - 1));
                var tempEmployee = employeeTask.Employee;

                employeeTask.Employee = employee;
                EmployeeTasks.Add(new EmployeeTask() { Employee = tempEmployee, Task = task, Day = day });

                tempEmployee.AssignedTasks.Remove(employeeTask.Task);
                tempEmployee.AssignedTasks.Add(task);
                employee.AssignedTasks.Remove(task);
                employee.AssignedTasks.Add(employeeTask.Task);
            }

            else
            {
                EmployeeTasks.Add(new EmployeeTask() { Employee = employee, Task = task, Day = day });
                employee.AssignedTasks.Add(task);
            }
        }

        private static void AssignDay(Employee employee, int day)
        {
            var unassignedTasks = tasks.Except(EmployeeTasks.Where(x => x.Day == day).Select(x => x.Task)); //O gün diğer çalışanlara atanmamış görevler
            var suitableTasks = unassignedTasks.Except(employee.AssignedTasks); //Atama yapacağım görevi seçerken ilk tercihim, görevin bu çalışana daha önce atanmamış olması. 

            if (!suitableTasks.Any()) //Eğer bu çalışana atanmamış uygun görev bulamıyorsam, başka bir çalışanın atanmış görevi ile değişiklik yapacağım.
                ChangeTask(employee, unassignedTasks.ElementAt(new Random().Next(0, unassignedTasks.Count() - 1)), day);

            else
            {
                var task = suitableTasks.ElementAt(new Random().Next(0, suitableTasks.Count() - 1));
                EmployeeTasks.Add(new EmployeeTask() { Employee = employee, Task = task, Day = day });
                employee.AssignedTasks.Add(task);
            }
        }
    }
}
