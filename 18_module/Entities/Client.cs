using System;
using System.Collections.Generic;
using System.Text;

namespace _18_module.Entities
{
    /// <summary>
    /// Класс клиента для создания в базе данных через Entity
    /// </summary>
    internal class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
       
        public string AbonementType { get; set; }

        public decimal AbonementPrice { get; set; }
    }
}
