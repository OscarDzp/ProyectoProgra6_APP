namespace ProyectoProgra6_APP.Views;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
		InitializeComponent();
	}

    private async void Btn_cancel(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}