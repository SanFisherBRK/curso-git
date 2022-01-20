using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> list = new List<Funcionario>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Emplyoee #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase ");
            int idSearch = int.Parse(Console.ReadLine());   

            Funcionario fun = list.Find(X => X.Id == idSearch);

            if(fun != null)
            {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine());
                fun.Aumento(porcentagem);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Id não existe");
            }

            Console.WriteLine("Updated list of employees:");

            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
