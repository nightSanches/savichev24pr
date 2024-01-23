using savichev24pr.Windows;
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

namespace savichev24pr.Pages
{
    /// <summary>
    /// Логика взаимодействия для Table_vedomost.xaml
    /// </summary>
    public partial class Table_vedomost : Page
    {
        public Table_vedomost()
        {
            InitializeComponent();
        }

        private void backClick(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).frame.Navigate(new Pages.All_Tables());
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Add_edit_vedomost taskWindow = new Add_edit_vedomost();
            if (taskWindow.ShowDialog() == true)
            {
            }
        }
    }
}
