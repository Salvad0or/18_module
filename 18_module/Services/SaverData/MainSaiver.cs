using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _18_module.Services.SaverData
{
    internal class MainSaiver
    {
        /// <summary>
        /// Основной сейвер. Принимает на вход опрделенный класс и реализует метод сохранения
        /// </summary>
        /// <param name="_saver"></param>
        public MainSaiver(ISaveData _saver)
        {
            ISaveData Saver = _saver;
            Saver.SaveData();
            MessageBox.Show("Данные успешно записаны");
        }
    }
}
