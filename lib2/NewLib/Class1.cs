using System;


namespace NewLib
{
    public class Class1
    {
        public void Priceecho(string name)
        {
            Console.WriteLine($"Привет, стоимость продуктов будет = {name}");
        }

        public void Heightecho(string name)
        {
            Console.WriteLine($" = {name}");
        }

        public int Price_sum(int price)
        {
            return price + 1520;
        }
        public float Price_sum2(int price)
        {
            return price + 265;
        }
        public int Price_sum3(int heigth)
        {
            return heigth + 15;
        }
    }
}
