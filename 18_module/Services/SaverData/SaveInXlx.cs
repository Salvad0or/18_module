using _18_module.Entities;
using System.IO;
using System.Linq;

namespace _18_module.Services.SaverData
{
    /// <summary>
    /// Сохранялка в Xlsx
    /// </summary>
    internal class SaveInXlx : ISaveData
    {
        public  string FileName { get; set; }

        public SaveInXlx(string _fileName)
        {
            FileName = _fileName + ".xlsx";
        }

        public  void SaveData()
        {

            using (StreamWriter sr = new StreamWriter(FileName))
            {
                sr.Write("Haha");
            }
        }
    }
}
