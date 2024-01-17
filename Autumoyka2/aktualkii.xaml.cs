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
    /// Логика взаимодействия для aktualkii.xaml
    /// </summary>
    public partial class aktualkii : Page
    {
        Frame mainWin;
        public aktualkii(Frame mainWin)
        {
            InitializeComponent();
            this.mainWin = mainWin;
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
