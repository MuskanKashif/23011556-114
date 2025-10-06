using System;

class EvenOddChecker
{
    public static void Run()
    {
        Console.WriteLine("Enter Number");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
            Console.WriteLine("Number is Even");
        else
            Console.WriteLine("Number is Odd");
    }
}

class SimpleCalculator
{
    public static void Run()
    {
        Console.WriteLine("Basic Calculator \nEnter Option \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter First Number");
        int ab = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int ac = int.Parse(Console.ReadLine());
        switch (b)
        {
            case 1:
                Console.WriteLine("Result: " + (ab + ac));
                break;
            case 2:
                Console.WriteLine("Result: " + (ab - ac));
                break;
            case 3:
                Console.WriteLine("Result: " + (ab * ac));
                break;
            case 4:
                Console.WriteLine("Result: " + (ab / ac));
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}

class GradeEvaluator
{
    public static void Run()
    {
        Console.WriteLine("Grade Check \nEnter Marks");
        int x = int.Parse(Console.ReadLine());
        if (x > 85)
            Console.WriteLine("Grade A");
        else if (x <= 85 && x > 70)
            Console.WriteLine("Grade B");
        else if (x <= 70 && x > 55)
            Console.WriteLine("Grade C");
        else if (x <= 55 && x > 40)
            Console.WriteLine("Grade D");
        else
            Console.WriteLine("Grade F");
    }
}

class NaturalNumberSum
{
    public static void Run()
    {
        int n = 0;
        Console.WriteLine("Sum of Natural Numbers\nEnter Number");
        int z = int.Parse(Console.ReadLine());
        for (int i = 1; i <= z; i++)
        {
            n += i;
        }
        Console.WriteLine("Result " + n);
    }
}

class MultiplicationTable
{
    public static void Run()
    {
        Console.WriteLine("Table \nEnter Number:");
        int y = int.Parse(Console.ReadLine());
        for (int s = 1; s <= 10; s++)
        {
            Console.WriteLine(y + " * " + s + " = " + (s * y));
        }
    }
}

class FactorialCalculator
{
    public static void Run()
    {
        int n = 1;
        Console.WriteLine("Factorial\nEnter Number");
        int z = int.Parse(Console.ReadLine());
        for (int i = 1; i <= z; i++)
        {
            n *= i;
        }
        Console.WriteLine("Result " + n);
    }
}

class ReverseNumber
{
    public static void Run()
    {
        Console.WriteLine("Reverse Number\nEnter Number");
        int z = int.Parse(Console.ReadLine());
        int rev = 0;
        while (z > 0)
        {
            rev = rev * 10 + z % 10;
            z /= 10;
        }
        Console.WriteLine("Reverse Number: " + rev);
    }
}

class ArrayMaxMin
{
    public static void Run()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
            arr[i] = int.Parse(Console.ReadLine());
        int max = arr[0], min = arr[0];
        for (int i = 1; i < 10; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Minimum: " + min);
    }
}

class ArrayEvenOddCount
{
    public static void Run()
    {
        int[] arr = new int[10];
        int even = 0, odd = 0;
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;
        }
        Console.WriteLine("Even Numbers: " + even);
        Console.WriteLine("Odd Numbers: " + odd);
    }
}

class ArraySearchElement
{
    public static void Run()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
            arr[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number to search:");
        int num = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < 10; i++)
        {
            if (arr[i] == num)
            {
                found = true;
                break;
            }
        }
        if (found)
            Console.WriteLine("Number found in array");
        else
            Console.WriteLine("Number not found in array");
    }
}

class Assignment
{
    static void Main()
    {
        Console.WriteLine("Select Program (1-10):");
        Console.WriteLine("1. Even or Odd");
        Console.WriteLine("2. Calculator");
        Console.WriteLine("3. Grade Check");
        Console.WriteLine("4. Sum of Natural Numbers");
        Console.WriteLine("5. Table of Number");
        Console.WriteLine("6. Factorial");
        Console.WriteLine("7. Reverse Number");
        Console.WriteLine("8. Array Max and Min");
        Console.WriteLine("9. Array Even and Odd Count");
        Console.WriteLine("10. Array Search Element");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                EvenOddChecker.Run();
                break;
            case 2:
                SimpleCalculator.Run();
                break;
            case 3:
                GradeEvaluator.Run();
                break;
            case 4:
                NaturalNumberSum.Run();
                break;
            case 5:
                MultiplicationTable.Run();
                break;
            case 6:
                FactorialCalculator.Run();
                break;
            case 7:
                ReverseNumber.Run();
                break;
            case 8:
                ArrayMaxMin.Run();
                break;
            case 9:
                ArrayEvenOddCount.Run();
                break;
            case 10:
                ArraySearchElement.Run();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
