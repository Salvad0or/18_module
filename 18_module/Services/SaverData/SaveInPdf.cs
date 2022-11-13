using System.IO;

namespace _18_module.Services.SaverData
{
    /// <summary>
    /// Сохранялка в PDF
    /// </summary>
    internal class SaveInPdf : ISaveData
    {
        public string FileName { get; set; }

        public SaveInPdf(string _fileName)
        {
            FileName = _fileName + ".pdf";
        }

        public void SaveData()
        {
            
            using (StreamWriter sr = new StreamWriter(FileName))
            {
                sr.Write("Haha");
            }
        }
    }
}
