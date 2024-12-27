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
    /// Логика взаимодействия для AddEditTournamentPage.xaml
    /// </summary>
    public partial class AddEditTournamentPage : Page
    {
        private Tournament tournament = new Tournament();
        public AddEditTournamentPage()
        {
            InitializeComponent();
            OrgCb.ItemsSource = App.db.Organizer.ToList();
        }

        private void CreateButt_Click(object sender, RoutedEventArgs e)
        {

            string mistake = "";

            if (NameTb.Text == "" && mistake == "")
                mistake = "Вы не заполнили название!";
            if (TypeTb.Text == "" && mistake == "")
                mistake = "Вы не заполнили тип!";
            if (DateDp.SelectedDate == null && mistake == "")
                mistake = "Вы не выбрали дату начала!";
            if (EndDateDp.SelectedDate == null && mistake == "")
                mistake = "Вы не выбрали дату окончания!";
            if (RegDateDp.SelectedDate == null && mistake == "")
                mistake = "Вы не выбрали дату регистрации!";
            if (OrgCb.SelectedIndex == -1 && mistake == "")
                mistake = "Вы не выбрали организатора!";
            if (mistake != "")
            {
                return;
            }
            tournament.Name = NameTb.Text;
            tournament.Type = TypeTb.Text;
            tournament.StartDate = DateDp.SelectedDate;
            tournament.EndDate = EndDateDp.SelectedDate;
            tournament.RegistrationDate = RegDateDp.SelectedDate;
            tournament.OrganizerID = 1;
            App.db.Tournament.Add(tournament);
            App.db.SaveChanges();
            NavigationService.Navigate(new TournamentListPage());
        }
    }
}
