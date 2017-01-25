using System;


namespace my_num2text
{
    class Program
    {
        static string[] one = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                                             "seventeen", "eighteen", "nineteen" };
        static string[] ten = new string[] { null, null, "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        static void Main()
        {


            var n = int.Parse(Console.ReadLine());
            if (n == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {

                if (n < 0 || n > 99)
                {
                    Console.WriteLine("invalid number");
                    Environment.Exit(1);
                    
                }

                int tens = (n / 10) % 10;
                int ones = n % 10;
                string word;

                if (tens == 0)
                {
                    word = one[ones];
                }
                else
                {
                    if (tens == 1)
                    {
                        word = teens[ones];
                    }
                    else
                    {
                        word = ten[tens];
                        if (ones > 0)
                            word += " " + one[ones];
                    }
                }
                Console.WriteLine(word);
            }
        }
    }
}


