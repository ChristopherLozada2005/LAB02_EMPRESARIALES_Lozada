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
    /// Lógica de interacción para ReporteIngresos.xaml
    /// </summary>
    public partial class ReporteIngresos : Window
    {
        private List<Ingreso> ingresos = new List<Ingreso>();

        public ReporteIngresos()
        {
            InitializeComponent();
            dgIngresos.ItemsSource = ingresos;
        }

        // Guardar nuevo ingreso
        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Ingreso nuevo = new Ingreso
            {
                Fecha = dpFecha.SelectedDate ?? DateTime.Now,
                Placa = txtPlaca.Text,
                Turno = txtTurno.Text,
                Conductor = txtConductor.Text,
                Producto = txtProducto.Text,
                Peso = txtPeso.Text,
                Transporte = txtTransporte.Text
            };

            ingresos.Add(nuevo);

            dgIngresos.ItemsSource = null;
            dgIngresos.ItemsSource = ingresos;

            // limpiar campos
            dpFecha.SelectedDate = null;
            txtPlaca.Clear();
            txtTurno.Clear();
            txtConductor.Clear();
            txtProducto.Clear();
            txtPeso.Clear();
            txtTransporte.Clear();
        }

        // Buscar con filtros
        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            var filtrados = ingresos.AsEnumerable();

            // Filtro de fechas
            if (dpFechaInicio.SelectedDate.HasValue)
                filtrados = filtrados.Where(i => i.Fecha >= dpFechaInicio.SelectedDate.Value);
            if (dpFechaFin.SelectedDate.HasValue)
                filtrados = filtrados.Where(i => i.Fecha <= dpFechaFin.SelectedDate.Value);

            // Filtro de texto
            if (!string.IsNullOrEmpty(txtFiltroPlaca.Text))
                filtrados = filtrados.Where(i => i.Placa.Contains(txtFiltroPlaca.Text, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(txtFiltroConductor.Text))
                filtrados = filtrados.Where(i => i.Conductor.Contains(txtFiltroConductor.Text, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(txtFiltroProducto.Text))
                filtrados = filtrados.Where(i => i.Producto.Contains(txtFiltroProducto.Text, StringComparison.OrdinalIgnoreCase));

            dgIngresos.ItemsSource = null;
            dgIngresos.ItemsSource = filtrados.ToList();
        }
    }

    // Clase modelo
    public class Ingreso
    {
        public DateTime Fecha { get; set; }
        public string Placa { get; set; } = string.Empty; // Initialize with a default value
        public string Turno { get; set; } = string.Empty; // Initialize with a default value
        public string Conductor { get; set; } = string.Empty; // Initialize with a default value
        public string Producto { get; set; } = string.Empty; // Initialize with a default value
        public string Peso { get; set; } = string.Empty; // Initialize with a default value
        public string Transporte { get; set; } = string.Empty; // Initialize with a default value
    }
}
