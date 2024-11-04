using Shop.AppData;
using System.Windows;

namespace Shop.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorizationHelper.CheckData(EmailTb.Text, PasswordPb.Password) == true)
            {
                Close();
                MainWindow mainWindow = new MainWindow();
            }
        }
    }
}
