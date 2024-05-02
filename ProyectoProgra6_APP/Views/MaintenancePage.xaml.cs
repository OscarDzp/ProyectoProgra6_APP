namespace ProyectoProgra6_APP.Views;

public partial class MaintenancePage : ContentPage
{
	public MaintenancePage()
	{
		InitializeComponent();
	}

    private async void Btn_cancel(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}