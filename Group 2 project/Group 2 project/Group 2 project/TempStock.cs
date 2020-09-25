using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_2_project
{
    public class TempStock
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string brand { get; set; }
        public int quantity { get; set; }


        public override string ToString()
        {
            return ($"ID: {id}, name: {name}, price: ${price}, brand: {brand}, quantity: {quantity}");
        }
    }
}
