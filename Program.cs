using System;
class Program
{
    static void Main() //glówna metoda
    {
        Console.WriteLine("Podaj dodatnią liczbę całkowitą:");
        int number = int.Parse(Console.ReadLine());

        bool result = OpMat (number);
        Console.WriteLine("Czy liczba spełnia warunek? " + result);
    }

    static bool OpMat (int n) //def metody
    {
        int sum = 0;
        int temp = n;
        int numDigits = (int)Math.Floor(Math.Log10(n)) + 1; // liczba cyfr w n

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, numDigits);
            temp /= 10;
        }

        // zwraca sprawdzojy wynik
        return sum == n;
    }
}
