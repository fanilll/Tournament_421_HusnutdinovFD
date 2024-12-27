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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            Users user = App.db.Users.FirstOrDefault(x => x.Email == LoginTb.Text && x.Password == PassTb.Password);


            if (user != null)
            {
                NavigationService.Navigate(new TournamentListPage());
                MessageBox.Show("Вы успешно вошли!");
            }
            else
                MessageBox.Show("Неверный пароль или логин!");
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
