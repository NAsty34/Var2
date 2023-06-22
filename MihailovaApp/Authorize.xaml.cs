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
using System.Windows.Shapes;

namespace MihailovaApp
{
    /// <summary>
    /// Логика взаимодействия для Authorize.xaml
    /// </summary>
    public partial class Authorize : Window
    {
        private List<Users> users = Mihailova_BlockCheinEntities.getContext().Users.ToList();
        public Authorize()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new HelloWindow().Show();
            Close();
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            var user = users.FirstOrDefault(a => a.Id == int.Parse(login.Text) && a.Password == password.Text);
            if (user == null)
            {
                MessageBox.Show("Некоректные данные","ErroeValidation");
            }
            else
            {
                new UsersWindow(user).Show();
                Close();
            }
        }
    }
}
