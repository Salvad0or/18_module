using _18_module.Entities;
using _18_module.Infrasrtucture;
using _18_module.Services;
using System.Windows.Input;

namespace _18_module.View
{
    internal class MainWindowViewModel : ViewModel
    {

        #region Private-свойства

        private string _clientName;
        private decimal _abonementPrice;

        #endregion

        #region Свойства первого окна

        public string ClientName
        {
            get { return _clientName; }
            set
            {
                _clientName = value;
                OnProperyChanged();
            }
        }

        public decimal AbonementPrice
        {
            get { return _abonementPrice; }
            set
            { 
                _abonementPrice = value;
                OnProperyChanged();
            }
        }

        #endregion

        #region Команды 

        #region Команды первого окна

        public ICommand SimpleAbonementCommand { get; set; }

        public bool CanBaseCommanExecuted(object p) => CanTuchButtons();

        public void OnBaseCommandExecute(object p) 
        {
            GetFactory.ReturnFactoryClass("base", AbonementPrice, ClientName);
        }

        ///

        public ICommand WithPollAbonementCommand { get; set; }

        public bool CanWithPollCommanExecuted(object p) => CanTuchButtons();

        public void OnWithPollCommandExecute(object p)
             =>
            GetFactory.ReturnFactoryClass("pool", AbonementPrice, ClientName);



        ///

        public ICommand WithTrainerAbonementCommand { get; set; }

        public bool CanWithTrainerCommanExecuted(object p) => CanTuchButtons();

        public void OnWithTrainerlCommandExecute(object p) 
            =>
            GetFactory.ReturnFactoryClass("trainer", AbonementPrice, ClientName);

        #endregion



        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            SimpleAbonementCommand = new LamdaCommand(OnBaseCommandExecute,CanBaseCommanExecuted);
            WithPollAbonementCommand = new LamdaCommand(OnWithPollCommandExecute, CanWithPollCommanExecuted);
            WithTrainerAbonementCommand = new LamdaCommand(OnWithTrainerlCommandExecute, CanWithTrainerCommanExecuted);

            #endregion

            #region Свойства

            ClientName = string.Empty;

            #endregion
        }


        #region Вспомогательные методы

        private bool CanTuchButtons()
        {
            if (Equals(ClientName.Length,0) || AbonementPrice == 0)
            {
                return false;
            }

            return true;
        }

        #endregion


    }
}
