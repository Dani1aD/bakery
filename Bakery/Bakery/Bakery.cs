using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    class Bakery
    {
        public string Name { get; private set; }

        public Bakery(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("У пекарни не должно отсутствовать название", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
