using GBUZhilishnikKuncevo.Classes;
using GBUZhilishnikKuncevo.Pages;
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

namespace GBUZhilishnikKuncevo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigation.frameNav = MainFrame;
            MainFrame.Navigate(new WelcomePage());
        }

        /// <summary>
        /// Переход на страницу с квартиросъемщиками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClientPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new ClientPage());
        }

        /// <summary>
        /// Переход на страницу с счётчиками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCounterPage_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new CounterPage());
        }

        private void BtnBankBookPage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
