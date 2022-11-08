using System;
using System.Collections.Generic;
using System.Text;

namespace _18_module.Factory_Method.Abonement
{
    internal class MemberShipWithPool
    {
        public string Name { get; } = "MemberShipWithPool";

        public decimal Price { get; set; }
        public DateTime TimeOfAction { get; set; }

        public MemberShipWithPool(decimal price)
        {
            Price = price;
            TimeOfAction = DateTime.Now;
        }
    }
}
