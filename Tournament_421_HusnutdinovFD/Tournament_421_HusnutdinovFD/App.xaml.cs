using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tournament_421_HusnutdinovFD.Components;

namespace Tournament_421_HusnutdinovFD
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TournamentDB_421_HusnutdinovFDEntities db = new TournamentDB_421_HusnutdinovFDEntities();
    }
}
