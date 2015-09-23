using System;
namespace CSharp.Training
{
    public class Fibonacci
    {
        public string sequence(int Nth)
        {
            double prev = 0;
            double next = 1;
            double fib = 0;
            int limit = 2;
            string msj = prev + " " + next;
            while (limit < Nth)
            {
                fib = prev + next;
                msj += " " + fib;
                prev = next;
                next = fib;
                limit += 1;
            }
            Console.WriteLine(msj);
            return msj;
        }
        
        public string Nsequence(int Nth)
        {
            double prev = 0;
            double next = -1;
            double fib = 0;
            int limit = -2;
            string msj = prev + " " + next;
            while (limit > Nth)
            {
                fib = prev - (-next);
                msj += " " + fib;
                prev = next;
                next = fib;
                limit -= 1;
            }
            Console.WriteLine(msj);
            return msj;
        }

    }
}
