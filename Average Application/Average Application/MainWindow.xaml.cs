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

namespace Average_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // this is our Fields

        double Test_Score1;
        double Test_Score2;
        double Test_Score3;
        double Average_Score;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Average_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {   
                // making Decision 
                if ((test1_textBox.Text == "" || test2_textBox.Text == "") || test3_textBox.Text == "")
                {
                    MessageBox.Show("Feild is Empty");
                }
                else
                {
                    Test_Score1 = double.Parse(test1_textBox.Text);
                    Test_Score2 = double.Parse(test2_textBox.Text);
                    Test_Score3 = double.Parse(test3_textBox.Text);
                    Average_Score = Test_Score1 + Test_Score2 + Test_Score3 / 3;

                    if (Average_Score > 90.0)
                    {
                        MessageBox.Show("Congratulation you Average is greater than 90");
                        Average_textBox.Text = Average_Score.ToString();
                    }
                    else
                    {
                        Average_textBox.Text = Average_Score.ToString();
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                
            
        }

        private void Clear_button_Click(object sender, RoutedEventArgs e)
        {
            test1_textBox.Text = "";
            test2_textBox.Text = "";
            test3_textBox.Text = "";
            Average_textBox.Text = "";
          
        }

        private void Exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
