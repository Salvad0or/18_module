using System;
using System.Collections.Generic;
using System.Text;

namespace _18_module.Factory_Method.Abonement
{
    internal interface IMemberShip
    {
        string Name { get; }

        decimal Price { get; set; }

        DateTime TimeOfAction { get; set; }




    }
}
