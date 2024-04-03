using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace АвторизацияПрактикаКозулин
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private bool isTogglingPasswordVisibility;
        public Registration()
        {
            InitializeComponent();
            SetPlaceholders();
        }

        private void SetPlaceholders()
        {
            LoginTextBox.Text = (string)LoginTextBox.Tag;
            EmailTextBox.Text = (string)EmailTextBox.Tag;
            PasswordBox.Password = (string)PasswordBox.Tag;
            ConfirmPasswordBox.Password = (string)ConfirmPasswordBox.Tag;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorizationWindow = new Authorization();
            authorizationWindow.Show();
            this.Close();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginTextBox.Text;

            var email = EmailTextBox.Text;

            var pass = PasswordBox.Password;

            var confirmPassword = ConfirmPasswordBox.Password;

            bool isValid = true;

            // Проверка правильности вписания почты
            if (!IsValidEmail(email))
            {
                SetErrorStyle(EmailTextBox);
                isValid = false;
            }
            else
            {
                SetNormalStyle(EmailTextBox);
            }

            // Проверка длины пароля
            if (pass.Length < 6)
            {
                SetErrorStyle(PasswordBox);
                isValid = false;
            }
            else
            {
                SetNormalStyle(PasswordBox);
            }

            // Проверка наличия спец. символов в пароле
            if (!HasSpecialCharacters(pass))
            {
                SetErrorStyle(PasswordBox);
                isValid = false;
            }
            else
            {
                SetNormalStyle(PasswordBox);
            }

            // Проверка совпадения паролей
            if (pass != confirmPassword)
            {
                SetErrorStyle(ConfirmPasswordBox);
                isValid = false;
            }
            else
            {
                SetNormalStyle(ConfirmPasswordBox);
            }

            if (!isValid)
            {
                return;
            }

            var context = new AppDbContext();

            var user_exists = context.Users.FirstOrDefault(x => x.Login == login);
            if (user_exists is not null)
            {
                MessageBox.Show("Такой пользователь уже существует.");
                return;
            }

            var email_exists = context.Users.FirstOrDefault(x => x.Email == email);
            if (email_exists is not null)
            {
                MessageBox.Show("Такая почта уже существует.");
                return;
            }

            var user = new User { Login = login, Password = pass, Email = email };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрировались!");

            Authorization authorizationWindow = new Authorization();
            authorizationWindow.Show();
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            // Проверка правильности вписания почты
            return email.Contains("@") && email.LastIndexOf(".") > email.IndexOf("@");
        }

        private bool HasSpecialCharacters(string password)
        {
            // Проверка наличия спец. символов в пароле
            string specialCharacters = "!@#$%^&*()_+";
            return password.Any(c => specialCharacters.Contains(c));
        }

        private void SetErrorStyle(Control control)
        {
            var border = control.Parent as Border;
            if (border != null)
            {
                border.Style = (Style)FindResource("ErrorBorderStyle");
            }
        }

        private void SetNormalStyle(Control control)
        {
            var border = control.Parent as Border;
            if (border != null)
            {
                border.Style = (Style)FindResource("NormalBorderStyle");
            }
        }

        private void EyeIcon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TogglePasswordVisibility(PasswordBox, PasswordTextBox, (Image)sender);
        }

        private void EyeIcon_MouseLeftButtonUp2(object sender, MouseButtonEventArgs e)
        {
            TogglePasswordVisibility(ConfirmPasswordBox, ConfirmPasswordTextBox, (Image)sender);
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
