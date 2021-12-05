using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_TasksAttributes.Interfaces;
using Nikita_TasksAttributes.Workers;
using System.Reflection;

namespace Nikita_TasksAttributes.Elements
{
    class Company
    {
        public static int Income { get; private set; } = 15000000; 
        public static int AmountOfWorkers { get; private set; } = 211;
        public static int AmountOfOrders { get; private set; } = 5;

        private static bool GetAccess(IWorker worker, AccessLevel accessLevel) => (worker.GetType().GetCustomAttribute(typeof(AccessLevelAttribute)) as AccessLevelAttribute).Level >= accessLevel;

        public static void ShowIncome(IWorker worker) => Console.WriteLine(GetAccess(worker, AccessLevel.Manager) ? $"Привет, {worker.Name}, доход компании => {Company.Income} шекелей" : "Отказано в доступе");

        public static void ShowWorkers(IWorker worker) => Console.WriteLine(GetAccess(worker, AccessLevel.Common) ? $"Привет, {worker.Name}, в компании работают{Company.AmountOfWorkers} работников" : "Отказано в доступе");

        public static void ShowOrders(IWorker worker) => Console.WriteLine(GetAccess(worker, AccessLevel.Director) ? $"Привет, {worker.Name} заказов в работе => {Company.AmountOfOrders}" : "Отказано в доступе");
    }
}
