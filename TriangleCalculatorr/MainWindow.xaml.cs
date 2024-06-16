using System;
using System.Threading;
using System.Windows;
using TriangleCalculatorr;

namespace TriangleCalculatorr
{
    public partial class MainWindow : Window
    {
        private double sideA, sideB, sideC;
        private bool calculatePerimeter, calculateArea, calculateMedian, calculateBisector;
        private bool isEquilateral;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            InputWindow inputWindow = new InputWindow();
            if (inputWindow.ShowDialog() == true)
            {
                sideA = inputWindow.SideA;
                sideB = inputWindow.SideB;
                sideC = inputWindow.SideC;
                calculatePerimeter = inputWindow.CalculatePerimeter;
                calculateArea = inputWindow.CalculateArea;
                calculateMedian = inputWindow.CalculateMedian;
                calculateBisector = inputWindow.CalculateBisector;
                isEquilateral = inputWindow.IsEquilateral;
            }
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            if (sideA == 0 && sideB == 0 && sideC == 0)
            {
                MessageBox.Show("Please input the sides of the triangle first.");
                return;
            }

            ResultWindow resultWindow = new ResultWindow();
            resultWindow.PerimeterTextBox.Text = calculatePerimeter ? CalculatePerimeter().ToString() : "Not calculated";
            resultWindow.AreaTextBox.Text = calculateArea ? CalculateArea().ToString() : "Not calculated";
            resultWindow.MedianTextBox.Text = calculateMedian ? CalculateMedian().ToString() : "Not calculated";
            resultWindow.BisectorTextBox.Text = calculateBisector ? CalculateBisector().ToString() : "Not calculated";

            resultWindow.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private double CalculatePerimeter()
        {
            return sideA + sideB + sideC;
        }

        private double CalculateArea()
        {
            double half_Perimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(half_Perimeter * (half_Perimeter - sideA) * (half_Perimeter - sideB) * (half_Perimeter - sideC));
        }

        private double CalculateMedian()
        {
            return Math.Sqrt(2 * (sideA * sideA + sideB * sideB) - sideC * sideC) / 2;
        }

        private double CalculateBisector()
        {
            return Math.Sqrt(sideA * sideB * (sideA + sideB + sideC) * (sideA + sideB - sideC)) / (sideA + sideB);
        }
    }
}