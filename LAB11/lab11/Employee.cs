using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public static Employee operator +(Employee emp1, Employee emp2)
        {
            return new Employee("Combined", emp1.Salary + emp2.Salary);
        }
    }

}
