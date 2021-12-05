using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Nikita_TasksAttributes.Elements;
using Nikita_TasksAttributes.Interfaces;

namespace Nikita_TasksAttributes.Elements
{

    public enum AccessLevel
    {
        Common,
        Manager,
        Director
    }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class AccessLevelAttribute : Attribute
    {
        public readonly AccessLevel AccessLevel;

        public AccessLevelAttribute(AccessLevel accessLevel) => AccessLevel = accessLevel;
    }


}
