namespace EmployeeProjectTracker
{
    public class Project
    {
        public string ProjectName { get; }
        public double Budget { get; }

        public Project(string projectName, double budget)
        {
            ProjectName = projectName;
            Budget = budget;
        }

        public void DisplayProjectInfo()
        {
            Console.WriteLine("\n============ Project Info ============");
            Console.WriteLine($"Name: {ProjectName}");
            Console.WriteLine($"Budget: ${Budget}");
            Console.WriteLine("========================================\n");
        }
    }
}