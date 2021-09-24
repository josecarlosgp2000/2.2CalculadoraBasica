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

namespace CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int resultado;

        public MainWindow()
        {
            InitializeComponent();
            
        }






        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            string operador = OperadorTextBox.Text;
            int numero1;
            int numero2;
            try
            {
                numero1 = int.Parse(Operando1TextBox.Text);
                numero2 = int.Parse(Operando2TextBox.Text);
                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        ResultadoTextBox.Text = resultado.ToString();
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        ResultadoTextBox.Text = resultado.ToString();
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        ResultadoTextBox.Text = resultado.ToString();
                        break;
                    case "/":
                        resultado = numero1 / numero2;
                        ResultadoTextBox.Text = resultado.ToString();
                        break;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Error de formato");              
            }                     
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Operando1TextBox.Clear();
            Operando2TextBox.Clear();
            OperadorTextBox.Clear();
            ResultadoTextBox.Clear();
        }

        private void ResultadoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OperadorTextBox.Text == "+" || OperadorTextBox.Text == "-" || OperadorTextBox.Text == "*" || OperadorTextBox.Text == "/")
            {
                CalcularButton.IsEnabled = true;
            }
            else
            {
                CalcularButton.IsEnabled = false;
            }
        }
    }
}
