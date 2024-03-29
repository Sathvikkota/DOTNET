using System;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public double GetTotalSalary(double bonus)
    {
        return Salary + bonus;
    }
}

public class Company
{
    private Employee[] employees;

    public Company(Employee[] employees)
    {
        this.employees = employees;
    }

    public void GiveEverybodyBonus(double companyBonus)
    {
        foreach (var employee in employees)
        {
            employee.Salary += companyBonus;
        }
    }

    public double TotalToPay()
    {
        double totalSalary = 0;
        foreach (var employee in employees)
        {
            totalSalary += employee.Salary;
        }
        return totalSalary;
    }

    public string NameMaxSalary()
    {
        double maxTotalSalary = double.MinValue;
        string maxSalaryEmployeeLastName = "";

        foreach (var employee in employees)
        {
            double totalSalary = employee.GetTotalSalary(0); // Calculate total salary with bonus
            if (totalSalary > maxTotalSalary)
            {
                maxTotalSalary = totalSalary;
                maxSalaryEmployeeLastName = employee.LastName;
            }
        }

        return maxSalaryEmployeeLastName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an array of employees
        Employee[] employees = {
            new Employee("John", "Doe", 50000),
            new Employee("Jane", "Smith", 60000),
            new Employee("Mike", "Johnson", 55000)
        };

        // Creating a company with the array of employees
        Company company = new Company(employees);

        // Giving bonus to everybody
        company.GiveEverybodyBonus(500);

        // Getting total salary to pay
        double totalSalary = company.TotalToPay();
        Console.WriteLine("Total Salary to Pay: " + totalSalary);

        // Getting the last name of the employee with maximum salary
        string maxSalaryEmployeeLastName = company.NameMaxSalary();
        Console.WriteLine("Last Name of Employee with Maximum Salary: " + maxSalaryEmployeeLastName);
    }
}





















/*using System;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public double GetTotalSalary(double bonus)
    {
        return Salary + bonus;
    }
}

public class Company
{
    private Employee[] employees;

    public Company(Employee[] employees)
    {
        this.employees = employees;
    }

    public void GiveEverybodyBonus(double companyBonus)
    {
        foreach (var employee in employees)
        {
            employee.Salary += companyBonus;
        }
    }

    public double TotalToPay()
    {
        double totalSalary = 0;
        foreach (var employee in employees)
        {
            totalSalary += employee.Salary;
        }
        return totalSalary;
    }

    public string NameMaxSalary()
    {
        double maxSalary = double.MinValue;
        string maxSalaryEmployeeLastName = "";

        foreach (var employee in employees)
        {
            double totalSalary = employee.Salary;
            if (totalSalary > maxSalary)
            {
                maxSalary = totalSalary;
                maxSalaryEmployeeLastName = employee.LastName;
            }
        }

        return maxSalaryEmployeeLastName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an array of employees
        Employee[] employees = {
            new Employee("John", "Doe", 50000),
            new Employee("Jane", "Smith", 60000),
            new Employee("Mike", "Johnson", 55000)
        };

        // Creating a company with the array of employees
        Company company = new Company(employees);

        // Giving bonus to everybody
        company.GiveEverybodyBonus(500);

        // Getting total salary to pay
        double totalSalary = company.TotalToPay();
        Console.WriteLine("Total Salary to Pay: " + totalSalary);

        // Getting the last name of the employee with maximum salary
        string maxSalaryEmployeeLastName = company.NameMaxSalary();
        Console.WriteLine("Last Name of Employee with Maximum Salary: " + maxSalaryEmployeeLastName);
    }
}*/
