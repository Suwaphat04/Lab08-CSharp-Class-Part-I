using System;

class Program
{
    static void Main()
    {
        // การคำนวณการบวก
        int x = 2, y = 3;
        int add_result = Calculator.add(x, y);
        System.Console.WriteLine($"{x} + {y} = {add_result}");

        // การคำนวณการคูณ
        int i = 2, j = 3;
        int multiply_result = Calculator.multiply(i, j);
        System.Console.WriteLine($"{i} x {j} = {multiply_result}");
    }
}

public static class Calculator
{
    // เมธอด add สำหรับการบวก
    public static int add(int a, int b)
    {
        return a + b;
    }

    // เมธอด multiply สำหรับการคูณ
    public static int multiply(int a, int b)
    {
        return a * b;
    }
}

