using System;
using FSharpLibrary;

namespace CSharpFSharpInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            Console.WriteLine($"{x} * {y} = {Multiplication.multiply(x, y)}");
            Console.Read();
        }
    }
}
