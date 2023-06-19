namespace ConsoleAppDz_17
{
    internal class Program
    {
        static void Main()
        {

            Firma[] firms = new Firma[]
            {
                new Firma
                {
                    Title = "Clothes company",
                    Date = "2022-01-01",
                    Profile = "Clothes",
                    PIB = "Tim Billy",
                    CountEmployers = 66,
                    Address = "100 Main Street, Amsterdam"
                },
                new Firma
                {
                    Title = "Make-up company",
                    Date = "2021-10-10",
                    Profile = "Make-up",
                    PIB = "Bill Front",
                    CountEmployers = 100000,
                    Address = "101 Main Street, New York"
                },
                new Firma
                {
                    Title = "Food  company",
                    Date = "2017-08-10",
                    Profile = "Food",
                    PIB = "Ann Wednny",
                    CountEmployers = 2000,
                    Address = "202 Main Street, Odesa"
                }
            };

            Console.WriteLine("Info:");
            foreach (var a in firms)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var firmsWithFoodInTitle = firms.Where(firma => firma.Title.Contains("Food")).ToList();
            Console.WriteLine("Firms with 'Food' in the title:");
            foreach (var a in firmsWithFoodInTitle)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var MakeFirms = firms.Where(firma => firma.Profile == "Make-up").ToList();
            Console.WriteLine("Make-up firms:");
            foreach (var a in MakeFirms)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var mOrFoodFirms = firms.Where(firma => firma.Profile == "Clothes" || firma.Profile == "Food").ToList();
            Console.WriteLine("Make-up or Food firms:");
            foreach (var a in mOrFoodFirms)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var firmsWithMoreThan100Employees = firms.Where(firma => firma.CountEmployers > 100).ToList();
            Console.WriteLine("Firms with more than 100 employees:");
            foreach (var a in firmsWithMoreThan100Employees)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var firmsWith100to300Employees = firms.Where(firma => firma.CountEmployers >= 100 && firma.CountEmployers <= 300).ToList();
            Console.WriteLine("Firms with 100 to 300 employees:");
            foreach (var a in firmsWith100to300Employees)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var firmsInOdesa = firms.Where(firma => firma.Address.Contains("Odesa")).ToList();
            Console.WriteLine("Firms located in Odesa:");
            foreach (var a in firmsInOdesa)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var firmsWithDirectorLastNameFront = firms.Where(firma => firma.PIB.Split(' ')[1] == "Front").ToList();
            Console.WriteLine("Firms with director's last name 'Front':");
            foreach (var a in firmsWithDirectorLastNameFront)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var firmsFoundedMoreThanTwoYearsAgo = firms.Where(firma => DateTime.Parse(firma.Date) < DateTime.Now.AddYears(-2)).ToList();
            Console.WriteLine("Firms founded more than two years ago:");
            foreach (var a in firmsFoundedMoreThanTwoYearsAgo)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var firmsFounded123DaysAgo = firms.Where(firma => DateTime.Parse(firma.Date) == DateTime.Now.AddDays(-123).Date).ToList();
            Console.WriteLine("Firms founded 123 days ago:");
            foreach (var a in firmsFounded123DaysAgo)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var firmsBlackAndWhite = firms.Where(firma => firma.PIB.Split(' ')[1] == "Billy" && firma.Title.Contains("Clothes")).ToList();
            Console.WriteLine("Firms with director's last name 'Billy' and 'Clothes' in the title:");
            foreach (var a in firmsBlackAndWhite)
            {
                Console.WriteLine($"Title: {a.Title}");
                Console.WriteLine($"Date: {a.Date}");
                Console.WriteLine($"Profile: {a.Profile}");
                Console.WriteLine($"Director: {a.PIB}");
                Console.WriteLine($"Number of employees: {a.CountEmployers}");
                Console.WriteLine($"Address: {a.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();






            firms[0].Employees.Add(new Employee { FullName = "Kate Mudre", Position = "Director", PhoneNumber = "23658998", Email = "Kate@gmail.com", Salary = 7000 });
            firms[0].Employees.Add(new Employee { FullName = "Fill May", Position = "Developer", PhoneNumber = "12345678", Email = "Fill@gmail.com", Salary = 10000 });

            var employeesOfFirma = firms[0].Employees;
            Console.WriteLine("Employees of a firm:");
            foreach (var employee in employeesOfFirma)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.Write("Enter minimal salary: ");
            int minimumSalary = int.Parse(Console.ReadLine());
            var employeesWithHigherSalary = firms[0].Employees.Where(employee => employee.Salary > minimumSalary).ToList();
            Console.WriteLine("Employees of a specific firm with a salary higher than a certain amount:");
            foreach (var employee in employeesWithHigherSalary)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var employeesWithDirectorPosition = firms.SelectMany(firma => firma.Employees.Where(employee => employee.Position == "Director")).ToList();
            Console.WriteLine("Employees in all firms with the position 'Director':");
            foreach (var employee in employeesWithDirectorPosition)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var employeesWithPhoneNumberStartingWith23 = firms.SelectMany(firma => firma.Employees.Where(employee => employee.PhoneNumber.StartsWith("23"))).ToList();
            Console.WriteLine("Employees with a phone number starting with '23':");
            foreach (var employee in employeesWithPhoneNumberStartingWith23)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var employeesWithEmailStartingWithF = firms.SelectMany(firma => firma.Employees.Where(employee => employee.Email.StartsWith("F"))).ToList();
            Console.WriteLine("Employees with an email starting with 'F':");
            foreach (var employee in employeesWithEmailStartingWithF)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();


            var employeesWithNameFill = firms.SelectMany(firma => firma.Employees.Where(employee => employee.FullName.StartsWith("Fill"))).ToList();
            Console.WriteLine("Employees with the name 'Fill':");
            foreach (var employee in employeesWithNameFill)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
        }
    }
    class Firma
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Profile { get; set; }
        public string PIB { get; set; }
        public int CountEmployers { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }

        public Firma()
        {
            Employees = new List<Employee>();
        }
    }

    class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
    }
}