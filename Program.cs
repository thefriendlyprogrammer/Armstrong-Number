using System;

namespace Armstrong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Armstrong Number");
            int number, r, sum = 0, temp;
            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                r = number % 10;
                sum = sum + (r * r * r);
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
            Console.ReadLine();
        }
    }
}
