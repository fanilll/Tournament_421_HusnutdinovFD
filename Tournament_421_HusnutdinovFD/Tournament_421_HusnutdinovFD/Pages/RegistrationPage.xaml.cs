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
using Tournament_421_HusnutdinovFD.Components;

namespace Tournament_421_HusnutdinovFD.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        private RegistrationTournament registrationTournament = new RegistrationTournament();
        public RegistrationPage()
        {
            InitializeComponent();
            TourCb.ItemsSource = App.db.Tournament.ToList();
            TeamCb.ItemsSource = App.db.Team.ToList();
        }

        private void RegButt_Click(object sender, RoutedEventArgs e)
        {
            string mistake = "";

            if (TourCb.SelectedIndex == -1 && mistake == "")
                mistake = "Вы не выбрали организатора!";
            if (TeamCb.SelectedIndex == -1 && mistake == "")
                mistake = "Вы не выбрали организатора!";
            if (mistake != "")
            {
                return;
            }
            registrationTournament.TournamentID = TourCb.SelectedIndex + 1;
            registrationTournament.TeamID = TeamCb.SelectedIndex + 1;
            registrationTournament.Status = "На рассмотрении";
            App.db.RegistrationTournament.Add(registrationTournament);
            App.db.SaveChanges();
            MessageBox.Show("Вы успешно подали заявку на участие!!");
            NavigationService.Navigate(new MatchListPage());
        }
    }
}
