using System;
using BorsaMVC.Model;
using BorsaMVC.View;

namespace BorsaMVC.Controller
{
    public class PasswordControl
    {
        private PasswordGenerate passwordGenerate;
        private PasswordView passwordView;
        public PasswordControl()
        {
            passwordGenerate = new PasswordGenerate();
            passwordView = new PasswordView();
        }
        public void Run()
        {
            Console.WriteLine("Enter a(1 - 9): ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b(1 - 9): ");
            int b = int.Parse(Console.ReadLine());
            if (a >= 1 && a <= 9 && b >= 1 && b <= 9)
            {
                var passwords = passwordGenerate.Generate(a, 1);
                passwordView.DisplayPassword(passwords);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

        }
    }
}
