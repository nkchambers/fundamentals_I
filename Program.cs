using System;

namespace fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
        //----------------------1st Challenge-------------------------
            for (int i=1; i<256; i++) {
                
                Console.WriteLine(i);

            }

        //------------------------2nd Challenge-------------------------
            for (int i=1; i<101; i++) {
                if (i%3 == 0  &&  i%5 == 0) {
                    continue;
                }
                else if (i%3 == 0  ||  i%5 == 0) {
                    Console.WriteLine(i);
                }
                else {
                    continue;
                }
            }

        //------------------------3rd Challenge-------------------------
            for (int i=1; i<101; i++) {
                if (i%3 == 0  &&  i%5 == 0) {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i%3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if (i%5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
