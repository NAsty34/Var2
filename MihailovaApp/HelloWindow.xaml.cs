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
            List<string> itemCombo = new List<string>
            {
                "Сортировки нет",
                "Сначала старые",
                "Сначала новые"
            };
            Sort.ItemsSource = itemCombo;
            Sort.SelectedIndex = 0;
            Events.ItemsSource = events;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            new Authorize().Show();
            Close();
        }

        private void Sortdate_Change(object sender, SelectionChangedEventArgs e)
        {
            if (Sort.SelectedIndex == 1)
            {
                Events.ItemsSource = events.OrderBy(a=>a.Date);
            }
            else if (Sort.SelectedIndex == 2)
            {
                Events.ItemsSource = events.OrderByDescending(a => a.Date);
            }
            else
            {
                Events.ItemsSource = events;
            }
        }
    }
}
