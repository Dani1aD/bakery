using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{ 
    class Program
    {
        private static ProductsController products;
        private static BakeryController bakery;

        static void Main(string[] args)
        {
            products = new ProductsController();
            bakery = new BakeryController();

            while (true)
            {
                Menu(products, bakery);
            }

        }

        private static void Menu(ProductsController products, BakeryController bakery)
        {
            Console.WriteLine();
            Console.WriteLine("Чтобы вывести список выпечки, введите: all prod");
            Console.WriteLine("Чтобы вывести список выпечки, введите: all bak");
            Console.WriteLine("Чтобы создать новую пекарню, введите: create bakery");
            Console.WriteLine("Чтобы создать новую выпечку, введите: create product");
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "all prod": PrintBak(); break;
                case "all bak": PrintProd(); break;
                case "create bakery": CreateBakery(); break;
                case "create product": CreateProduct(products, bakery); break;
            }
        }

        private static void PrintBak()
        {
            foreach (Bakery aBakery in bakery.GetBakery())
            {
                Console.WriteLine(aBakery.ToString());
            }
        }

        private static void PrintProd()
        {
            foreach (Products aProd in products.GetProducts())
            {
                Console.WriteLine(aProd.ToString());
            }
        }

        private static void CreateBakery()
        {
            Console.WriteLine("Введите название пекарни");
            string nBak = Console.ReadLine();
            try
            {
                bakery.Add(nBak);
                PrintBak();
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }

        private static void CreateProduct(ProductsController products, BakeryController bakery)
        {
            Console.WriteLine("Введите название продукта");
            string product = Console.ReadLine();

            Error:
            Console.WriteLine("Введите стоимость:");
            try
            {
                int stoimost = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите корректные данные!");
                goto Error;
            }
            

            Console.WriteLine("Список фирм:");
            PrintBak();

            Console.WriteLine("Введите фирму:");
            _ = Console.ReadLine();
        }
    }       
}    