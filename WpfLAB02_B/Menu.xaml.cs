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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btnOperaciones_Click(object sender, RoutedEventArgs e)
        {
            Operaciones ventana = new Operaciones();
            ventana.Show();
            this.Close();
        }

        private void btnMantenimientos_Click(object sender, RoutedEventArgs e)
        {
            Mantenimientos ventana = new Mantenimientos();
            ventana.Show();
            this.Close();
        }

        private void btnReportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes ventana = new Reportes();
            ventana.Show();
            this.Close();
        }
    }
}
