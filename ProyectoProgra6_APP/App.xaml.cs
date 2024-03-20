using ProyectoProgra6_APP.Views;

namespace ProyectoProgra6_APP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
