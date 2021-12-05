using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_TasksAttributes.Interfaces
{
    interface IWorker
    {
        string Name { get; }
        string Surname { get; }
        int WorkExperience { get; }
    }
}
