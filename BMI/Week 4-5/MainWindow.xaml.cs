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

namespace Week_4_5
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

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            const int determiner = 703;
            int weight = 0;
            int height = 0;
            int BMI = weight * determiner;
            int txtAmount = int.Parse(txtBox.Text);
            int txtAmount1 = int.Parse(txtBox1.Text);
            if (BMI >= 18.5 && BMI < 25)
            {
                lblOutput.Content = ("You are in top shape");
            }
             else if (BMI< 18.5)
            {
                lblOutput.Content = ("You are underweight");
            }
             else if (BMI>18.5)
                lblOutput.Content=("You are grossly overweight");
                    
                

            
           
        }
    }
}
