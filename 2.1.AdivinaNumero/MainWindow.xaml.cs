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

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numero = GenerarNumero();
        public MainWindow()
        {
            InitializeComponent();
        }
        private static int GenerarNumero()
        {
            Random seed = new Random();
            int numeroGenerado = seed.Next(0, 100);

            return numeroGenerado;

        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
 
            int numeroAComprobar = int.Parse(ResultadoTextBox.Text);

            if (numeroAComprobar == numero)
            {
                SalidaTextBlock.Text = "¡Has acertado!";
            }
            else if (numeroAComprobar < numero)
            {
                SalidaTextBlock.Text = "Te has quedado corto";
            }
            else
            {
                SalidaTextBlock.Text = "Te has pasado";
            }

        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numero = GenerarNumero();

            SalidaTextBlock.Text = "";
            ResultadoTextBox.Text = String.Empty;

        }
    }
}
