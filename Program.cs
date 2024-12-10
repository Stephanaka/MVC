using System;
using BorsaMVC.Controller;
namespace BorsaMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordControl controller = new PasswordControl();
            controller.Run();
        }
    }
}