using Shop.AppData;
using Shop.View.Windows;
using System.Windows;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameHelper.mainFrame = MainFrame;
            NameTbl.Text = AuthorizationHelper.currentDirector.Name + " " + AuthorizationHelper.currentDirector.Patronymic;
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.Pages.ProductPage());
        }

        private void ManagerBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new View.Pages.ManagerPage());
        }

        private void OutBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            Close();
        }
    }
}
