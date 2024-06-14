using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace _7._2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
        }
        private void Chk_Perimeter_Checked(object sender, RoutedEventArgs e)
        {
            int sideA = Convert.ToInt32(txt_SideA.Text);
            int sideB = Convert.ToInt32(txt_SideB.Text);
            int sideC = Convert.ToInt32(txt_SideC.Text);
            int result = 0;
            result = sideA + sideB + sideC;
        }

        private void Chk_Area_Checked(object sender, RoutedEventArgs e)
        {
            int sideA = Convert.ToInt32(txt_SideA.Text);
            int sideB = Convert.ToInt32(txt_SideB.Text);
            int sideC = Convert.ToInt32(txt_SideC.Text);
            int result = sideA * sideB * sideC;
        }

        private void Chk_Median_Checked(object sender, RoutedEventArgs e)
        {
           
        }
        private void Chk_Bisector_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Calculation_Click1(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Confirmation_Click(object sender, RoutedEventArgs e)
        {
            if (txt_SideA.Text == txt_SideB.Text && txt_SideB.Text == txt_SideC.Text)
            {
                chk_Median.Visibility = Visibility.Visible;
                chk_Bisector.Visibility = Visibility.Visible;
            }
            else
            {
                chk_Median.Visibility = Visibility.Collapsed;
                chk_Bisector.Visibility = Visibility.Collapsed;
            }
        }
    }
}

