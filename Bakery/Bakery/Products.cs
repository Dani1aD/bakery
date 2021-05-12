using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Products
    {
        public Bakery Bakery { get; private set; }
        public string Product { get; private set; }

        public int Stoimost { get; private set; }

        public Products(string product, int stoimost)
        {
            if (string.IsNullOrEmpty(product))
            {
                throw new ArgumentException("У продукта не может отсутствовать название", nameof(product));
            }

            if(stoimost < 0)
            {
                throw new ArgumentException("Стоимость не может быть ниже нуля", nameof(stoimost));
            }
            Product = product;
            Stoimost = stoimost;

        }

        internal void Add(Products product)
        {
            throw new NotImplementedException();
        }

        public Products(string product, int stoimost, Bakery bakery) : this(product, stoimost)
        {
            Bakery = bakery ?? throw new ArgumentException(nameof(bakery));
        }

        public override string ToString()
        {
            return $"Продукт: {Product} , Стоимость: {Stoimost} , Пекарня: {Bakery}";
        }
    }
}
