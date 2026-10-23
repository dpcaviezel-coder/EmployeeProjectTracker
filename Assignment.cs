using System.Runtime.CompilerServices;

namespace EmployeeProjectTracker
{
    public class Assignment
    {
            public Employee Employee { get; set; }
            public Project Project { get; set; }

        public Assignment(Employee employee, Project project)
        {
            Employee = employee;
            Project = project;
        }
    }
}