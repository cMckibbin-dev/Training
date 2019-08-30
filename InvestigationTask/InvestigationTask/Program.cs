using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationTask
{
    class Program
    {
        public static string[] calculations;
        static Random rnd = new Random();
        
        static void Main(string[] args)
        {
            calculations = new string[6];

            for(int i = 0; i < calculations.Length; i++)
            {
                int no1, no2, ans;

                no1 = Random;

                no2 = Random;

                if (no1 <= 50)
                {
                    ans = no1 - no2;

                    calculations[i] = $"{no1}-{no2}={ans}";
                }
                else if (no1 > 100)
                {
                    ans = no1 + no2;

                    calculations[i] = $"{no1}+{no2}={ans}";
                }                    
                else
                {
                    ans = no1 * no2;

                    calculations[i] = $"{no1}*{no2}={ans}";
                }
                   
                Console.WriteLine(ans);
            }


            for (int i = 0; i < calculations.Length; i++)
            {
                string ans;

                do
                {
                    Console.WriteLine("\nType the equation for no) " + (i + 1));

                    ans = Console.ReadLine();
                    if (ans != calculations[i])
                        Console.WriteLine("Incorect answer entered, please try again");

                } while (ans != calculations[i]);
            }

            Console.WriteLine("\nCongratulations =) You've completed the exercise");
            Console.ReadLine();
        }

        public static int Random
        {
            get { return rnd.Next(1, 201); }
        }
    }
}
