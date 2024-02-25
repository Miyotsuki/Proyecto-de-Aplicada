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
    /// Lógica de interacción para MENU.xaml
    /// </summary>
    public partial class MENU : Window
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void b_historialCientes_Click(object sender, RoutedEventArgs e)
        {
            HISTORIAL Historial = new HISTORIAL();
            Historial.Show();
        }

        private void b_nuevaCotizacion_Click(object sender, RoutedEventArgs e)
        {
            NUEVA_COTIZACION CotizarClient =   new NUEVA_COTIZACION();
            CotizarClient.Show();
        }

        private void b_controlRegistro_Click(object sender, RoutedEventArgs e)
        {
            CONTROL_RESGISTRO Registro = new CONTROL_RESGISTRO();   
            Registro.Show();   
        }
    }
}
