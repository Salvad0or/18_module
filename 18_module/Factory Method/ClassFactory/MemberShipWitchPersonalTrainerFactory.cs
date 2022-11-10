using _18_module.Factory_Method.Abonement;

namespace _18_module.Factory_Method.ClassFactory
{
    internal class MemberShipWitchPersonalTrainerFactory : MembershipFactories
    {
        private decimal _price;
        private string _name;


        public MemberShipWitchPersonalTrainerFactory(decimal price, string name)
        {
            _price = price;
            _name = name;
        }

        public override IMemberShip GetMemperShip()
        {
            MemberShipWitchPersonalTrainer memberShipWitchPersonalTrainer = new MemberShipWitchPersonalTrainer(_price, _name);
            return memberShipWitchPersonalTrainer;
        }
    }



}
