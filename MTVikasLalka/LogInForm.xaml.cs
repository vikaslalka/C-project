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
    /// Interaction logic for LogInForm.xaml
    /// </summary>
    public partial class LogInForm : Window
    {
        IDictionary<String, LogIn> userDetails = new Dictionary<String, LogIn>();
        public LogInForm()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
             
            LogIn li1 = new LogIn(1, "admin", "123");
            LogIn li2 = new LogIn(1, "user1", "123");
            LogIn li3 = new LogIn(1, "user2", "123");
            userDetails.Add("admin", li1);
            userDetails.Add("user1", li2);
            userDetails.Add("user2", li3);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int found = 0;
            foreach (KeyValuePair<String, LogIn> log in userDetails)
            {
                if (txtUN.Text == log.Value.getUN() && txtPW.Text == log.Value.getPW())
                {
                    MainWindow mw1 = new MainWindow();
                    this.Close();
                    mw1.Show();
                    found = 1;
                    break;
                }

            }
            if(found==0)
                MessageBox.Show("Invalid username or password");
        }

    }

}
