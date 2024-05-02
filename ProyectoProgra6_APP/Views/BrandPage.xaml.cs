namespace ProyectoProgra6_APP.Views;

public partial class BrandPage : ContentPage
{
	public BrandPage()
	{
		InitializeComponent();
	}

    private void BtnCancel_Clicked(object sender, EventArgs e)
    {

    }

    private async void Btn_cancel(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}