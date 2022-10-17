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

namespace MTVikasLalka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<HockeyPlayer> hockeyList = new List<HockeyPlayer>();
        List<BasketballPlayer> basketBallList = new List<BasketballPlayer>();
        List<BaseballPlayer> baseBallList = new List<BaseballPlayer>();
        public MainWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            //adding hockey players
            HockeyPlayer h1 = new HockeyPlayer(1, "Hockey Player 01", "abc", 20, 12, 22);
            HockeyPlayer h2 = new HockeyPlayer(2, "Hockey Player 02", "bcd", 20, 12, 22);
            HockeyPlayer h3 = new HockeyPlayer(3, "Hockey Player 03", "def", 20, 12, 22);
            HockeyPlayer h4 = new HockeyPlayer(4, "Hockey Player 04", "xyz", 20, 12, 22);
            HockeyPlayer h5 = new HockeyPlayer(5, "Hockey Player 05", "rst", 20, 12, 22);
            hockeyList.Add(h1);
            hockeyList.Add(h2);
            hockeyList.Add(h3);
            hockeyList.Add(h4);
            hockeyList.Add(h5);

            //adding basketball players
            BasketballPlayer b1 = new BasketballPlayer(1, "Basketball P1", "abc", 20, 12, 22);
            BasketballPlayer b2 = new BasketballPlayer(2, "Basketball P2", "abc", 20, 12, 22);
            BasketballPlayer b3 = new BasketballPlayer(3, "Basketball P3", "abc", 20, 12, 22);
            BasketballPlayer b4 = new BasketballPlayer(4, "Basketball P4", "abc", 20, 12, 22);
            BasketballPlayer b5 = new BasketballPlayer(5, "Basketball P5", "abc", 20, 12, 22);
            basketBallList.Add(b1);
            basketBallList.Add(b2);
            basketBallList.Add(b3);
            basketBallList.Add(b4);
            basketBallList.Add(b5);

            //adding baseball players
            BaseballPlayer bb1 = new BaseballPlayer(1, "Baseball P1", "abc", 20, 12, 22);
            BaseballPlayer bb2 = new BaseballPlayer(2, "Baseball P2", "abc", 20, 12, 22);
            BaseballPlayer bb3 = new BaseballPlayer(3, "Baseball P3", "abc", 20, 12, 22);
            BaseballPlayer bb4 = new BaseballPlayer(4, "Baseball P4", "abc", 20, 12, 22);
            BaseballPlayer bb5 = new BaseballPlayer(5, "Baseball P5", "abc", 20, 12, 22);
            baseBallList.Add(bb1);
            baseBallList.Add(bb2);
            baseBallList.Add(bb3);
            baseBallList.Add(bb4);
            baseBallList.Add(bb5);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            HockyForm hpf = new HockyForm(hockeyList);
            hpf.ShowDialog();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            AboutMe ab1 = new AboutMe();
            ab1.ShowDialog();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            BasketForm bbpf = new BasketForm(basketBallList);
            bbpf.ShowDialog();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            BaseForm bbpf2 = new BaseForm(baseBallList);
            bbpf2.ShowDialog();


        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            HockyForm hpf = new HockyForm(hockeyList);
            hpf.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            BasketForm bbpf = new BasketForm(basketBallList);
            bbpf.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            BaseForm bbpf2 = new BaseForm(baseBallList);
            bbpf2.ShowDialog();

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
