// S5034
// CIS 199-50
// Lab 5
// October 17, 2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperatures from -20 to 130 (999 to stop)");
            
            double temp = 0;
            string userInput;
            int num;
            bool success;
            const double lowTemp = -20;
            const double highTemp = 130;
            const double maxTemp = 999;
            double sumOfTemps = 0;
            double numOfTemps = 0;
            double mean;

            do
            {
                Console.Write("Enter Temperature: ");
                userInput = Console.ReadLine();

                success = int.TryParse(userInput, out num);

                if (success)
                {
                    temp = Convert.ToDouble(num);

                    if (temp != maxTemp)
                    {
                        if (temp < lowTemp || temp > highTemp)
                        {
                            Console.WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
                        }
                        else
                        {
                            numOfTemps++;
                            sumOfTemps += temp;
                        }
                    }

                }     
                else
                {
                    Console.WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
                }

            } while (!success || temp != maxTemp);

            mean = sumOfTemps / numOfTemps;

            Console.WriteLine("");
            Console.WriteLine("You entered {0} valid temperatures.", numOfTemps);
            Console.WriteLine("The mean temperature is {0} degrees.", mean);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();

        }
    }
}
