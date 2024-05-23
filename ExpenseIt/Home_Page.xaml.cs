using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
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

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for Home_Page.xaml
    /// </summary>
    public partial class Home_Page : Page
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem != null)
            {
                string Name = this.List.SelectedValue.ToString().Split().Last();
                Report_Page page = new Report_Page(Name);
                this.NavigationService.Navigate(page);
            }
            else
            {
                MessageBox.Show("U Should Select a name", "Error");
            }
        }
    }
}
