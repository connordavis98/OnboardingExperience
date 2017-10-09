using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Hello! Thank you for using our Onboard Application!");
            user.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine("Awesome! Your first name is " + user.FirstName);

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine("Awesome! Your full name is " + user.FirstName + " " + user.LastName);

            user.IsAccountOwner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine("Awesome! You are account owner: " + user.IsAccountOwner);

            user.PinNumber = AskPinNumber("What is your 4 digit PIN?", 4);
            Console.WriteLine("Awesome! You entered: " + user.PinNumber);

            Console.ReadLine();

        }

        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();

        }
        static bool AskBoolQuestion(string question)
        {
            var isAccountOwner = false;

            while (!isAccountOwner)
            {
                var response = AskQuestion(question + "(y/n)");

                if (response == "y")
                {
                    isAccountOwner = true;
                }
                else
                {
                    Console.Write("You must be the account owner to proceed. ");
                }
            }

            return isAccountOwner;
        }

        static string AskPinNumber(string question, int length)
        {
            string numberString = null;
            
            while (numberString == null)
            {
                var response = AskQuestion(question);

                if (response.Length == length && Int32.TryParse(response, out int possiblereturn))
                {
                    numberString = response;
                }
            }

            return numberString;
        }
    }
}
