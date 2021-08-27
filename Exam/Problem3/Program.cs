using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex rlogin = new Regex(@"(U\$)([A-Z][a-z]{2,})\1(P@\$)([A-Za-z]{5,}[0-9]+)\3");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = rlogin.Match(input);
                if (match.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups["2"].Value}, Password: {match.Groups["4"].Value}");
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
