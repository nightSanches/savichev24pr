﻿using System;
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
    /// Логика взаимодействия для log_in.xaml
    /// </summary>
    public partial class log_in : Page
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void bth_log_in(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).frame.Navigate(new Pages.All_Tables());
        }
    }
}
