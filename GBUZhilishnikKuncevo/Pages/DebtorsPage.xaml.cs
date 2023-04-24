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
    /// Логика взаимодействия для DebtorsPage.xaml
    /// </summary>
    public partial class DebtorsPage : Page
    {
        public DebtorsPage()
        {
            InitializeComponent();

            #region Костыль, выводящий должников

            DataDebtors.ItemsSource = null;
            var debtorsList = DBConnection.DBConnect.TotalCheck.ToList();
            var clientsList = DBConnection.DBConnect.Client.ToList();
            //Смотрим квитанции, которые оплачены несвоевременно
            var debtors = debtorsList.Where(item => item.PaymentState.paymentStateName.Contains("Оплачена несвоевременно")).ToList();
            //Сохраняем идентификаторы клиентов, которые оплатили несвоевременно
            var clientsId = debtors.Select(item => item.BankBook.clientId).ToList();

            List<Client> clientData = new List<Client>();

            for (int i = 0; i < clientsList.Count; i++)
            {
                for (int j = 0; j < clientsId.Count; j++)
                {
                    if (clientsList[i].id == clientsId[j])
                    {
                        clientData.Add(clientsList[i]);
                    }
                }
            }

            DataDebtors.ItemsSource = clientData.ToList();
            #endregion

            //var tCheckBankBook = DBConnection.DBConnect.TotalCheck.Select(x => x.BankBook).ToList();
            //var client = DBConnection.DBConnect.Client.ToList();
            //var data = tCheckBankBook.Join(client, p => p.)
        }
    }
}
