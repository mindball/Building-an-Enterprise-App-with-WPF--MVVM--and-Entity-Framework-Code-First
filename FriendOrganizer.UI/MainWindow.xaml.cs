using FriendOrganizer.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FriendOrganizer.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            DataContext = viewModel;
            Loaded += MainWindows_Loaded;
        }

        /* Loaded
            Loaded is probably more commonly used than Initialized. It is raised later in the 
            object's lifetime, before the control is rendered to the screen but after the 
            entire logical tree has been initialised. Although the controls have not been 
            displayed at the point of raising, all of the properties are calculated, 
            including those relating to positioning and layout. All of the values can be accessed
            safely. Standard data binding will be complete also, allowing you to interrogate 
            the bound data.
        */
        private async void MainWindows_Loaded(object sender, RoutedEventArgs e)
        {
            await this.viewModel.LoadAsync();
        }
    }
}
