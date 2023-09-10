namespace TaskTakipSistemi.Models
{
    public static class Repository
    {
        private static List<Employee> applications = new();
        public static IEnumerable<Employee> Applications => applications;

        public static void Add(Employee employee)
        {
            applications.Add(employee);
        }
    }
}