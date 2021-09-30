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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void F1TextBlock(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(e.Key == Key.F1 && MensajeAyudaTextBox.Text == "")
            {
                MensajeAyudaTextBox.Text =  textBox.Tag.ToString();
            }
            else if(e.Key == Key.F1)
            {
                MensajeAyudaTextBox.Text = "";
            }
        }

        private void F2TextxBox(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int res;
            if(e.Key == Key.F2)
            {
                if (int.TryParse(textBox.Text, out res))
                {
                    MessageBox.Show("El valor introducido es correcto");
                }
                else
                {
                    MessageBox.Show("No has introcudcido un valor correcto en el campo de edad, introduce un numero");
                }
            }
            
        }
    }
}
