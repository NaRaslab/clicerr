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

namespace Dota2_clicker
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public double gold;

        Random GetGold = new Random();
        public int MinCreepIncome = 10;
        public int MaxCreepIncome = 15;


        public double CreepHP = 10;
        public double CreepMaxHP = 10;


        public double ClickDamage = 1;

        public double SaveGold;
        public MainPage()
        {
            InitializeComponent();
            hp_creep.Content = $"Хп крипа {CreepHP}";
            goldLabel.Content = $"Gold: {gold}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreepHP = CreepHP - ClickDamage;
            if (CreepHP <= 0)
            {
                CreepHP = CreepMaxHP;
                gold = gold + GetGold.Next(MinCreepIncome, MaxCreepIncome) + CreepMaxHP;

            }
            goldLabel.Content = $"Gold: {gold}";
            hp_creep.Content = $"Хп крипа: {CreepHP}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Shop());
            SaveGold = gold;
        }
    }
}
