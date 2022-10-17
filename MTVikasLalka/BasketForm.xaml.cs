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
using System.Windows.Shapes;

namespace MTVikasLalka
{
    /// <summary>
    /// Interaction logic for BasketForm.xaml
    /// </summary>
    public partial class BasketForm : Window
    {
        List<BasketballPlayer> basketList = new List<BasketballPlayer>();
        public BasketForm(List<BasketballPlayer> hl)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.basketList = hl;

            foreach (BasketballPlayer hp in basketList)
            {
                listNames.Items.Add(hp.playerName);
            }
            BasketballPlayer last = new BasketballPlayer();
            last = basketList.Last();
            txtID.Text = (last.playerID + 1).ToString();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtTeam.Text = "";
            txtGamesPlayed.Text = "";
            txtFGoals.Text = "";
            txtTpoints.Text = "";
            txtPoints.Text = "";
            BasketballPlayer last = new BasketballPlayer();
            last = basketList.Last();
            txtID.Text = (last.playerID + 1).ToString();
        }

        private void listNames_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            String selectedName = listNames.SelectedItem.ToString();

            var player = from p in basketList
                         where p.playerName == selectedName
                         orderby p ascending
                         select p;

            foreach (BasketballPlayer p in player)
            {
                txtID.Text = p.playerID.ToString();
                txtName.Text = p.playerName;
                txtTeam.Text = p.playerTeam;
                txtGamesPlayed.Text = p.gamesPlayed.ToString();
                txtFGoals.Text = p.fieldGoals.ToString();
                txtTpoints.Text = p.threePointers.ToString();
                txtPoints.Text = p.points().ToString();
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            insetItem();
        }

        public void refreshform()
        {
            listNames.Items.Clear();
            //update iDs of players when a player is deleted.
            int newID = 1;
            foreach (BasketballPlayer hp in basketList)
            {
                hp.playerID = newID;
                newID++;
            }
            foreach (BasketballPlayer hp in basketList)
            {
                listNames.Items.Add(hp.playerName);
            }
            BasketballPlayer last = new BasketballPlayer();
            last = basketList.Last();
            txtID.Text = (last.playerID + 1).ToString();

            txtName.Text = "";
            txtTeam.Text = "";
            txtGamesPlayed.Text = "";
            txtFGoals.Text = "";
            txtTpoints.Text = "";
            txtPoints.Text = "";
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            updateItem();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            deleteItem();
        }
        public void deleteItem()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                basketList.RemoveAt(id - 1);
                MessageBox.Show("Player Deleted Successfully!!!");
                refreshform();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void updateItem()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                int gp = Convert.ToInt32(txtGamesPlayed.Text);
                int fg = Convert.ToInt32(txtFGoals.Text);
                int tp = Convert.ToInt32(txtTpoints.Text);

                BasketballPlayer temp = new BasketballPlayer(id, txtName.Text, txtTeam.Text, gp, fg, tp);
                basketList.RemoveAt(id - 1);
                basketList.Insert(id - 1, temp);

                MessageBox.Show("Player Updated Successfully!!!");

                refreshform();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insetItem()
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                int gp = Convert.ToInt32(txtGamesPlayed.Text);
                int fg = Convert.ToInt32(txtFGoals.Text);
                int tp = Convert.ToInt32(txtTpoints.Text);

                BasketballPlayer temp = new BasketballPlayer(id, txtName.Text, txtTeam.Text, gp, fg, tp);
                // HockeyPlayer temp = new HockeyPlayer(Convert.ToInt32(txtID.Text), txtName.Text, txtTeam.Text, Convert.ToInt32(txtGamesPlayed), Convert.ToInt32(txtAssists.Text), Convert.ToInt32(txtGoals.Text));
                 basketList.Add(temp);
                MessageBox.Show("Player Added Successfully!!!");
                refreshform();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void MenuItem_Update(object sender, RoutedEventArgs e)
        {
            updateItem();
        }

        private void MenuItem_About_Me(object sender, RoutedEventArgs e)
        {
            AboutMe ab1 = new AboutMe();
            ab1.ShowDialog();
        }

        private void MenuItem_Delete(object sender, RoutedEventArgs e)
        {
            deleteItem();
        }
        private void MenuItem_Insert(object sender, RoutedEventArgs e)
        {
            insetItem();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
