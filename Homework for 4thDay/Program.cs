using System;

namespace Homework_for_4thDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] Laptop = new Notebook[3];

            for (int i = 0; i < Laptop.Length; i++)
            {
                Console.WriteLine("Hansi Brand oldugunu daxil edin :");
                string brand= Console.ReadLine();

                Console.WriteLine("Hansi Model oldugunu daxil edin:");
                string model= Console.ReadLine();

                double price;
                Console.WriteLine("Qiymetini daxil edin:");
                string Price=Console.ReadLine();
                price = Convert.ToDouble(Price);

               
                Laptop[i] =  new Notebook(brand, model, price);
            }

            double sum = 0;
            for (int i = 0; i < Laptop.Length; i++)
            {
                sum += Laptop[i].Price;            
            }

            double average = sum / Laptop.Length;
            Console.WriteLine(average);
        }






    }





}
