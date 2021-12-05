using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nikita_TasksAttributes.Interfaces;
using Nikita_TasksAttributes.Elements;

namespace Nikita_TasksAttributes.Workers
{
    [AccessLevel(AccessLevel.Common)]
    class Programmer : IWorker
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int WorkExperience { get; private set; }

        public Programmer(string name, string surname, int workExperience)
        {
            Name = name;
            Surname = surname;
            WorkExperience = workExperience;
        }
    }
}
