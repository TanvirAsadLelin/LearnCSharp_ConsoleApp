using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp_ConsoleApp
{
    internal class Abstraction
    {

        public void abstractionMethod()
        {
            Console.WriteLine("Welcome to Abstraction part. \n");

            Employee employeeObj = new Employee(1,"lelin",29000);
            employeeObj.ShowSalary();

            Console.WriteLine("The end of Abstraction part. \n");
        }
    }

    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1; //10%
        double netSalary;

        public Employee (int Eid, string Ename, double Egrosspay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = Egrosspay;
        }

        void CalculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Employee id is: {0}" + this.EmpId);
                Console.WriteLine("Employee name is: {0}" + this.EmpName);
                Console.WriteLine("Your salary is : {0} " + netSalary);

            }
            else
            {
                Console.WriteLine("Employee id is: {0}" + this.EmpId);
                Console.WriteLine("Employee name is: {0}" + this.EmpName);
                Console.WriteLine("Your salary is : {0} " + GrossPay);

            }
        }

        public void ShowSalary()
        {
            this.CalculateSalary();
        }
    }
}
