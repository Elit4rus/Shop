using Shop.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Shop.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        List<Product> products = App.context.Product.ToList();
        List<Department> departments = App.context.Department.ToList();
        public ProductPage()
        {
            InitializeComponent();
            ProductLv.ItemsSource = products;
            departments.Insert(0, new Department() { Title = "Все отделы" });
            DepartmentCmb.ItemsSource = departments;
            DepartmentCmb.SelectedIndex = 0;
            ProductAmountTbl.Text = products.Sum(p => p.Amount).ToString();
            ProductPriceTbl.Text = products.Sum(p => p.Price * p.Amount).ToString();
        }

        private void DepartmentCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Department selectedDepartment = DepartmentCmb.SelectedItem as Department;
            if (DepartmentCmb.SelectedIndex == 0)
            {
                ProductLv.ItemsSource = products;
                ProductAmountTbl.Text = products.Sum(p => p.Amount).ToString();
                ProductPriceTbl.Text = products.Sum(p => p.Price * p.Amount).ToString();
            }
            else
            {
                ProductLv.ItemsSource = products.Where(p => p.DepartmentID == selectedDepartment.ID);
                ProductAmountTbl.Text = products.GroupBy(p => p.DepartmentID).Where(g => g.Key == selectedDepartment.ID).Select(group => new { DepartmentID = group.Key, TotalProducts = group.Sum(p => p.Amount) }).FirstOrDefault().TotalProducts.ToString();
                ProductPriceTbl.Text = products.GroupBy(p => p.DepartmentID).Where(g => g.Key == selectedDepartment.ID).Select(group => new { DepartmentID = group.Key, TotalPrice = group.Sum(p => p.Price * p.Amount) }).FirstOrDefault().TotalPrice.ToString();
            }
        }
    }
}
