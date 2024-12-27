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
    /// Логика взаимодействия для TournamentListPage.xaml
    /// </summary>
    public partial class TournamentListPage : Page
    {
        public TournamentListPage()
        {
            InitializeComponent();
            TournamentList.ItemsSource = App.db.Tournament.ToList();
        }

        private void AddButt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditTournamentPage());
        }

        private void EditButt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
