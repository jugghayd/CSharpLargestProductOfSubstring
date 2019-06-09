using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a long number: \n>");
        string numbers = Console.ReadLine();

            Console.WriteLine("For how many digits in a row would you like the largest product?");
        int numAdjacent = Int32.Parse(Console.ReadLine());


        string maxProductStr = "0";
        long maxProduct = 0;

        for (int i = 0; i + numAdjacent < numbers.Length; i++)
        {
            int j = 0;
            bool zeroFound = false;

            int product = 1;

            for (j = i; j < i + numAdjacent; j++)
            {
                int number = numbers[j] - '0';

                if (number == 0)
                {
                    zeroFound = true;
                    break;
                }
                else
                {
                    product *= number;
                }
            }

            if (zeroFound)
            {
                i = j; 
            }
            else
            {
                if (product > maxProduct)
                {
                    maxProductStr = numbers.Substring(i, numAdjacent);
                    maxProduct = product;
                }
            }
        }

        
        string _maxProductStr = "";
        for (int i = 0; i < maxProductStr.Length; i++)
        {
            _maxProductStr += maxProductStr[i] + " x ";
        }

       
        _maxProductStr =
            _maxProductStr.Substring(0, _maxProductStr.Length - " x ".Length);

        Console.WriteLine(
        "Largest product: " + _maxProductStr + " = " + maxProduct);

        Console.ReadLine();
    }
}