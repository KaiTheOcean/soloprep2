using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade percentage? ");
            // int percentage = Convert.ToInt32(Console.ReadLine());
            string userInput = Console.ReadLine();
            int percentage = int.Parse(userInput);
            if (percentage > 70)
            {
                Console.WriteLine("Congrats, you have passed the course!");
                if (percentage >= 90)
                {
                    Console.WriteLine("A");
                }
                else if (percentage >= 80)
                {
                    Console.WriteLine("B");
                }
            }
            else{
                Console.WriteLine("You did not pass the course.");
                if (percentage >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (percentage >= 60)
                {
                    Console.WriteLine("D");
                }
                else if (percentage < 60)
                {
                    Console.WriteLine("F");
                }
            }
        }
    }
}
