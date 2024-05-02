namespace ProyectoProgra6_APP.Views;

public partial class RolesPage : ContentPage
{
	public RolesPage()
	{
		InitializeComponent();
	}

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }

    private async void Btn_cancel(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}