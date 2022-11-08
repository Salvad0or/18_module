using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace _18_module.View
{
    internal class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnProperyChanged([CallerMemberNameAttribute] string propertieName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertieName));
        }
    }
}
