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
    /// Логика взаимодействия для ClientInfoPage.xaml
    /// </summary>
    public partial class ClientInfoPage : Page
    {
        public ClientInfoPage(Client client)
        {
            InitializeComponent();
            //Наполняем текстовые блоки информацией из БД
            TxbFullName.Text = client.surname.ToString() + " " + client.name.ToString() + " " + client.patronymic.ToString();
            TxbNumPassport.Text = client.Passport.passportNumber.ToString();
            TxbDateOfBirth.Text = client.dateOfBirth.ToShortDateString();
            TxbGender.Text = client.Gender.genderName.ToString();
            TxbPassportSeries.Text = client.Passport.passportSeries.ToString();
            TxbSNILS.Text = client.SNILS.snilsNumber.ToString();
            TxbTIN.Text = client.TIN.tinNumber.ToString();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.frameNav.GoBack();
        }
    }
}
