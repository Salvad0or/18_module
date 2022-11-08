using System;
using System.Collections.Generic;
using System.Text;

namespace _18_module.Factory_Method.Abonement
{
    internal class MemberShipWitchPersonalTrainer
    {
        public string Name { get; } = "MemrShipWithPersonalTrainer";

        public decimal Price { get; set; }
        public DateTime TimeOfAction { get; set; }

        public MemberShipWitchPersonalTrainer(decimal price)
        {
            Price = price;
            TimeOfAction = DateTime.Now;
        }
    }
}
