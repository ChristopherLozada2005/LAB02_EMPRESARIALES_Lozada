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
using System.Windows.Shapes;

namespace WpfLAB02_B
{
    /// <summary>
    /// Lógica de interacción para Reportes.xaml
    /// </summary>
    public partial class Reportes : Window
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnSalidas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnIngresos_Click(object sender, RoutedEventArgs e)
        {
            ReporteIngresos ventana = new ReporteIngresos();
            ventana.Show();
            this.Close();
        }

        private void btnCargas_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
