using System;
using System.Collections.Generic;
using System.Text;

namespace _18_module.Factory_Method.Abonement
{
    internal class SimpleMemberShip : IMemberShip
    {

        public string Name { get; } = "SimpleMemberShip";

        public decimal Price { get; set; }
        public DateTime TimeOfAction { get; set; }

        public SimpleMemberShip(decimal price)
        { 
            Price = price;
            TimeOfAction = DateTime.Now;
        }
    }
}
