using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
namespace CSharp.Training
{

    public class LeapYear    {

        /*
         * A year is a leap year if it is divisible by 4 unless it is divisible by 100.
         * However, if a year is divisible by 100 and is also divisible by 400, 
         * it is also a leap year.
         * */
        public string Leaping(int pyear)
        {
             Console.WriteLine(pyear.isLeapYear());
             return pyear.isLeapYear();
        }


    }

    public static class ExtensionMethodLeapYear
    {
        public static string isLeapYear(this int year)
        {
            string msj = "";
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        msj = year + " is a leap year";
                    }
                    else { msj = year + " is not a leap year"; }
                }
                else { msj = year + " is a leap year"; }
            }
            else { msj = year + " is not a leap year"; }
            return msj;
        }
    
    }

  

  
}
