using System;
namespace CSharp.Training
{
    public static class ExtensionMethod    {

        public static string Leap(this int year)
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
    public class LeapYear
    {

        /*
         * A year is a leap year if it is divisible by 4 unless it is divisible by 100.
         * However, if a year is divisible by 100 and is also divisible by 400, 
         * it is also a leap year.
         * */
        int Lyear = 2016;
       
        

    }

  
}
