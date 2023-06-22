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

namespace MihailovaApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class HelloWindow : Window
    {
        private List<Event> events = Mihailova_BlockCheinEntities.getContext().Event.ToList();
        public HelloWindow()
        {
            InitializeComponent();
            Events.ItemsSource = events;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            new Authorize().Show();
            Close();
        }
    }
}
