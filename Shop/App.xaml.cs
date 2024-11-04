using Shop.Model;
using System.Windows;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ShopEntities context = new ShopEntities();
    }
}
