using System.Windows;

namespace TriangleCalculatorr
{
    public partial class InputWindow : Window
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool CalculatePerimeter { get; set; }
        public bool CalculateArea { get; set; }
        public bool CalculateMedian { get; set; }
        public bool CalculateBisector { get; set; }
        public bool IsEquilateral { get; set; }

        public InputWindow()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(SideATextBox.Text, out double sideA) && double.TryParse(SideBTextBox.Text, out double sideB) && double.TryParse(SideCTextBox.Text, out double sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;

                if (sideA == sideB && sideB == sideC)
                {
                    IsEquilateral = true;
                    MedianCheckBox.Visibility = Visibility.Visible;
                    BisectorCheckBox.Visibility = Visibility.Visible;
                }
                else
                {
                    IsEquilateral = false;
                    MedianCheckBox.Visibility = Visibility.Collapsed;
                    BisectorCheckBox.Visibility = Visibility.Collapsed;
                    MedianCheckBox.IsChecked = false;
                    BisectorCheckBox.IsChecked = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid input for sides.");
            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            CalculatePerimeter = PerimeterCheckBox.IsChecked ?? false;
            CalculateArea = AreaCheckBox.IsChecked ?? false;
            CalculateMedian = MedianCheckBox.IsChecked ?? false;
            CalculateBisector = BisectorCheckBox.IsChecked ?? false;

            DialogResult = true;
        }
    }
}