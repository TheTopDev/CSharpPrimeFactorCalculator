using System;

namespace Mod2P1
{
    public class PrimeFactors
    {
        static void PrimeFactorsCalculator(int num)
        {
            while (num % 2 == 0) {
                Console.Write(2 + "X");
                num /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(num); i += 2){
                while (num % i == 0) {
                    Console.Write(i + "X");
                    num /= i;
                }
            }
            if (num > 2) 
                Console.Write(num);
        }

        public static void Main() {

            Console.WriteLine("Please enter a number to find its prime factors or enter ");
                try  {
                    int number = Convert.ToInt32(Console.ReadLine());
                    PrimeFactorsCalculator(number);
                }
                catch (Exception ex) {
                    Console.WriteLine("Please check your input" + ex.Message);
                }
        }
    }
}
