using System;


public class Vector2D
{
    public int num = 0;
    public int x;
    public int y;

    public Vector2D(int num, int x, int y)
    {
        this.num = num;
        this.x = x;
        this.y = y;
    }


    public string get()
    {
        return $"{num} pos. Is at ({x},{y})";
    }

}


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
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;

            for (int i = 0; i < diceRolls; i++)
            {
                int rolls = rand.Next(1, 7);

                    switch(rolls)
                {
                    case 1:
                        count1++;
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

            Console.WriteLine($"1's rolled: {count1}"); // setting count within the for loop so you can't see when outside of loop
            Console.WriteLine($"2's rolled: {count2}");
            Console.WriteLine($"3's rolled: {count3}");
            Console.WriteLine($"4's rolled: {count4}");
            Console.WriteLine($"5's rolled: {count5}");
            Console.WriteLine($"6's rolled: {count6}");

            // ari writes here
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello, it's Ari!");
            int xbounds = 20;
            int ybounds = xbounds / 2; 
            Vector2D[] positions = new Vector2D[0];
            


            Console.SetCursorPosition(0, 2);
            for (int y = 0; y < ybounds; y++)
            {
                for (int x = 0; x < xbounds; x++)
                {
                    Console.Write($"{(y * xbounds)+x}.({x},{y})  .");

                    Array.Resize<Vector2D>(ref positions, positions.Length + 1);
                    positions[positions.Length-1] = new Vector2D((y * xbounds + x), x, y);

                }
                Console.WriteLine();
            }
            

            for (int i = 0; i < positions.Length; i++)
            {
                Console.WriteLine(positions[i].get());
            }
                
            Console.ReadLine();

            

            // nishtha writes here

            Console.WriteLine("hello, it's me");
            Console.ReadLine();

        }
    }
}
