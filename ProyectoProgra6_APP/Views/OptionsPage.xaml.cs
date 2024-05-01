namespace ProyectoProgra6_APP.Views;

public partial class OptionsPage : ContentPage
{
	public OptionsPage()
	{
		InitializeComponent();
	}

    private async void Btn_RolesManngment_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RolesPage());
    }

    private async void Btn_Users_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserPage());
    }

    private async void Btn_Carbrands_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BrandPage());
    }

    private async void Btn_Categories_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriesPage());
    }

    private async void Btn_Carmodels_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ModelPage());
    }

    private async void Btn_Storebranches_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StorePage());
    }

    private async void Btn_Storevehicles_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VehiclePage());
    }

    private async void Btn_Exit_clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Btn_Orders_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BillsPage());
    }

    private async void Btn_Customer_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CustomersPage());
    }

    private async void Btn_Maintenance_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MaintenancePage());
    }

    private async void Btn_Ratings_clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RatingsPage());
    }
}