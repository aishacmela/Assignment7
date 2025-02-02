namespace Assignment7.View;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
		


	}

	private async void OnSignInButtonClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("HomePage");
	}
}