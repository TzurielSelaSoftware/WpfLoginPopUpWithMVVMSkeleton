using System.Windows.Input;
using WpfLoginPopUpWithMVVMSkeleton.Commands;
namespace WpfLoginPopUpWithMVVMSkeleton.ViewModels
{
    class MainViewModel:BaseViewModel
    {
        private string afterLoginButtonsStatus;
        public string AfterLoginButtonsStatus
        {
            get { return afterLoginButtonsStatus; }
            set
            {
                afterLoginButtonsStatus = value;
                OnPropertyChanged(nameof(AfterLoginButtonsStatus));
            }
        }
        private string signButViso;
        public string SignButViso
        {
            get { return signButViso; }
            set
            {
                signButViso = value;
                OnPropertyChanged(nameof(SignButViso));
            }
        }
        private bool popupStatus;
        public bool PopupStatus
        {
            get { return popupStatus; }
            set
            {
                popupStatus = value;
                OnPropertyChanged(nameof(PopupStatus));
            }
        }
        public MainViewModel()
        {
            PopupStatus = false;
            AfterLoginButtonsStatus = "Hidden";
        }
        public ICommand LoginCommand => new DelegateCommand(OpenPopUp);
        public ICommand signCommand => new DelegateCommand(ClosePopUp);
        private void OpenPopUp()
        {
            PopupStatus = true;
            SignButViso = "Hidden";
        }
        private void ClosePopUp()
        {
            PopupStatus = false;
            AfterLoginButtonsStatus = "Visible";
        }
    }
}
