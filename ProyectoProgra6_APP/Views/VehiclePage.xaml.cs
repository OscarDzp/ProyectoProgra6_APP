namespace ProyectoProgra6_APP.Views;

public partial class VehiclePage : ContentPage
{
	public VehiclePage()
	{
		InitializeComponent();
	}

    private async void Btn_cancel(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}