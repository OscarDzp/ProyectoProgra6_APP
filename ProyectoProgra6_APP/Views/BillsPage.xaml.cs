namespace ProyectoProgra6_APP.Views;

public partial class BillsPage : ContentPage
{
	public BillsPage()
	{
		InitializeComponent();
	}

    private async void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Financiamientos_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FinancePage());
    }

    private async void Seguros_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InsurancePage());
    }
}