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

namespace Galeria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> list = new List<String>();
        public int Licznik { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            list.Add("rys1.jpg");
            list.Add("rys2.jpg");
            list.Add("rys3.jpg");
            list.Add("rys4.jpg");
            Licznik = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //dalej
            Licznik++;
            if(Licznik == list.Count)
            {
                Licznik = 0;
            }
            obrazImage.Source = new BitmapImage(new Uri(list[Licznik],UriKind.Relative));
        }
    }
}
