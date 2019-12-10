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
    public partial class IGProveedor : MetroWindow
    {
        public IGProveedor()
        {
            InitializeComponent();

        }

        private void CargaDG(object sender, RoutedEventArgs e)
        {

        }

        private void MostrarCliente()
        {
            //dgGuia.ItemsSource = objetoCliente.MostrarCliente().DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CrearGuia _ver = new CrearGuia();
            this.Close();
            _ver.ShowDialog();
        }
    }
   

}
