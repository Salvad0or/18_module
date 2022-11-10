using _18_module.Factory_Method.Abonement;

namespace _18_module.Factory_Method.ClassFactory
{
    internal class MemberShipWithPoolFactory : MembershipFactories
    {
        private decimal _price;
        private string _name;


        public MemberShipWithPoolFactory(decimal price, string name)
        {
            _price = price;
            _name = name;
        }

        public override IMemberShip GetMemperShip()
        {
            MemberShipWithPool memberShipWithPool = new MemberShipWithPool(_price,_name);
            return memberShipWithPool;
        }
    }
}
