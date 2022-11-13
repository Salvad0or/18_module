namespace _18_module.Services.SaverData
{
    /// <summary>
    /// Интерфейс для всех классов-сохранялок
    /// </summary>
    internal interface ISaveData
    {
        string FileName { get; set; }
        void SaveData();
    }
}
