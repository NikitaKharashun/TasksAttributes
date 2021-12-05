using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_TasksAttributes.Elements;
using Nikita_TasksAttributes.Workers;

namespace Nikita_TasksAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            User.Registration();

            var programmer = new Programmer("Steve", "Wazowski", 5);
            Company.ShowWorkers(programmer);
            Company.ShowOrders(programmer);


            var director = new Director("Walter", "White", 14);
            Company.ShowIncome(director);
            Company.ShowOrders(director);


            Console.ReadKey();
        }
    }
}
