using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {

        ClassWithFunc f = new ClassWithFunc();

        //f.Sort();

        Console.WriteLine("Введите слово: ");
        string input = Console.ReadLine();
        Console.WriteLine(f.Polindrom(input));

        Console.WriteLine("Введите число");
        int inputNum = int.Parse((Console.ReadLine()));
        Console.WriteLine("Факториал данного числа равен: " + f.Fact(inputNum));

        Console.WriteLine("Введите позицию в строке (от 0 до 4)");
        int index = int.Parse(Console.ReadLine());
        if (f.Fib(index) == 0)
        {
            Console.WriteLine("Ошибка");
        }
        else
        {
            Console.WriteLine(f.Fib(index));
        }

        Console.WriteLine("Введите основание");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите степень");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(f.Vesh(a, b));

        Console.WriteLine("Введите число");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine(f.Check(i));
    }
}

public class ClassWithFunc
{
    int[] mas = new int[] { 3, 5, 2, 7, 1 };

    public static void Sort(ref int[] mas)
    {
        int swap = 0;
        for (int i = 0; i < mas.Length - 1; i++)
        {
            for (int j = 0; j < mas.Length - 1 - i; j++)
            {
                if (mas[j] > mas[j + 1])
                {
                    swap = mas[j + 1];
                    mas[j + 1] = mas[j];
                    mas[j] = swap;
                }
            }
        }

        //for (int i = 0; i < mas.Length; i++)
        //   Console.WriteLine(mas[i]);
     
    }

    public bool Polindrom(string input)
    {
        char[] newArr = input.ToCharArray();
        Array.Reverse(newArr);
        string s = new string(newArr);
        if (input == s)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public double Fact(int inputNum)
    {
        if (inputNum >= 0)
        {
            if(inputNum == 0)
            {
                return 1;
            }
            else
            {
                int count = inputNum;
                int output = inputNum;
                while (count > 1)
                {
                    count--;
                    output = output * count;
                }
                return output;
            }
            
        }
        else
        {
            return double.NaN;
        }

    }

    public double Fib(int index)
    {
        if (index > 1)
        {
            return mas[index - 1] + mas[index - 2];
        }
        else
        {
            return double.NaN;
        }
    }

    public double Vesh(double a, double b)
    {
        double c = Math.Round(Math.Pow(a, b), 2);
        return c;
    }

    public bool Check(int number)
    {
        if (number <= 1) return false; // 1 и меньше не являются простыми числами
        if (number == 2) return true; // 2 - единственное четное простое число

        if (number % 2 == 0) return false; // все четные числа кроме 2 не являются простыми

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;

    }
}

