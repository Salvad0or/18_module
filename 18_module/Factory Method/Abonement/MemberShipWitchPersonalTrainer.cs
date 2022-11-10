namespace _18_module.Factory_Method.Abonement
{
    /// <summary>
    /// Абонимент с персональным тренером
    /// </summary>
    internal class MemberShipWitchPersonalTrainer : IMemberShip
    {
        
        public string AbonementName { get; } = "MemrShipWithPersonalTrainer";

        public string ClientName { get; set; }

        public decimal Price { get; set; }

        public MemberShipWitchPersonalTrainer(decimal price,string clientname)
        {
            Price = price;
            ClientName = clientname;
        }
    }
}
