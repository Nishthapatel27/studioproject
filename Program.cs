using System;

namespace studioProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sam writes here
            Console.WriteLine("Hello, my name is Sam");

            int diceRolls = 10;
            Random rand = new Random();

            for (int i = 0; i < diceRolls; i++)
            {
                rand.Next(1, 7);
                int rolls
                int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;

                    switch(rolls)
                {
                    case 1:
                        count1++
                        break;
                    case 2:
                        count2++;
                        break;
                    case 3: 
                        count3++; 
                        break;
                    case 4: 
                        count4++; 
                        break;
                    case 5: 
                        count5++; 
                        break;
                    case 6: 
                        count6++; 
                        break;
                }
            }

            Console.WriteLine($"1's rolled: {count1}");
            Console.WriteLine($"2's rolled: {count2}");
            Console.WriteLine($"3's rolled: {count3}");
            Console.WriteLine($"4's rolled: {count4}");
            Console.WriteLine($"5's rolled: {count5}");
            Console.WriteLine($"6's rolled: {count6}");

            // ari writes here
            Console.WriteLine("Hello, it's Ari!");
            // nishtha writes here

            Console.WriteLine("hello, it's me");
            Console.ReadLine();

        }
    }
}
