using System;

namespace helloworldcs
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize some default values for the greeting
            string greeting = null;
            string volume = null;

            // capture the user's name
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            if(name == "" || name == null)
            {
                Console.WriteLine("You entered BLANK for your name. That's OK. I'll just call you 'User'!");
            }

            // select the custom greeting
            Console.WriteLine("Please select a greeting from the following options:");
            Console.WriteLine("1. Passing on the street");
            Console.WriteLine("2. Friendly");
            Console.WriteLine("3. Aggressive");

            string selectedGreeting = Console.ReadLine();

            switch(selectedGreeting)
            {
                case "1":
                    greeting = "Oh hey";
                    break;
                case "2":
                    greeting = "Good day to you";
                    break;
                case "3":
                    greeting = "Get out of my whole face right now";
                    break;
                default:
                greeting = null;
                break;
            }

            // optionally choose loud, quiet, or no special formatting
            Console.WriteLine("Select a loud, quiet, or normal greeting: ");
            Console.WriteLine("1. LOUD");
            Console.WriteLine("2. quiet");
            Console.WriteLine("3. Normal");
            string greetingStyle = Console.ReadLine();

            switch(greetingStyle)
            {
                case "1":
                    volume = "loud";
                    break;
                case "2":
                    volume = "quiet";
                    break;
                default: 
                    volume = null;
                    break;
            }
            // create the final greeting string
            string CreateGreeting(string g = "Hello", string n = "User")
            {
                string finalGreeting = $"{g} {n}";

                if (volume == "loud")
                {
                    return finalGreeting.ToUpper();
                } 
                else if (volume == "quiet") 
                {
                    return finalGreeting.ToLower();
                }
                else
                {
                    return finalGreeting;
                }
            }
            Console.WriteLine(CreateGreeting(greeting, name));
        }
    }
}
