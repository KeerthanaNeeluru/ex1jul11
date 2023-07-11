using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace july11ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            DateTime doj;
            Console.WriteLine("Enter employee ID");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            name = Console.ReadLine();
            Console.WriteLine("Enter employee gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee date of joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID\tEmployeename\tEmployee Gender\tEmployee Salary\tDOJ");
            Console.WriteLine("=================================================================================================");
            Console.WriteLine(id + "\t" + name + "\t\t" + gender + "\t\t" +
                salary +"\t"+doj);
            Console.ReadKey();

        }
    }
}
