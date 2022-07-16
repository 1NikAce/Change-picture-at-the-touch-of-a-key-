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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Picture(1);
            Console.Beep(659, 300);
            Console.Beep(659, 300);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Picture(2);
            Console.Beep(300, 659);
            Console.Beep(300, 659);
        }
        void Picture(int name)
        {
            img_1.Visibility = Visibility.Collapsed;
            img_2.Visibility = Visibility.Collapsed;

            switch (name)
            {
                case 1: img_1.Visibility = Visibility.Visible; break;
                case 2: img_2.Visibility = Visibility.Visible; break;
                default:
                    break;
            }
        }
    }
}
