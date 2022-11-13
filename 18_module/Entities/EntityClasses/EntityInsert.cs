using _18_module.Factory_Method.Abonement;
using System.Threading.Tasks;
using System.Windows;

namespace _18_module.Entities.EntityClasses
{
    /// <summary>
    /// Класс по работе с SQL командой Insert
    /// </summary>
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

                context.SaveChanges();

                MessageBox.Show("Новый абонемет добавлен");
            }
        }
    }
}
