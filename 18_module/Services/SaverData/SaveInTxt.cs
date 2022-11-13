using _18_module.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_module.Services.SaverData
{
    internal class SaveInTxt : ISaveData
    {
        /// <summary>
        /// Сохранялка в TXT
        /// </summary>
        public string FileName { get; set; }

        public SaveInTxt(string _fileName)
        {
            FileName = _fileName + ".txt";
        }

        public void SaveData()
        {
            List<Client> Data = new List<Client>();

            using (Context context = new Context())
            {
                Data = context.Clients.ToList();
            }

            using (StreamWriter sr = new StreamWriter(FileName))
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    sr.WriteLine($"Id: {Data[i].Id} " +
                        $"Имя клиента: {Data[i].ClientName}, " +
                        $"Тип абонемента: {Data[i].AbonementType}, " +
                        $"Цена: {Data[i].AbonementPrice}");
                }
            }
        }
    }
}
