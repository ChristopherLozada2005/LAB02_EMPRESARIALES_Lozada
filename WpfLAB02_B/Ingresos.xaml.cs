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
    /// Lógica de interacción para Ingresos.xaml
    /// </summary>
    public partial class Ingresos : Window
    {
        public Ingresos()
        {
            InitializeComponent();
        }
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos guardados correctamente");

            Operaciones ventanaOperaciones = new Operaciones();
            ventanaOperaciones.Show();
            this.Close();
        }
    }
}
