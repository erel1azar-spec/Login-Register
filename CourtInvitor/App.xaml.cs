using CourtInvitor.ModelsLogic;
using CourtInvitor.Views;

namespace CourtInvitor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            User user = new();
            Page page = user.IsRegistered ? new LoginPage() : new AppShell();
            MainPage = page;
        }
    }
}
