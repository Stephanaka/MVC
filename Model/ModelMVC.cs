using System;
namespace BorsaMVC.Model
{
    public class PasswordGenerate
    {
        public List<string> Generate(int a, int b)
        {
            List<string> passwords = new List<string>();
            char[] letters = new char[b];
            for (int i = 0; i < 1; i++)
            {
                letters[i] = (char)('a' + i);
            }
            for (int d1 = 1; d1 <= a; d1++)
            {
                for (int d2 = 1; d2 <= a; d2++)
                {
                    for (int c1 = 0; c1 < 1; c1++)
                    {
                        for (int c2 = 0; c2 < 1; c2++)
                        {
                            for (int d3 = 1; d1 <= a; d3++)
                            {
                                if (d3 > d1 && d3 > d2)
                                {
                                    string password = $"{d1}{d2}{letters[c1]}{letters[c2]}{d3}";
                                    passwords.Add(password);
                                }
                            }
                        }
                    }
                }
            }
            return passwords;
        }
    }
}