namespace OOPs
{
// Interfaces
    public interface IPersonService
    {
        int CalculateAge();
        decimal CalculateSalary();
    }

    public interface IStudentService : IPersonService
    {
        double CalculateGpa();
    }

    public interface IInstructorService : IPersonService
    {
        decimal CalculateBonusSalary();
    }

// Abstract Person Class
    public abstract class Person : IPersonService
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private decimal _salary;

        public Person(string firstName, string lastName, DateTime birthDate, decimal salary)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._birthDate = birthDate;
            this._salary = salary;
        }

        public int CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - _birthDate.Year;
            if (_birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        public virtual decimal CalculateSalary()
        {
            return _salary;
        }

        public string FullName => $"{_firstName} {_lastName}";
    }

// Student Class
    public class Student : Person, IStudentService
    {
        private List<char> _grades;

        public Student(string firstName, string lastName, DateTime birthDate, decimal salary)
            : base(firstName, lastName, birthDate, salary)
        {
            _grades = new List<char>();
        }

        public void AddGrade(char grade)
        {
            if ("ABCDF".Contains(grade))
            {
                _grades.Add(grade);
            }
        }

        public double CalculateGpa()
        {
            if (_grades.Count == 0) return 0.0;

            double totalPoints = _grades.Sum(grade =>
            {
                return grade switch
                {
                    'A' => 4.0,
                    'B' => 3.0,
                    'C' => 2.0,
                    'D' => 1.0,
                    'F' => 0.0,
                    _ => 0.0
                };
            });

            return totalPoints / _grades.Count;
        }
    }

// Instructor Class
    public class Instructor : Person, IInstructorService
    {
        private DateTime _joinDate;

        public Instructor(string firstName, string lastName, DateTime birthDate, decimal salary, DateTime joinDate)
            : base(firstName, lastName, birthDate, salary)
        {
            this._joinDate = joinDate;
        }

        public decimal CalculateBonusSalary()
        {
            int yearsOfExperience = (DateTime.Now.Year - _joinDate.Year);
            decimal bonus = 1000 * yearsOfExperience;
            return CalculateSalary() + bonus;
        }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary();
        }
    }

// Main Program
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("John", "Doe", new DateTime(2000, 5, 15), 0);
            var instructor = new Instructor("Dr.", "Smith", new DateTime(1975, 2, 20), 60000, new DateTime(2010, 9, 1));

            student.AddGrade('A');
            student.AddGrade('B');

            Console.WriteLine($"Student: {student.FullName}");
            Console.WriteLine($"Age: {student.CalculateAge()}");
            Console.WriteLine($"GPA: {student.CalculateGpa():F2}");
            Console.WriteLine($"Instructor: {instructor.FullName}");
            Console.WriteLine($"Age: {instructor.CalculateAge()}");
            Console.WriteLine($"Salary: {instructor.CalculateSalary():C}");
            Console.WriteLine($"Bonus Salary: {instructor.CalculateBonusSalary():C}");
        }
    }
}