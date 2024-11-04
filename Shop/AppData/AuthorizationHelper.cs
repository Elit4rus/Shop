using Shop.Model;
using System.Linq;
using System.Windows;

namespace Shop.AppData
{
    internal class AuthorizationHelper
    {
        public static Director currentDirector;
        public static bool CheckData(string email, string password)
        {
            currentDirector = App.context.Director.FirstOrDefault(d => d.Email == email && d.Password == password);
            if (currentDirector != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
                return false;
            }


        }
    }
}
