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

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F1) 
            {
                if (NombreClienteTextBlock.Visibility == Visibility.Visible)
                {
                    NombreClienteTextBlock.Visibility = Visibility.Hidden;
                }
                else
                {
                    NombreClienteTextBlock.Visibility = Visibility.Visible;
                }
               
            }
           
           
        }

        private void ApellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                if (ApellidoClienteTextBlock.Visibility == Visibility.Visible)
                {
                    ApellidoClienteTextBlock.Visibility = Visibility.Hidden;
                }
                else
                {
                    ApellidoClienteTextBlock.Visibility = Visibility.Visible;
                }

            }
        }

        private void EdadTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.F2)
            {
                if (Int32.TryParse(CasillaEdadTextBox.Text, out _))
                {
                    EdadClienteTextBlock.Visibility = Visibility.Hidden;
                }
                else
                {
                    EdadClienteTextBlock.Visibility = Visibility.Visible;
                }

            }
        }
    }
}
