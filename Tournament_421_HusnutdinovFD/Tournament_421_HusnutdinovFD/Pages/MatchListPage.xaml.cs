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

namespace Tournament_421_HusnutdinovFD.Pages
{
    /// <summary>
    /// Логика взаимодействия для MatchListPage.xaml
    /// </summary>
    public partial class MatchListPage : Page
    {
        public MatchListPage()
        {
            InitializeComponent();
            MatchList.ItemsSource = App.db.Match.ToList();
        }

        private void RegistButt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
