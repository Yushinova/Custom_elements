using Custom_elements.Model;
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
using System.ComponentModel;

namespace Custom_elements
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>
            {
                new User ("Tanya", "Russia", 39, "kercker111@mail.ru"),
                new User ("Vasya", "Canada", 40, "vasya1984@mail.ru"),
                new User ("Olya", "China", 18, "olya@mail.ru"),
                new User ("Kolya", "Poland", 20, "kolya@mail.ru")
            };
            MyListView.ItemsSource = users;
           
        }

        private void Click_Sort(object sender, RoutedEventArgs e)//сортировка по возрасту
        {
            MyListView.Items.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
        }
    }
}
