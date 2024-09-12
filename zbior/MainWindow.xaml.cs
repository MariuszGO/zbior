using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zbior
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            wynik.Text = " ";
            Int32 licz_a, licz_b,tmp;

            if (Int32.TryParse(liczba_a.Text, out licz_a) && Int32.TryParse(liczba_b.Text, out licz_b))
            {
                if (licz_a > licz_b)
                {
                    tmp = licz_a;
                    licz_a = licz_b;
                    licz_b = tmp;
                }

                    for (int i = licz_a; i <= licz_b; i++)
                {
                    wynik.Text= wynik.Text+ i.ToString() + " ";

                }

            }
            else
            {
                MessageBox.Show("Podałeś tekst zamiast liczb", "Błąd");
            }
        }
    }
}