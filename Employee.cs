namespace EmployeeProjectTracker
{
    public class Employee
    {
        public string Name { get; }
        public int EmployeeId { get; }
        public string Department { get; }

        public Employee(string name, int employeeId, string department)
        {
            Name = name;
            EmployeeId = employeeId;
            Department = department;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("\n============ Employee Info ============");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {EmployeeId}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine("=========================================\n");
        }
    }
}