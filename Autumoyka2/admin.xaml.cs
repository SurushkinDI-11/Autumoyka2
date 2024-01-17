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
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        
        public admin()
        {
            InitializeComponent();
           
        }


        private void zak_Click(object sender, RoutedEventArgs e)
        {
            thirdWin.Content = new aktzak();
        }

        private void sot_Click(object sender, RoutedEventArgs e)
        {
            thirdWin.Content=new admsotr();
        }
    }
}
