using CourtInvitor.Models;
using CourtInvitor.ModelsLogic;
using System.Windows.Input;

namespace CourtInvitor.ViewModels
{
    internal partial class MainPageVM:ObservableObject
    {
        private readonly User user = new();
        public ICommand RegisterCommand { get; }
        public ICommand LoginCommand { get; }
        public ICommand ToggleIsPasswordCommand { get; }
        public bool IsBusy { get; set; } = false;
        public bool IsPassword { get; set; } = true;

        public string UserName
        {
            get => user.UserName;
            set
            {
                user.UserName = value;
                (LoginCommand as Command)?.ChangeCanExecute();
            }
        }
        public string Password
        {
            get => user.Password;
            set
            {
                user.Password = value;
                (LoginCommand as Command)?.ChangeCanExecute();
            }
        }

        public bool CanRegister()
        {
            return !string.IsNullOrWhiteSpace(user.Name);
        }

        private void Register()
        {
            user.Register();
        }

        public string Name
        {
            get => user.Name;
            set
            {
                user.Name = value;
                (RegisterCommand as Command)?.ChangeCanExecute();
            }
        }
        public string Email
        {
            get => user.Email;
            set
            {
                 user.Email = value;
                (RegisterCommand as Command)?.ChangeCanExecute();
            }
        }
        public string Pass
        {
            get => user.Pass;
            set
            {
                user.Pass = value;
                (RegisterCommand as Command)?.ChangeCanExecute();
            }
        }
        private void ToggleIsPassword()
        {
            IsPassword = !IsPassword;
            OnPropertyChanged(nameof(IsPassword));
        }

        private async Task Login()
        {
            IsBusy = true;
            OnPropertyChanged(nameof(IsBusy));
            await Task.Delay(5000);
            IsBusy = false;
            OnPropertyChanged(nameof(IsBusy));
        }

        private bool CanLogin()
        {
            return (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password));
        }
        public MainPageVM()
        {
            RegisterCommand = new Command(Register, CanRegister);
            LoginCommand = new Command(async () => await Login(), CanLogin);
            ToggleIsPasswordCommand = new Command(ToggleIsPassword);
        }
    }
}
