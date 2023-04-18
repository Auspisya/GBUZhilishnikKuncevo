﻿using GBUZhilishnikKuncevo.Classes;
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

        /// <summary>
        /// Переход на страницу с доп. информацией
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowInfo_Click(object sender, RoutedEventArgs e)
        {
            //В зависимости от выбранной строки, передаём её данные на следующую страницу и используем там
            Navigation.frameNav.Navigate(new CounterInfoPage((sender as Button).DataContext as Counter));
        }

        /// <summary>
        /// Поиск записи по номеру счётчика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxbSearch.Text != "")
                {
                    string searchString = TxbSearch.Text.ToLower();

                    var itemsList = DBConnection.DBConnect.Counter.ToList();

                    //Ищем совпадения в таблице по фамилии
                    var searchResults = itemsList.Where(item => item.counterNumber.ToLower().Contains(searchString)).ToList();

                    //Заполняем таблицу записями, где есть совпадения
                    DataCounter.ItemsSource = searchResults.ToList();
                }
                else
                {
                    DataCounter.ItemsSource = DBConnection.DBConnect.Client.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Непредвиденная ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Заполнение таблицы актуальными данными из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            DataCounter.ItemsSource = null;
            DataCounter.ItemsSource = DBConnection.DBConnect.Counter.ToList();
        }

        /// <summary>
        /// Убирает подсказку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            TxbSearch.Text = "";
        }
    }
}
