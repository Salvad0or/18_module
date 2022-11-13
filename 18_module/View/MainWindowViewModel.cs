using _18_module.Infrasrtucture;
using _18_module.Services;
using _18_module.Services.SaverData;
using System.Windows.Input;

namespace _18_module.View
{

    /// <summary>
    /// Основной рабочий класс
    /// </summary>
    internal class MainWindowViewModel : ViewModel
    {

        #region Private-свойства

        private string _clientName;
        private decimal _abonementPrice;

        private string _fileName;

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

        #region Свойства второго окна

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                OnProperyChanged();
            }
        }

        public MainSaiver Saver { get; set; }


        #endregion

        #region Команды 

        #region Команды первого окна

        public ICommand SimpleAbonementCommand { get; set; }
        public ICommand WithPollAbonementCommand { get; set; }
        public ICommand WithTrainerAbonementCommand { get; set; }

        public void OnBaseCommandExecute(object p)
            =>
            GetFactory.ReturnFactoryClass("base", AbonementPrice, ClientName);

        public void OnWithPollCommandExecute(object p)
             =>
            GetFactory.ReturnFactoryClass("pool", AbonementPrice, ClientName);

        public void OnWithTrainerlCommandExecute(object p)
            =>
            GetFactory.ReturnFactoryClass("trainer", AbonementPrice, ClientName);

        public bool CanCommanExecuted(object p)
            =>
            !(Equals(ClientName.Length, 0) || AbonementPrice == 0);

        #endregion

        #region Команды второго окна

        public ICommand TxtSaverCommand { get; set; }
        public ICommand PdfSaverCommand { get; set; }
        public ICommand XlsxSaverCommand { get; set; }

        public void OnTxtSaverCommandExecuted(object p)
            =>
            Saver = new MainSaiver(new SaveInTxt(FileName));

        public void OnPdfSaverCommandExecuted(object p)
            =>
            Saver = new MainSaiver(new SaveInPdf(FileName));

        public void OnXlxsSaverCommandExecuted(object p)
            =>
            Saver = new MainSaiver(new SaveInXlx(FileName));

        public bool CanSaverCommandExecuted(object p)
            => FileName.Length != 0;


        #endregion



        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            SimpleAbonementCommand = new LamdaCommand(OnBaseCommandExecute, CanCommanExecuted);
            WithPollAbonementCommand = new LamdaCommand(OnWithPollCommandExecute, CanCommanExecuted);
            WithTrainerAbonementCommand = new LamdaCommand(OnWithTrainerlCommandExecute, CanCommanExecuted);

            ///

            TxtSaverCommand = new LamdaCommand(OnTxtSaverCommandExecuted, CanSaverCommandExecuted);
            PdfSaverCommand = new LamdaCommand(OnPdfSaverCommandExecuted, CanSaverCommandExecuted);
            XlsxSaverCommand = new LamdaCommand(OnXlxsSaverCommandExecuted, CanSaverCommandExecuted);


            #endregion

            #region Свойства

            ClientName = string.Empty;
            FileName = string.Empty;

            #endregion
        }
    }
}
