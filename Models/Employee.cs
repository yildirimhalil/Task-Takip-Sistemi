
namespace TaskTakipSistemi.Models
{
    public class Employee
    {
        public String? FirstName { get; set; } = String.Empty;
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public DateTime ApplyAt { get; set; }  
        public List<TaskItem> Tasks { get; set; }

        public Employee()
        {
            ApplyAt = DateTime.Now;
        }
    }

}