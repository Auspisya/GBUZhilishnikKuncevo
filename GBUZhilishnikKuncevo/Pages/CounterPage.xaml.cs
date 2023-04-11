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
    /// Логика взаимодействия для CounterPage.xaml
    /// </summary>
    public partial class CounterPage : Page
    {
        public CounterPage()
        {
            InitializeComponent();
            //Обнуляем таблицу, затем добавляем в нее данные
            DataCounter.ItemsSource = null;
            DataCounter.ItemsSource = DBConnection.DBConnect.Counter.ToList();
        }

        private void BtnShowInfo_Click(object sender, RoutedEventArgs e)
        {
            //В зависимости от выбранной строки, передаём её данные на следующую страницу и используем там
            Navigation.frameNav.Navigate(new CounterInfoPage((sender as Button).DataContext as Counter));
        }
    }
}
