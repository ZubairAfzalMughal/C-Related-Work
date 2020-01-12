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

namespace CALCULATOR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int result = 0;
        float result1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Because TextBox return the value in string 
            // So we first converst it into integer
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                // Showing data in Exception box

                Exception_Box.Text = "Field is Empty";

                // MessageBox.Show("Field is Empty");
            }
            else
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                result = num1 + num2;

                // Showing Result in Result_Box

                // Label Box         TextBox

                Result_Box.Text = result.ToString();

                // Show The Result in Message Box
                //MessageBox.Show("Result is " + result.ToString());
            }
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            // Because TextBox return the value in string 
            // So we first converst it into integer

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                // Showing data in Exception box

                Exception_Box.Text = "Field is Empty";

                // MessageBox.Show("Field is Empty");
            }
            else
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                result = num1 - num2;

                // Showing Result in Result_Box

                // Label Box         TextBox

                Result_Box.Text = result.ToString();

                // Show The Result in Message Box
                //MessageBox.Show("Result is " + result.ToString());
            }
        }

        private void MUL_Click(object sender, RoutedEventArgs e)
        {
            // Because TextBox return the value in string 
            // So we first converst it into integer

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                // Showing data in Exception box

                Exception_Box.Text = "Field is Empty";

                // MessageBox.Show("Field is Empty");
            }
            else
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                result = num1 * num2;

                // Showing Result in Result_Box

                // Label Box         TextBox

                Result_Box.Text = result.ToString();

                // Show The Result in Message Box
                //MessageBox.Show("Result is " + result.ToString());
            }
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            // Because TextBox return the value in string 
            // So we first converst it into integer

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                // Showing data in Exception box

                Exception_Box.Text = "Field is Empty";

                // MessageBox.Show("Field is Empty");
            }
            else
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                 // Local variable
                if(num2!=0)
                {
                    // Showing Result in Result_Box
                    // Label Box         TextBox
                    result1 =(float)num1/ num2;
                    Result_Box.Text = result1.ToString();
                    
                }
                else
                {
                    Exception_Box.Text = "Can't Divide on Zero";
                }

               

                // Show The Result in Message Box
                //MessageBox.Show("Result is " + result.ToString());
            }
        }

    }
}
