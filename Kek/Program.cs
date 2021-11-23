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
            Console.WriteLine("Enter ur login: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter ur password: ");
            userPassword = Console.ReadLine();
            if(login==userName && password==userPassword)
                Console.WriteLine("Welcome!");
            else
                Console.WriteLine("OOooooopsss,Something went wrong");

        }
    }
}
