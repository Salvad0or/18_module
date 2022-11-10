using System;

namespace _18_module.Factory_Method.Abonement
{
    /// <summary>
    /// Абонемент простой
    /// </summary>
    internal class SimpleMemberShip : IMemberShip
    {
        
        public string AbonementName { get; } = "SimpleMemberShip";

        public string ClientName { get; set; }

        public decimal Price { get; set; }
        

        public SimpleMemberShip(decimal price, string clientName)
        {
            Price = price;
            ClientName = clientName;
        }
    }
}
