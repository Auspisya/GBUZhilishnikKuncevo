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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            //Обнуляем таблицу, затем добавляем в нее данные
            DataClient.ItemsSource = null;
            DataClient.ItemsSource = DBConnection.DBConnect.Client.ToList();
        }

        private void BtnShowInfo_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.Navigate(new ClientInfoPage((sender as Button).DataContext as Client));
        }
    }
}
