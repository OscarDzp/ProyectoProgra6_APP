namespace ProyectoProgra6_APP.Views;

public partial class ModelPage : ContentPage
{
	public ModelPage()
	{
		InitializeComponent();
	}

    private async void Btn_cancel(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}