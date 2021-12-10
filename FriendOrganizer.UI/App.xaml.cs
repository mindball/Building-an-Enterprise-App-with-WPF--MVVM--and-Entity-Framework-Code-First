using Catel.IoC;
using FriendOrganizer.DataAccess;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.ViewModel;
using System.Configuration;
using System.Windows;

namespace FriendOrganizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var serviceLocator = ServiceLocator.Default;
            serviceLocator.RegisterType<FriendOrganizerDbContext>(RegistrationType.Transient);

            serviceLocator.RegisterType<MainViewModel>();
            serviceLocator.RegisterType<MainWindow>();

            serviceLocator.RegisterType<IFriendDataService, FriendDataService>();

            //serviceLocator.RegisterInstance<IFriendDataService>(new FriendDataService(serviceLocator.ResolveType<FriendOrganizerDbContext>()));

            serviceLocator.ResolveType<MainWindow>().Show();
        }
    }
}
