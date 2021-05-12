using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class BakeryController
    {
        private List<Bakery> bakery = new List<Bakery>();

        private string[] bak = new string[] { "Хлебница", "БИКО" };

        public BakeryController()
        {
            foreach (var item in bak)
            {
                bakery.Add(new Bakery(item));
            }
        }

        public List<Bakery> GetBakery()
        {
            return bakery;
        }
        public void Add(string nBaker)
        {
            foreach (Bakery bakery in bakery)
            {
                if (bakery.Name == nBaker)
                {
                    throw new ArgumentException("Это название уже есть");
                }
            }
            bakery.Add(new Bakery(nBaker));

        }

        public Bakery GetBakerybyName(string name)
        {
            foreach (Bakery bakery in bakery)
            {
                if (bakery.Name == name)
                {
                    return bakery;
                }
            }
            return null;
        }
    }
}
