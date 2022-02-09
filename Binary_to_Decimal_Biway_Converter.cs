```CSharp
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Binary to Decimal");
            Console.WriteLine("2. Decimal to Binary");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a binary number: ");
                    string binary = Console.ReadLine();
                    Console.WriteLine("Decimal: " + Convert.ToInt32(binary, 2));
                    break;

                case 2:
                    Console.Write("Enter a decimal number: ");
                    int decimalNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Binary: " + Convert.ToString(decimalNumber, 2));
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
```