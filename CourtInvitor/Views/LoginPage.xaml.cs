using CourtInvitor.ViewModels;

namespace CourtInvitor.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        BindingContext = new LogInVM();
    }
}