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

namespace pharmacy {
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void signupB_Click(object sender, RoutedEventArgs e) {

            var dbAuth = dbPharmacyEntities.getContext().dbAuth.ToList();

            foreach (var user in dbAuth) {
                if (tbLogin.Text == user.login) {
                    if (tbPass.Text == user.password) {
                        Window1 next = new Window1();
                        this.Close();
                        next.Show();
                    }
                    else errorPass.Visibility = Visibility.Visible;
                }
                else errorPass.Visibility = Visibility.Visible;
            }
        }
    }
}
