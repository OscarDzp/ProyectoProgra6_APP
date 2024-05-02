namespace ProyectoProgra6_APP.Views;

public partial class StorePage : ContentPage
{
	public StorePage()
	{
		InitializeComponent();
	}

    private async void Btn_cancel(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}