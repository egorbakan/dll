using System;
using NewLib;

namespace lib2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 func = new Class1();

            Console.WriteLine($"Стоимость первого товара будет =  {func.Price_sum(20)}");
            Console.WriteLine($"Стоимость второго товара будет =  {func.Price_sum2(20)}");
            Console.WriteLine($"Привет, рост через 5 лет будет =  {func.Price_sum3(150)}");

        }
    }
}
