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
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista =
            new ObservableCollection<int>();
        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(21);
            miLista.Add(34);
            miLista.Add(76);
            miLista.Add(44);
            miLista.Add(2);
            miLista.Add(18);
            miLista.Add(56);
            miLista.Add(13);

            lstNumeros.ItemsSource = miLista;
        }

        private void LstOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /* var temp = miLista[0];

             miLista[0] = miLista[3];
            miLista[3] = temp; */

            int gap, temp, i, j;
            gap = miLista.Count / 2;

            while(gap > 0)
            {
                for(i=0; i<miLista.Count; i++)
                {
                    if (miLista[i] > miLista[gap + i])
                    {
                        temp = miLista[i];
                        miLista[i] = miLista[gap + i];
                        miLista[gap + i] = temp;
                    }
                }

                gap--;
            }
        }
    }
}
