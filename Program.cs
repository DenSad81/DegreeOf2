using System;

class Program
{
    static void Main(string[] args) {
        int minDigit = 2;
        int maxDigit = 999;
        int argument = 2;
        int sum;
        int exponent;
        Random random = new Random();
        int digit = random.Next(minDigit, (maxDigit + 1));

        sum = argument;
        for (exponent = 1; sum <= digit; exponent++)
            sum *= argument;

        Console.WriteLine($"Число {digit }, число {argument} в степени {exponent} = {sum}");
    }
}
