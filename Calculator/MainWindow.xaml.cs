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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            StringBuilder inputTextString = new StringBuilder(inputText.Text);

            if (!inputTextString[0].Equals('0'))
            {
                inputTextString.Append(btn.Content.ToString());
                inputText.Text = inputTextString.ToString();
            }
            else
            {
                inputTextString.Clear();
                inputTextString.Append(btn.Content.ToString());
                inputText.Text = inputTextString.ToString();
            }
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            inputText.Text = "0";
        }
        public void operation_Click(object sender, RoutedEventArgs e)
        {
            if ((inputText.Text == "0") || (operation_pressed))
                inputText.Clear();
            operation_pressed = false;
            Button btn = (Button)sender;
            inputText.Text = inputText.Text + "btn.Text";

}
        public void operation_Click_D(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            operation = "btn.Text";
            value = double.Parse(inputText.Text);
            operation_pressed = true;
        }
        private void Button_Click_Equ(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    inputText.Text = (value + Double.Parse(inputText.Text)).ToString();
                    break;

                case "-":
                    inputText.Text = (value - Double.Parse(inputText.Text)).ToString();
                    break;

                case "*":
                    inputText.Text = (value * Double.Parse(inputText.Text)).ToString();
                    break;

                case "/":
                    inputText.Text = (value / Double.Parse(inputText.Text)).ToString();
                    break;

                default:
                    break;

            }

        }
        private void Button_Click_B(object sender, RoutedEventArgs e)
        {
            inputText.Text="0";
            value = 0;
        }

    }
}






