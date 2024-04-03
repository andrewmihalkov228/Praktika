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

namespace АвторизацияПрактикаКозулин
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string UserLogin { get; set; }

        public Window1(string userLogin)
        {
            InitializeComponent();
            UserLogin = userLogin;
            DataContext = this;
        }

        private void KabinetButton_Click(object sender, RoutedEventArgs e)
        {
            Kabinet kabinetWindow = new Kabinet(UserLogin);
            kabinetWindow.Show();
            this.Close();
        }
    }
}
