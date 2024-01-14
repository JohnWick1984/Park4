using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
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
using Park4.Properties;


namespace Park4
{
    public partial class MainWindow : Window
    {
        private string currentCulture = "ru";
        public MainWindow()
        {

            InitializeComponent();
            UpdateUI();
        }
        private void PolishButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateLocalization();
            UpdateUI();
        }

        private void EnglishButton_Click(object sender, RoutedEventArgs e)
        {

            UpdateLocalization1();
            UpdateUI();
        }
        private void UpdateLocalization1()
        {
            if (currentCulture == "ru")
                currentCulture = "en";
            else
                currentCulture = "ru";

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentCulture);
        }
        private void UpdateLocalization()
        {
            if (currentCulture == "ru")
                currentCulture = "pl";
            else
                currentCulture = "ru";

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentCulture);
        }
        private void UpdateUI()
        {
            MainButton.Content = Strings.Main;
            ServicesButton.Content = Strings.Services;
            ExcursionButton.Content = Strings.Excursions;
            HistoryButton.Content = Strings.History;
            NewsButton.Content = Strings.News;
            ContactsButton.Content = Strings.Contacts;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateUI();
        }


    }
}

