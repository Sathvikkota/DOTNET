using lab11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAddEmployees_Click(object sender, EventArgs e)
        {
            
            Employee employee1 = new Employee("John", 3000);
            Employee employee2 = new Employee("Alice", 4000);
            Employee combinedEmployee = employee1 + employee2;
            labelResult.Text = $"Combined Salary: {combinedEmployee.Salary}";
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}


