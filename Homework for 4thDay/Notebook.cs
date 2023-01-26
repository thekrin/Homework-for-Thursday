using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Homework_for_4thDay
{
    internal class Notebook
    {
        public Notebook(string brand, string model, double price = 0)
        {
           this.Brand=brand;
           this.Model=model;
           this.Price=price;
        }

            public string Brand;
            public string Model;
            public double Price;

        public string ShowInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Price: {Price}";
        }
    }
    

    
}
