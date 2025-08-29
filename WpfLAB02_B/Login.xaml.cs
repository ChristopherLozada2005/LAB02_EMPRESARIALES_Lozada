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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Password;

            // Ejemplo de credenciales correctas
            if (usuario == "chris" && password == "1234")
            {
                Menu ventanaMenu = new Menu();
                ventanaMenu.Show();   // Abre el menú
                this.Close();         // Cierra el login
            }
            else
            {
                lblMensaje.Text = "❌ Usuario o contraseña incorrectos";
                lblMensaje.Foreground = System.Windows.Media.Brushes.Red;
            }
        }
    }
}
