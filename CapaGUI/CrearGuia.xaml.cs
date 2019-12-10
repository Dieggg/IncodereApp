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
    /// Lógica de interacción para CrearGuia.xaml
    /// </summary>
    public partial class CrearGuia : MetroWindow
    {
        public CrearGuia()
        {
            InitializeComponent();
            btnIngresarGuia.IsEnabled = false;
        }

   

 
        private void BtnCargarMaterial_Click(object sender, RoutedEventArgs e)
        {

            
            if (txtMaterial.Text != "" && txtCantidad.Text != "" && txtCodigo.Text != "" && txtUm.Text != "")
            {
                var data = new ListaGuia { Codigo = txtCodigo.Text ,Material = txtMaterial.Text, Cantidad = txtCantidad.Text, UM = txtUm.Text };
                dgGuia.Items.Add(data); 
                txtMaterial.Text = "";
                txtCantidad.Text = "";
                txtCodigo.Text = "";
                txtUm.Text = "";
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("Imagenes/Iconos/iconoCheck.png", UriKind.Relative);
                bi3.EndInit();
                imgEstado.Stretch = Stretch.Fill;
                imgEstado.Source = bi3;
                lblMensaje.Content = "Material Cargado correctamente.";
               


            }
            else
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("Imagenes/Iconos/iconoError.png", UriKind.Relative);
                bi3.EndInit();
                imgEstado.Stretch = Stretch.Fill;
                imgEstado.Source = bi3;
                lblMensaje.Content = "Favor llenar los campos de material";

            }


        }

        public class ListaGuia
        {
            public string Codigo { get; set; }
            public string Material { get; set; }
            public string Cantidad { get; set; }

            public string UM { get; set; }
        }

        private void BtnIngresarGuia_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void btnGuardarGuia_Click(object sender, RoutedEventArgs e)
        {
            btnIngresarGuia.IsEnabled = true;

            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("Imagenes/Iconos/iconoCheck.png", UriKind.Relative);
            bi3.EndInit();
            imgEstado.Stretch = Stretch.Fill;
            imgEstado.Source = bi3;
            lblMensaje.Content = "Registro Guardado Correctamente";

        }
    }
}
