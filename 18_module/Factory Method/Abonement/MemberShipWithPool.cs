using System;

namespace _18_module.Factory_Method.Abonement
{
    /// <summary>
    /// Абонемент с бассейном
    /// </summary>
    internal class MemberShipWithPool : IMemberShip
    {
        
        public string AbonementName { get; } = "MemberShipWithPool";
        public string ClientName { get; set; }

        public decimal Price { get; set; }

        public MemberShipWithPool(decimal price,string clientName)
        {
            Price = price;
            ClientName = clientName;
        }
    }
}
