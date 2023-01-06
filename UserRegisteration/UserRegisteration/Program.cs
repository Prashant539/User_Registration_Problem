using System;
using UserRegisteration;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Validating using Regular Expression!");
            RegexSample regexSample = new RegexSample();
            regexSample.Validating();
        }
    }
}
