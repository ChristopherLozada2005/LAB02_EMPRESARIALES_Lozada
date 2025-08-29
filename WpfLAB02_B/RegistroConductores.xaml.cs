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
    /// Lógica de interacción para RegistroConductores.xaml
    /// </summary>
    public partial class RegistroConductores : Window
    {
        // Lista para guardar los conductores en memoria
        private List<Conductor> conductores = new List<Conductor>();

        public RegistroConductores()
        {
            InitializeComponent();
            dgConductores.ItemsSource = conductores;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Conductor nuevo = new Conductor
            {
                Nombre = txtNombre.Text,
                Licencia = txtLicencia.Text,
                Transporte = txtTransporte.Text
            };

            conductores.Add(nuevo);

            dgConductores.ItemsSource = null;
            dgConductores.ItemsSource = conductores;

            txtNombre.Clear();
            txtLicencia.Clear();
            txtTransporte.Clear();
        }
    }

    public class Conductor
    {
        public required string Nombre { get; set; }
        public required string Licencia { get; set; }
        public required string Transporte { get; set; }
    }
}
