namespace ProyectoProgra6_APP.Views;

public partial class RatingsPage : ContentPage
{
	public RatingsPage()
	{
		InitializeComponent();
	}

    private async void Btn_cancel(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}