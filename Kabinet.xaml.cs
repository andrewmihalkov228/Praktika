using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Kabinet : Window
    {
        private string _userLogin;
        private AppDbContext _context;

        public Kabinet(string userLogin)
        {
            InitializeComponent();
            _userLogin = userLogin;
            _context = new AppDbContext();
            LoadUserData();
        }

        private void LoadUserData()
        {
            User user = _context.Users.FirstOrDefault(x => x.Login == _userLogin);
            if (user != null)
            {
                EmailTextBox.Text = user.Email;
            }
        }

        private async void ChangeEmailButton_Click(object sender, RoutedEventArgs e)
        {
            string newEmail = EmailTextBox.Text;
            User user = _context.Users.FirstOrDefault(x => x.Login == _userLogin);
            if (user != null)
            {
                user.Email = newEmail;
                await _context.SaveChangesAsync();
                MessageBox.Show("Email успешно изменен!");
            }
        }

        private async void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            string newPassword = PasswordBox.Password;
            User user = _context.Users.FirstOrDefault(x => x.Login == _userLogin);
            if (user != null)
            {
                user.Password = newPassword;
                await _context.SaveChangesAsync();
                MessageBox.Show("Пароль успешно изменен!");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(_userLogin);
            window1.Show();
            this.Close();
        }
    }
}
