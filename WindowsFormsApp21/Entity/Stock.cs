using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp21.Entity
{
    class Stock
    {
        public string Name { get; set; }
        public Guid Barcode { get; set; }
        public int MyProperty { get; set; }
        public int Quantity { get; set; }
        public Stock(string name, Guid barcode, int myProperty, int quantity)
        {
            Name = name;
            Barcode = barcode;
            MyProperty = myProperty;
            Quantity = quantity;
        }

        public Stock()
        { }
    }
}
