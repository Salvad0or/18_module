namespace _18_module.Factory_Method.Abonement
{
    /// <summary>
    /// Интерфейс задающий логику всех абонементов
    /// </summary>
    internal interface IMemberShip
    {
        
        string AbonementName { get; }

        string ClientName { get; set; }

        decimal Price { get; set; }

    }
}
