//Travis Kean
//Lab Day 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Income tax calculator

            //variables
            double income = 0, taxPercent = 0, taxes = 0, tempnum = 0, totaltaxes = 0;
            bool isNum = false;

            //Checks for command line arguments
            if (args.Length > 0)
            {

                //if there are, then for each one we attempt to find taxes
                foreach (string s in args)
                {
                    //checks if the argument is a number
                    isNum = double.TryParse(s, out tempnum);
                    if (isNum)
                    {
                        //if argument is a number, we assign an income, and calculate taxes
                        income = tempnum;


                        if ( income > 0)
                        {

                            taxPercent = 5;
                            if (income <= 20000)
                            {
                                taxes = income * taxPercent / 100;
                                totaltaxes = totaltaxes + taxes;
                            }
                            else
                            {
                                totaltaxes = 1000;
                            }
                        }
                        if (income > 20000)
                        {
                            taxPercent = 10;
                            if (income <= 50000)
                            {
                                taxes = (income - 20000) * taxPercent / 100;
                                totaltaxes = totaltaxes + taxes;
                            }
                            else
                                totaltaxes = 4000;
                        }
                        if (income > 50000)
                        {
                            taxPercent = 20;
                            if (income <= 75000)
                            {
                                taxes = (income - 50000) * taxPercent / 100;
                                totaltaxes = totaltaxes + taxes;
                            }
                            else
                                totaltaxes = 9000;
                        }
                        if (income > 75000)
                        {
                            taxPercent = 35;
                            taxes = (income - 75000) * taxPercent / 100;
                            totaltaxes = totaltaxes + taxes;
                        }

                        Console.WriteLine("The income taxes of a person with an income of " + income.ToString("c2") + " come to " + totaltaxes.ToString("c2"));
                    }
                    else
                        Console.WriteLine( s +  " is not a valid income");
                        
                    
                    Console.ReadLine();
                }
            }
            else
                Console.WriteLine("There are no arguments on the command line");
            Console.Read();
            Console.Clear();
            //Time and Classifications

            DateTime seconds = DateTime.Now;
            int currentSeconds = seconds.Second;
            
            //test quarter 1
            //int testQ1 = 2;
            //currentSeconds = testQ1;

            //test quarter 2
            //int testQ2 = 16;
            //currentSeconds = testQ2;

            //test quarter 3
            //int testQ3 = 35;
            //currentSeconds = testQ3;

            //test quarter 4
            //int testQ4 = 50;
            //currentSeconds = testQ4;

            //test out of time range
            //int testNonQ = 90
            //currentSeconds = testNonQ;

            if (currentSeconds < 15)
            {
                Console.WriteLine("This new minute is just beginning");
            }
            else if (currentSeconds < 30)
            {
                Console.WriteLine("We're one quarter done");
            }
            else if (currentSeconds < 45)
            {
                Console.WriteLine("Half way There");
            }
            else if (currentSeconds < 60)
            {
                Console.WriteLine("Getting close to done");
            }
            else
                Console.WriteLine("Working on it");
            Console.WriteLine("The current amount of seconds in the minute are " + currentSeconds.ToString());
            Console.Read();
            Console.Read();
            Console.Clear();

            








        }


        
    }
}
