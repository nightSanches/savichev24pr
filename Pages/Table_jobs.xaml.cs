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
    /// Логика взаимодействия для Table_jobs.xaml
    /// </summary>
    public partial class Table_jobs : Page
    {
        public Table_jobs()
        {
            InitializeComponent();
        }

        private void backClick(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).frame.Navigate(new Pages.All_Tables());
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Add_edit_jobs taskWindow = new Add_edit_jobs();
            if (taskWindow.ShowDialog() == true)
            {
            }
        }
    }
}
