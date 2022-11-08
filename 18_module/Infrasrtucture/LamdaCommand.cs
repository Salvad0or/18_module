using System;
using System.Collections.Generic;
using System.Text;

namespace _18_module.Infrasrtucture
{
    internal class LamdaCommand : BaseCommand
    {

        private Action<object> _ex { get; set; }

        private Func<object, bool> _canEx { get; set; }

        public override bool CanExecute(object parameter) => _canEx?.Invoke(parameter) ?? true;
       

        public override void Execute(object parameter) => _ex?.Invoke(parameter);
        

        public LamdaCommand(Action<object> ex, Func<object,bool> canEx)
        {
            _ex = ex;
            _canEx = canEx;
        }
    }
}
