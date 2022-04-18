using System;

namespace method_for__N__number_write__3N_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please include number: ");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: "+ Write(C)); 
        }
        public static double Write(int N, int i =0)
        {
            int C = N;
            while (N>0)
            {
                N = N / 10;
                i++;
            }
            double pow_t = Math.Pow(10, i);
            if (i == 1)
            {
                i += 2;
            }
            else if ( i==2 )
            {
                i += 1;
            }
            else
            {
                i = (i - i) + 3;
            }
            return (i*pow_t)+C;
        }
    }
}
