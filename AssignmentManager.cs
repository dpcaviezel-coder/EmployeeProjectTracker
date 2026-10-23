namespace EmployeeProjectTracker
{
    public class AssignmentManager
        {
        public List<Employee> employees = new();
        public List<Project> projects = new();
        public List<Assignment> assignments = new();


        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void AddProject(Project project)
        {
            projects.Add(project);
        }

        public void AssignEmployeeToProject(
            Employee employee,
            Project project)
        {
            employees.Add(employee);

            projects.Add(project);

            assignments.Add(
                new Assignment(employee, project));
        }

        public void DisplayAssignments()
        { 

            Console.WriteLine("\n ============ Project Assigments ============");

            foreach (Assignment assignment in assignments)
            {
                Console.WriteLine($"{assignment.Employee.Name} -> {assignment.Project.ProjectName}");
            }
        }
    }
}