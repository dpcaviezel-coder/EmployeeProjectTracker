using System;

namespace EmployeeProjectTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            AssignmentManager assignmentManager = new AssignmentManager();

            Employee employee1 = new Employee("Haisley", 101, "C#101");
            Employee employee2 = new Employee("Reinan", 102, "C#500");
            Employee employee3 = new Employee("Eisley", 103, "CSharp");

            assignmentManager.AssignEmployeeToProject(employee1, new Project("Website Redesign", 2500));
            assignmentManager.AssignEmployeeToProject(employee2, new Project("Inventory System", 1700));
            assignmentManager.AssignEmployeeToProject(employee3, new Project("Mobile App", 2500));

            assignmentManager.DisplayAssignments();
        }
    }
}