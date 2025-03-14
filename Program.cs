namespace Methods_Mangum_Stephen
{
    internal class Program
    {
        // Method that multiples two integers
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Method that welcomes the user
        static void WelcomeUser(string name)
        {
            Console.WriteLine($"Hello, {name}! It is nice to meet you!");

            //Checks if Houston is the one inputting his name.
            if (name == "Morgan" || name == "Houston" || name == "Morgan Houston" || name == "M.H" || name == "MMO" || name == "Mr. Houston" || name == "That one guy with the beard")
            {
                Console.WriteLine("Wait...");
                Console.WriteLine("That sounds...familiar. Wait a gosh diddly darn second! Begone, beard man!! You will not 'FunGame.bat' my code, not this time!!!");
                Environment.Exit(0);
            }
        }

        // Method that says goodbye to the user who isn't Mr. Houston
        static void SayFarewell()
        {
            Console.WriteLine("Have a fantastic day!");
        }

        static void Main()
        {
            Console.WriteLine("Enter two numbers (seperately): ");
            // Multiplies two numbers and prints the results of their product
            int result = Multiply(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Multiplication Result: " + result);

            // Ask the user for their name
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            // Welcomes the user after reveiving their name
            WelcomeUser(userName);

            // Says goodbye to the user
            SayFarewell();

            
        }
    }
}