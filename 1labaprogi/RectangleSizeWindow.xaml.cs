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
    /// Логика взаимодействия для RectangleSizeWindow.xaml
    /// </summary>
    public partial class RectangleSizeWindow : Window
    {
        private MainWindow mainWindow;
        public RectangleSizeWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void FinishedRectangle_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(rectangle_point_coordinate_x.Text);
            int b = Convert.ToInt32(rectangle_point_coordinate_x.Text);
            int height = Convert.ToInt32(rectangle_height.Text);
            int width = Convert.ToInt32(rectangle_width.Text);
            mainWindow.DrawRectangleAtCoordinates(a, b, width, height);
            this.Close();
        }
    }
}
