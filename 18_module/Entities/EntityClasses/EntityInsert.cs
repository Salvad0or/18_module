using _18_module.Factory_Method.Abonement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _18_module.Entities.EntityClasses
{
    internal class EntityInsert
    {
        public static async Task InsertIntoClients(IMemberShip newClient)
        {
            using (Context context = new Context())
            {

                Client client = new Client()
                {
                    ClientName = newClient.ClientName,
                    AbonementPrice = newClient.Price,
                    AbonementType = newClient.AbonementName
                };

                context.Clients.Add(client);

                //context.Clients.Add(new Client()
                //{
                //    ClientName = newClient.ClientName,
                //    AbonementPrice = newClient.Price,
                //    AbonementType = newClient.AbonementName
                //});

                context.SaveChanges();

                MessageBox.Show("Новый абонемет добавлен");
            }
        }
    }
}
