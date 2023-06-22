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
    /// Логика взаимодействия для UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        public UsersWindow(Users user)
        {
            InitializeComponent();
            if (user.Role.Id == 1)
            {
                header.Text = "Окно участника";
            }
            else if (user.Role.Id == 2)
            {
                header.Text = "Окно организатора";
            }
            else if (user.Role.Id == 3)
            {
                header.Text = "Окно жюри";
            }
            else
            {
                header.Text = "Окно модератора";
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            new HelloWindow().Show();
            Close();
        }
    }
}
