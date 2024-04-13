using ProyectoProgra6_APP.ViewModels;
using ProyectoProgra6_APP.Models;


namespace ProyectoProgra6_APP.Views;

public partial class UserSignUpPage : ContentPage
{
    UserViewModel? vm;


	public UserSignUpPage()
	{
		InitializeComponent();
        BindingContext = vm = new UserViewModel();

        LoadUserRoles();
	}

    private async void LoadUserRoles() 
    {
        CboxUserRole.ItemsSource = await vm.GetUserRolesAsync();

    } 

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {

    }
}