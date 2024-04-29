namespace ProyectoProgra6_APP.Views;

public partial class FinancePage : ContentPage
{
	public FinancePage()
	{
		InitializeComponent();
	}

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void BtnSolFin_Clicked(object sender, EventArgs e)
    {

    }
}