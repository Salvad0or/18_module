﻿using _18_module.Entities;
using _18_module.Entities.EntityClasses;
using _18_module.Factory_Method.Abonement;
using _18_module.Factory_Method.ClassFactory;
using System.Threading.Tasks;
using System.Windows;

namespace _18_module.Services
{
    internal class GetFactory
    {

        public static async Task ReturnFactoryClass(string abonementName, decimal price, string clientName)
        {
            MembershipFactories membership = GetFactoryPrivateMethod(abonementName, price, clientName);

            if (membership is null)
            {
                MessageBox.Show("Возникла непредвиденная ошибка");
                return;
            }

            IMemberShip finalMember = membership.GetMemperShip();

            await EntityInsert.InsertIntoClients(finalMember);

        }

        private static MembershipFactories GetFactoryPrivateMethod(string name, decimal price, string clientName)
        {
            switch (name)
            {
                case "base":
                    return new SimpleMemberShipFactory(price, clientName);
                case "pool":
                    return new MemberShipWithPoolFactory(price, clientName);
                case "trainer":
                    return new MemberShipWitchPersonalTrainerFactory(price, clientName);
                default:
                    return null;
            }
        }

    }
}
