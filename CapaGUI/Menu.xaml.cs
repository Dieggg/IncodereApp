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

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace CapaGUI
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
     

        public Menu()
        {
            InitializeComponent();
           
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

            //BitmapImage bi3 = new BitmapImage();
            //bi3.BeginInit();
            //bi3.UriSource = new Uri("Imagenes/bc1.jpg", UriKind.Relative);
            //bi3.EndInit();
            //img.Stretch = Stretch.Fill;
            //img.Source = bi3;
            lbltext.Text = "En la opcion podras ingresar guia de despacho para que puedas rgistrar todo loque quieras";

        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            //BitmapImage bi3 = new BitmapImage();
            //bi3.BeginInit();
            //bi3.UriSource = new Uri("Imagenes/LogoIncodereTrasparente.png", UriKind.Relative);
            //bi3.EndInit();
            //img.Stretch = Stretch.Fill;
            //img.Source = bi3;

            lbltext.Text = "";
        }

        private void MouseEnter_CrearProducto(object sender, MouseEventArgs e)
        {
            lbltext.Text = "En la opcion podras crear material que aun no este cargado en el sistema, sigue las instrucciones y lo lograras";
        }

        private void MouseLeave_CrearProducto(object sender, MouseEventArgs e)
        {
            lbltext.Text = "";
        }

        private void MouseEnter_ModificarProducto(object sender, MouseEventArgs e)
        {
            lbltext.Text = "Transaccion para modificar eliminar producto";
        }

        private void MouseLeave_ModificarProducto(object sender, MouseEventArgs e)
        {
            lbltext.Text = "";
        }

        private void Button_Click_IngresarGuia(object sender, RoutedEventArgs e)
        {
            IGProveedor _ver = new IGProveedor();
            this.Close();
            _ver.ShowDialog();

        }
    }
}
