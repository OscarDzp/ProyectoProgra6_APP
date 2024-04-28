namespace ProyectoProgra6_APP.Views;

public partial class InsurancePage : ContentPage
{
	public InsurancePage()
	{
		InitializeComponent();
	}

    private void BtnSolicitar_Clicked(object sender, EventArgs e)
    {

    }

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}