using CourtInvitor.Models;
using CourtInvitor.ModelsLogic;
using System.Windows.Input;

namespace CourtInvitor.ViewModels
{
    internal partial class MainPageVM
    {
        private readonly User user = new();
        public ICommand RegisterCommand { get; }

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

        public MainPageVM()
        {
            RegisterCommand = new Command(Register, CanRegister);
        }
    }
}
