using System;

namespace NTCG25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many days you've been alive?: ");

            string daysAlive = Console.ReadLine();
            int num2 = Int32.Parse(daysAlive);

            
            Console.WriteLine("What is your level?");

            string level = Console.ReadLine();
            int num3 = Int32.Parse(level);

            float lastnum = 1.2f;
            
            float Gamestage = num2 + num3 * lastnum;

            Console.WriteLine("Your current Gamestage is " + Gamestage); 


        }
    }
}
