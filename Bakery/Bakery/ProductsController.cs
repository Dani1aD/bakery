using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    public class ProductsController
    {
        private List<Products> telephones { get; set; } = new List<Products>();

        private string[] prod = new string[] { "Сосиська в тесте", "Пицца с ветчиной и сыром" };
        private List<Products> products;

        public ProductsController()
        {
            BakeryController bakeryController = new BakeryController();
            foreach (var item in prod)
            {
                Bakery bakery = RandBakery(bakeryController);
                int stoimost = RandStoimost();
                Products products = new Products(item, stoimost, bakery);
                products.Add(products);
            }
        }

        public List<Products> Products()
        {
            return products;
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
                    products.Add(new Products(products, stoimost, itembakery));
                    return;
                }
                else
                {
                    bakerycontroller.Add(bakery);
                    Bakery newBakery = bakerycontroller.GetBakerybyName(bakery);

                    products.Add(new Products(products, stoimost, newBakery));
                    return;
                }
            }

        }

        internal IEnumerable<Products> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
