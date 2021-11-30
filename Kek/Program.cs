using System;

namespace Kek
{
    class Program
    {
        static void Main(string[] args)
        {
            //login-admin
            //password-pass1234
            //declare variables
            //assign value - initialize a variable
            string login = "admin";
            string password = "pass1234";
            string userName, userPassword;
            int tries = 0;
            while(tries!=3)
            {
                Console.WriteLine("Enter ur login: ");
                userName = Console.ReadLine();
                Console.WriteLine("Enter ur password: ");
                userPassword = Console.ReadLine();
                if (login != userName || password != userPassword)
                {
                    Console.WriteLine("OOooooopsss,Something went wrong");
                    tries++;
                    Console.WriteLine($"Login failed. Attempts left {tries}");
                }
                else
                {
                    Console.WriteLine("Welcome");
                    break;
                }
            }
               
                   



        }
    }
}
