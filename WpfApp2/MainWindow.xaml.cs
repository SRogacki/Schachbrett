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

namespace Schachspiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           const int anzahlZellenBreit = 8;
           const int anzahlZellenHoch = 8;

            for (int y = 0; y < anzahlZellenHoch; y++)
            {
                for (int x = 0; x < anzahlZellenBreit; x++)
                {
                    Rectangle r = new Rectangle();
                    r.Width = zeichenfläche.ActualWidth / anzahlZellenBreit;
                    r.Height = zeichenfläche.ActualHeight / anzahlZellenHoch;
                    
                    if (y % 2 == 1 && x % 2 ==1)
                    {
                        r.Fill = Brushes.Black;
                    }
                    else if (y % 2 == 1 && x % 2 == 0)
                    {
                        r.Fill = Brushes.Red;
                    }
                    else if (y % 2 == 0 && x % 2 == 1)
                    {
                        r.Fill = Brushes.Red;
                    }
                    else if (y % 2 == 0 && x % 2 == 0)
                    {
                        r.Fill = Brushes.Black;
                    }
                    
                    zeichenfläche.Children.Add(r);
                    Canvas.SetLeft(r, x * r.Width);
                    Canvas.SetTop(r, y * r.Height);
                }
            }
        }
    }
}
