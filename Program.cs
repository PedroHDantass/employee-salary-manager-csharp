using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
namespace ListEX
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i);

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));

                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int idIncrease = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Employee increase = employees.Find(e => e.Id == idIncrease);

            if (increase != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                increase.IncreaseSalary(percentage);

                
                ExibirFuncionarios(employees);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
                ExibirFuncionarios(employees);
            }

        }

        static void ExibirFuncionarios(List<Employee> employee)
        {
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee imp in employee)
            {

                Console.WriteLine($"Id: {imp.Id},  Name: {imp.Name}, Salary: {imp.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}

