using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MorePain_t_
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

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Canvas.Strokes.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes inkDA = new DrawingAttributes();

            inkDA.Color = Colors.Black;
            Canvas.DefaultDrawingAttributes = inkDA;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes inkColor = new DrawingAttributes();

            inkColor.Color = Colors.Red;
            Canvas.DefaultDrawingAttributes = inkColor;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            DrawingAttributes inkColor = new DrawingAttributes();

            inkColor.Color = Colors.Green;
            Canvas.DefaultDrawingAttributes = inkColor;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes inkColor = new DrawingAttributes();

            inkColor.Color = Colors.Blue;
            Canvas.DefaultDrawingAttributes = inkColor;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Canvas.DefaultDrawingAttributes.Width = value;
            Canvas.DefaultDrawingAttributes.Height = value;
        }
    }
}
