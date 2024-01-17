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

namespace Autumoyka2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aktual_Click(object sender, RoutedEventArgs e)
        {
            mainWin.Content = new aktualkii(mainWin);
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            mainWin.Content = new vhod(mainWin);
        }
    }
}
