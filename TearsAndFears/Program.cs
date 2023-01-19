using System;

namespace TearsAndFears
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            // Get number of rolls
            Console.WriteLine("Enter desired number of rolls: ");
            int numRolls = Convert.ToInt32(Console.ReadLine());
            


            // Declare Array for roll total for numbers rolled
            int[] rollTotals = new int[11];


            Console.WriteLine(" \n \n DICE ROLLING SIMULATION RESULTS \n " +
                    "       (Each '*' represents 1 % of the total number of rolls.) \n \n" +
                    "Total number of rolls: \n");

            // Simulate dice roll
            for (int i = 0; i < numRolls ; i++)
            {
                //rolls dice
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);
                int roll = roll1 + roll2;

                //Increments individual roll count
                rollTotals[(roll - 2)]++;
            }


            // Print out array results


            int perc = 0;

            for (int i = 0; i < 11; i++)
            {
                perc = (int)(((rollTotals[i] / (float)numRolls)) * 100);

                Console.Write(rollTotals[i] + ": "); 
                for (int z = 0; z < perc; z++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }
    }
}
