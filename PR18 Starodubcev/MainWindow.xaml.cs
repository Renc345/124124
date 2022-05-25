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
using Metod;

namespace PR18_Starodubcev
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

        private void Button_Click(object sender, RoutedEventArgs t)
        {
            ms butt = new ms();
            double a = double.Parse(a1.Text);
            double b = double.Parse(b1.Text);
            double c = double.Parse(c1.Text);
            double d = double.Parse(d1.Text);
            double e = double.Parse(e1.Text);
            double f = double.Parse(f1.Text);
            double a3= butt.Calculate(a, b, c);
            double a4 = butt.Calculate(d, e, f);
            MessageBox.Show(butt.Srav(a3, a4).ToString());
        }
    }
}
