using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nikita_TasksAttributes.Elements
{
    class User
    {
        public static void Registration()
        {
            var loginReg = new Regex("^[a-zA-Z]+$");
            var passwordReg = new Regex("^[a-zA-Z0-9]+$");

            Console.WriteLine("Введите логин состоящий только из символов латинского алфавита: ");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль состоящий только из символов латинского алфавита и цифр:");
            string password = Console.ReadLine();

            while (!loginReg.IsMatch(login) || !passwordReg.IsMatch(password))
            {
                if (!loginReg.IsMatch(login))
                {
                    Console.WriteLine("Логин не соответсвует требованиям \nНовый логин:");
                    login = Console.ReadLine();
                }

                if (!passwordReg.IsMatch(password))
                {
                    Console.WriteLine("Пароль не соотвествует требованиям \nНовый пароль:");
                    password = Console.ReadLine();
                }
            }

            Console.WriteLine("Регистрация прошла успешно!");
            Console.ReadKey();
        }
    }
}
