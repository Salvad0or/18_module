using _18_module.Factory_Method.Abonement;

namespace _18_module.Factory_Method.ClassFactory
{
    internal class SimpleMemberShipFactory : MembershipFactories
    {
        private decimal _price;
        private string _name;


        public SimpleMemberShipFactory(decimal price, string name)
        {
            _price = price;
            _name = name;
        }

        public override IMemberShip GetMemperShip()
        {
            SimpleMemberShip simpleMember = new SimpleMemberShip(_price,_name);
            return simpleMember;
        }
    }
}
