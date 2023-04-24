using GBUZhilishnikKuncevo.Classes;
using GBUZhilishnikKuncevo.Models;
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
    /// Логика взаимодействия для AccountingPage.xaml
    /// </summary>
    public partial class AccountingPage : Page
    {
        public AccountingPage()
        {
            InitializeComponent();
            //Наполняем таблицу
            DataAccounting.ItemsSource = null;
            DataAccounting.ItemsSource = DBConnection.DBConnect.Accounting.ToList();
        }

        private void TxbSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbSearch.Text = "";
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxbSearch.Text != "")
                {
                    string searchString = TxbSearch.Text;

                    var counterList = DBConnection.DBConnect.Counter.ToList();
                    var itemsList = DBConnection.DBConnect.Accounting.ToList();

                    var searchResults = itemsList.Where(item => item.BankBook.bankBookNumber.Contains(searchString)).ToList();
                    DataAccounting.ItemsSource = searchResults.ToList();
                }
                else
                {
                    DataAccounting.ItemsSource = DBConnection.DBConnect.Accounting.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            DataAccounting.ItemsSource = null;
            DataAccounting.ItemsSource = DBConnection.DBConnect.Accounting.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new AccountingAddPage());
        }

        private void BtnEditInfo_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new AccountingEditPage((sender as Button).DataContext as Accounting));
        }
    }
}
