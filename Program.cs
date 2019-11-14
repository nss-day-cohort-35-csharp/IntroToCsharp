using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Adam";
            int cohort = 34;
            int theBestCohort = 35;

            // reassigning variables
            name = "Jisie";
            cohort = 35;

            // String concatenation
            string greeting = "Hello " + name + ". Welcome to cohort " + cohort;

            // String interpolation
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";

            // declare boolean variable
            bool isTheBest = cohort == theBestCohort;

            Console.WriteLine(greeting2);

            // conditionals
            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around");
            }
            else if (name == "Jisie")
            {
                Console.WriteLine("Well, not in the right cohort. But She's pretty cool");
            }
            else
            {
                Console.WriteLine("You may... want to rethink your decisions");
            }

            // Loops
            // For Loops
            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            // Foreach Loops
            foreach (int c in cohorts)
            {
                Console.WriteLine($"Cohort {c}");
            }

            // While Loops
            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }
        }
    }
}
