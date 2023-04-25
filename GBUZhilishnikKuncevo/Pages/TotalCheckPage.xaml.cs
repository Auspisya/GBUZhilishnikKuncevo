using GBUZhilishnikKuncevo.Classes;
using GBUZhilishnikKuncevo.Pages.Resources;
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

namespace GBUZhilishnikKuncevo.Pages
{
    /// <summary>
    /// Логика взаимодействия для TotalCheckPage.xaml
    /// </summary>
    public partial class TotalCheckPage : Page
    {
        public TotalCheckPage()
        {
            InitializeComponent();

            DataTotalCheck.ItemsSource = null;
            DataTotalCheck.ItemsSource = DBConnection.DBConnect.TotalCheck.ToList();
        }

        private void TxbSearch_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Переадресация на форму добавления чека в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddTotalCheck_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new TotalCheckAddPage());
        }
    }
}
