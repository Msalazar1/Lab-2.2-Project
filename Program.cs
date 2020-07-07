using System;

namespace TableofPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;
            while (keepgoing)
            {
                {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an integer:");

                string entry = Console.ReadLine();
                double i = double.Parse(entry);
                if (i <= 0)
                {
                    Console.WriteLine("Please enter a number greater than 0.");
                }

                double squared = i * i;
                double cubed = i * i * i;
                Console.WriteLine("Number\t\t\tSquared\t\t\tCubed");
                Console.WriteLine("======\t\t\t=======\t\t\t=====");
                Console.WriteLine($"{entry}\t\t\t{squared}\t\t\t{cubed}");

               
                    Console.WriteLine("Try again? yes/no");
                    string go = Console.ReadLine();

                    if (go == "no")
                    {
                        keepgoing = false;
                    }

                    else if (go != "yes")
                    {
                        Console.WriteLine("That is not the correct input. You must have meant no.");
                        keepgoing = false;
                    }

                }
                
            }
            Console.WriteLine("All set!");
        }
    }
}
  
             
