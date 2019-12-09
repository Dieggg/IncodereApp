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

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace CapaGUI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (login(txtUsuario.Text, txtContrasena.Password)){ 
            await this.ShowMessageAsync("Exito", "Tus datos son correctos");
            Menu _ver = new Menu();
            this.Close();
            _ver.ShowDialog();
            }else
            {
            await this.ShowMessageAsync("Error", "Usuario o Contraseña incorrecta, intente nuevamente");
            }

            
        }

        private async void TxtUsuario_TouchEnter(object sender, TouchEventArgs e)
        {
            if (login(txtUsuario.Text, txtContrasena.Password))
            {
                await this.ShowMessageAsync("Exito", "Tus datos son correctos");
                Menu _ver = new Menu();
                this.Close();
                _ver.ShowDialog();
            }
            else
            {
                await this.ShowMessageAsync("Error", "Usuario o Contraseña incorrecta, intente nuevamente");
            }

        }




        //LOGIN TEMPORAL DE PRUEBA
        bool  login (string usuario ,string contrasena)
        {
            if (usuario == "admin" && contrasena == "admin")
            {

                return true;
                

            }
            else 
            {

                return false;

            }
           
        }

        private void MetroWindow_TouchEnter(object sender, TouchEventArgs e)
        {

        }
    }
}
