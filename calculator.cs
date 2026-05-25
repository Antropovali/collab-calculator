using System;
class Calc {
    static void Main()
    {
        int a = 5, b = 3;
        Console.WriteLine($"{a}+{b}={Add(a, b)}");
        Console.WriteLine($"{a}-{b}={Sub(a, b)}");
        Console.WriteLine($"{a}*{b}={Mul(a, b)}");
        Console.WriteLine($"{a}/{b}={Div(a, b)}");
    }
    static int Add(int x, int y) => x + y;
    static int Sub(int x, int y) => x - y;
    static int Mul(int x, int y) => x * y;
    static int Div(int x, int y) => y != 0 ? x / y : 0;
    }