using System;
namespace BorsaMVC.View
{
    public class PasswordView
    {
        public void DisplayPassword(List<string> passwords)
        {
            Console.WriteLine("Generate passwords: ");
            Console.WriteLine(string.Join("", passwords));
        }
    }
}