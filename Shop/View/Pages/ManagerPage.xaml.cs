using Shop.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Shop.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        List<Manager> managers = App.context.Manager.ToList();
        public ManagerPage()
        {
            InitializeComponent();
            ManagerLv.ItemsSource = managers;
        }
    }
}
