using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegisteration
{
    public class RegexSample
    {
        string pattern = "^[A-Za-z]{2,}$";
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validating the first name");
            ValidatingFirstName();
            ValidatingLastName();
            Console.WriteLine("Validating Email Address");
            ValidatingEmailId();
            Console.WriteLine("Validating Phone Number");
            ValidatingPhoneNum();

        }
        public void ValidatingFirstName()
        {
            Regex Regex = new Regex(pattern);
            Console.WriteLine("Enter the first name:");
            string input = Console.ReadLine();
            bool res = Regex.IsMatch(input);
            if (res)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
        public void ValidatingLastName()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter the last name : ");
            string input1 = Console.ReadLine();
            bool res1 = regex.IsMatch(input1);
            if (res1)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatingEmailId()
        {
            string emailPattern = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            Regex regex = new Regex(emailPattern);
            Console.WriteLine("Enter email Id");
            string emails = Console.ReadLine();
            bool res = regex.IsMatch(emails);
            if (res)
            {
                Console.WriteLine("valid email address");
            }
            else
            {
                Console.WriteLine("Please enter a Valid Email!");
            }
        }
        public void ValidatingPhoneNum()
        {
            string phoneNumPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);
            Console.WriteLine("Enter valid Phone Number");
            string phoneNumber = Console.ReadLine();
            bool res = regex.IsMatch(phoneNumber);
            if (res)
            {
                Console.WriteLine("valid email address");
            }
            else
            {
                Console.WriteLine("Please enter a Valid Email!");
            }
        }
    }
}
