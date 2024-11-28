using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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

namespace KTnaMare
{
    /// <summary>
    /// Логика взаимодействия для PhotoAndColor.xaml
    /// </summary>
    public partial class PhotoAndColor : Window
    {
        public PhotoAndColor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            gridchange.Background = new SolidColorBrush(Color.FromRgb((byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256)));
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            First.IsChecked = true;

            string imagePath = "C:/Users/Alexy/source/repos/KTnaMare/KTnaMare/images/1.jpeg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }

        private void Second_Checked(object sender, RoutedEventArgs e)
        {
            Second.IsChecked = true;

            string imagePath = "C:/Users/Alexy/source/repos/KTnaMare/KTnaMare/images/2.jpeg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }

        private void Third_Checked(object sender, RoutedEventArgs e)
        {
            Third.IsChecked = true;

            string imagePath = "C:/Users/Alexy/source/repos/KTnaMare/KTnaMare/images/3.jpeg";
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath));
            DisplayImage.Source = bitmap;
        }
    }
}
