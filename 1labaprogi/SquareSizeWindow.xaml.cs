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
using System.Windows.Shapes;

namespace _1labaprogi
{
    /// <summary>
    /// Логика взаимодействия для SquareSizeWindow.xaml
    /// </summary>
    public partial class SquareSizeWindow : Window
    {
        private MainWindow mainWindow;
        Rectangle re;
        
        public SquareSizeWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void FinishedSquare_Click(object sender, RoutedEventArgs e)
        {

            int a = Convert.ToInt32(square_point_coordinate_x.Text);
            int b = Convert.ToInt32(square_point_coordinate_y.Text);
            int size = Convert.ToInt32(square_size.Text);
            mainWindow.DrawSquareAtCoordinates(a, b, size);
            square_point_coordinate_x.Clear();
            square_point_coordinate_y.Clear();
            square_size.Clear();
            this.Close();
        }
    }
}
