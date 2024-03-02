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

namespace Proyecto_de_Aplicada
{
    /// <summary>
    /// Lógica de interacción para _02_menu.xaml
    /// </summary>
    public partial class _02_menu : Window
    {
        public _02_menu()
        {
            InitializeComponent();
        }

        private void Windows_mouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void b_controlRegistro_Click_1(object sender, RoutedEventArgs e)
        {
            DataContext = new Vistas.Inicio();
        }

        private void b_historialCientes_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Vistas.Prestamos();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void b_gestionar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b_prestamos_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Vistas.Prestamos();
        }
    }
}
