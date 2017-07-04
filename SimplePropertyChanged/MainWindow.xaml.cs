using SimplePropertyChanged.ViewModels;
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

namespace SimplePropertyChanged
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel _main = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _main;
        }

        private void Red_Clicked(object sender, RoutedEventArgs e)
        {
            _main.SetBackground(Brushes.Maroon);
        }

        private void Blue_Clicked(object sender, RoutedEventArgs e)
        {
            _main.SetBackground(Brushes.SkyBlue);
        }
        private void Yellow_Clicked(object sender, RoutedEventArgs e)
        {
            _main.SetBackground(Brushes.Beige);
        }
    }
}
