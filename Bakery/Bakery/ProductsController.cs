using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class ProductsController
    {
        private string[] prod = new string[] { "Сосиська в тесте", "Пицца с ветчиной и сыром" };
        private List<Products> Products = new List<Products>();

        public ProductsController()
        {
            BakeryController bakeryController = new BakeryController();
            foreach (var item in prod)
            {
                Bakery bakery = RandBakery(bakeryController);
                int stoimost = RandStoimost();
                Products products = new Products(item, stoimost, bakery);
                Products.Add(products);
            }
        }

        public List<Products> GetProducts()
        {
            return Products;
        }


        private int RandStoimost()
        {
            Random random = new Random();
            int stoim = random.Next(35, 150);
            return stoim;
        }

        private Bakery RandBakery(BakeryController bakeryController)
        {
            Random random = new Random();
            return bakeryController.GetBakery()[random.Next(0, bakeryController.GetBakery().Count)];
        }
        public void AddProducts(string products,
                                int stoimost,
                                string bakery,
                                BakeryController bakerycontroller)
        {
            foreach (Bakery itembakery in bakerycontroller.GetBakery())
            {
                if (itembakery.Name == bakery)
                {
                    Products.Add(new Products(products, stoimost, itembakery));
                    return;
                }
                else
                {
                    bakerycontroller.Add(bakery);
                    Bakery newBakery = bakerycontroller.GetBakerybyName(bakery);

                    Products.Add(new Products(products, stoimost, newBakery));
                    return;
                }
            }

        }
    }
}
