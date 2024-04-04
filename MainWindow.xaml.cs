using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace АвторизацияПрактикаКозулин
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class Authorization : Window
    {
        private bool isTogglingPasswordVisibility;

        public Authorization()
        {
            InitializeComponent();
            SetPlaceholders();
        }
        
        private void SetPlaceholders()
        {
            LoginTextBox.Text = (string)LoginTextBox.Tag;
            PasswordBox.Password = (string)PasswordBox.Tag;
        }
        private void RegisterTextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Registration registrationWindow = new Registration();
            registrationWindow.Show();
            this.Close();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            var loginOrEmail = LoginTextBox.Text;
            var password = PasswordBox.Password;

            if (PasswordTextBox.Visibility == Visibility.Visible)
            {
                password = PasswordTextBox.Text;
            }

            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(x => (x.Login == loginOrEmail || x.Email == loginOrEmail) && x.Password == password);

                if (user != null)
                {
                    Config.failedAttempts = 0;
                    Window1 window1 = new Window1(user.Login);
                    window1.Show();
                    this.Close();
                }
                else
                {
                    Config.failedAttempts++;
                    if (Config.failedAttempts >= 3)
                    {
                        BlockInputs();
                        MessageBox.Show("Превышено количество попыток входа. Повторите попытку через 15 секунд.");
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин/емайл или пароль. Пожалуйста, попробуйте еще раз.");
                    }
                }
            }
        }
        private void BlockInputs()
        {
            new Thread(() => {
                var start = DateTime.Now; var end = start.AddSeconds(15);
                while (true)
                {
                    var currentTime = DateTime.Now; if (currentTime >= end)
                        break;
                    Dispatcher.Invoke(() => {
                        LoginTextBox.IsEnabled = false; PasswordTextBox.IsEnabled = false;
                        PasswordBox.IsEnabled = false; EnterButton.IsEnabled = false;
                    });
                    Thread.Sleep(400);
                }
                Dispatcher.Invoke(() => {
                    LoginTextBox.IsEnabled = true; PasswordTextBox.IsEnabled = true;
                    PasswordBox.IsEnabled = true; EnterButton.IsEnabled = true;
                }); Config.failedAttempts = 0;
            }).Start();
        }

        private void TogglePasswordVisibility(PasswordBox passwordBox, TextBox passwordTextBox, Image eyeIcon)
        {
            isTogglingPasswordVisibility = true;

            if (passwordTextBox.Visibility == Visibility.Collapsed)
            {
                passwordTextBox.Text = passwordBox.Password;
                passwordTextBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Collapsed;
                eyeIcon.Source = new BitmapImage(new Uri("Resource/eye.png", UriKind.Relative));
            }
            else
            {
                passwordBox.Password = passwordTextBox.Text;
                passwordTextBox.Visibility = Visibility.Collapsed;
                passwordBox.Visibility = Visibility.Visible;
                eyeIcon.Source = new BitmapImage(new Uri("Resource/free-icon-eye-159604.png", UriKind.Relative));
            }
            isTogglingPasswordVisibility = false;
        }

        private void EyeIcon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TogglePasswordVisibility(PasswordBox, PasswordTextBox, (Image)sender);
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == (string)textBox.Tag)
            {
                textBox.Text = "";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = (string)textBox.Tag;
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (isTogglingPasswordVisibility)
                return;

            PasswordBox passwordBox = (PasswordBox)sender;
            if (passwordBox.Password == (string)passwordBox.Tag)
            {
                passwordBox.Password = "";
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (isTogglingPasswordVisibility)
                return;

            PasswordBox passwordBox = (PasswordBox)sender;
            if (string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                passwordBox.Password = (string)passwordBox.Tag;
            }
        }
    }
}
