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

namespace WPF_Paint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            myCanvas.Strokes.Clear();
        }

        private void ComboSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComboSize.SelectedIndex)
            {
                case 0:
                    myCanvas.DefaultDrawingAttributes.Width = 2;
                    myCanvas.DefaultDrawingAttributes.Height = 2;
                    break;
                case 1:
                    myCanvas.DefaultDrawingAttributes.Width = 4;
                    myCanvas.DefaultDrawingAttributes.Height = 4;
                    break;
                case 2:
                    myCanvas.DefaultDrawingAttributes.Width = 6;
                    myCanvas.DefaultDrawingAttributes.Height = 6;
                    break;
                case 3:
                    myCanvas.DefaultDrawingAttributes.Width = 8;
                    myCanvas.DefaultDrawingAttributes.Height = 8;
                    break;
                case 4:
                    myCanvas.DefaultDrawingAttributes.Width = 10;
                    myCanvas.DefaultDrawingAttributes.Height = 10;
                    break;
                case 5:
                    myCanvas.DefaultDrawingAttributes.Width = 12;
                    myCanvas.DefaultDrawingAttributes.Height = 12;
                    break;
                case 6:
                    myCanvas.DefaultDrawingAttributes.Width = 14;
                    myCanvas.DefaultDrawingAttributes.Height = 14;
                    break;
                case 7:
                    myCanvas.DefaultDrawingAttributes.Width = 16;
                    myCanvas.DefaultDrawingAttributes.Height = 16;
                    break;
                case 8:
                    myCanvas.DefaultDrawingAttributes.Width = 18;
                    myCanvas.DefaultDrawingAttributes.Height = 18;
                    break;
                case 9:
                    myCanvas.DefaultDrawingAttributes.Width = 20;
                    myCanvas.DefaultDrawingAttributes.Height = 20;
                    break;
            }
        }

        private void black_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void red_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Red;
        }
        private void green_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Green;
        }
        private void yellow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Yellow;
        }
        private void blue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        private void gray_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Gray;
        }
        private void purple_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Purple;
        }
        private void brown_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Brown;
        }
        private void orange_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Orange;
        }
        private void cyan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.Cyan;
        }
        private void white_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myCanvas.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void txtNotes_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Рисунок успешно сохранен!");
        }
    }
}
