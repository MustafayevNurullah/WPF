using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp21.Entity
{
    class Sales
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Guid Barcode { get; set; }
        public Sales(string name, int price, Guid barcode)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
        }
        public Sales()
        { }

        
    }
}
