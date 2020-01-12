﻿using OlibPasswordManager.Properties.Core;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace OlibPasswordManager.Pages
{
    /// <summary>
    /// Логика взаимодействия для PasswordInformation.xaml
    /// </summary>
    public partial class PasswordInformation : Page
    {
        public PasswordInformation() => InitializeComponent();

        #region CopyText
        private void CopyPassword(object sender, RoutedEventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtPassword.Password);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtNameAccount.Text);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtWebSite.Text);
        }
        #endregion

        private void CollapsedPassword(object sender, RoutedEventArgs e)
        {
            if ((bool)cbHide.IsChecked)
            {
                txtPassword.Visibility = Visibility.Collapsed;
                txtPasswordCollapsed.Text = txtPassword.Password;
                txtPasswordCollapsed.Visibility = Visibility.Visible;
            }
            else if (!(bool)cbHide.IsChecked)
            {
                txtPassword.Visibility = Visibility.Visible;
                txtPasswordCollapsed.Visibility = Visibility.Collapsed;
                txtPasswordCollapsed.Text = null;
            }
        }

        private void ChangedPassword(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Pages/ChangePassword.xaml", UriKind.Relative));

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            txtName.Text = User.UsersList[User.IndexUser].Name;
            txtNameAccount.Text = User.UsersList[User.IndexUser].PasswordName;
            txtPassword.Password = User.UsersList[User.IndexUser].Password;
            txtWebSite.Text = User.UsersList[User.IndexUser].WebSite;
            labelCreateData.Content = User.UsersList[User.IndexUser].TimeCreate;
            labelChangeData.Content = User.UsersList[User.IndexUser].TimeChanged;
            txtNote.Text = User.UsersList[User.IndexUser].Note;

            if (txtNote.Text == "") brNote.Visibility = Visibility.Collapsed;
            else brNote.Visibility = Visibility.Visible;
            if (txtWebSite.Text == "") brWebSite.Visibility = Visibility.Collapsed;
            else brWebSite.Visibility = Visibility.Visible;

            if (User.UsersList[User.IndexUser].TimeChanged == null) txtLabelChange.Visibility = Visibility.Collapsed;
            else txtLabelChange.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "http://" + txtWebSite.Text,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e) => pbHard.Value = PasswordUtils.CheckPasswordStrength(txtPassword.Password);

        private void pbHard_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (pbHard.Value < 100)
            {
                pbHard.Foreground = new SolidColorBrush(Color.FromRgb(235, 20, 0));
            }
            else if (pbHard.Value < 200)
            {
                pbHard.Foreground = new SolidColorBrush(Color.FromRgb(235, 235, 0));
            }
            else
            {
                pbHard.Foreground = new SolidColorBrush(Color.FromRgb(20, 235, 0));
            }
        }
    }
}