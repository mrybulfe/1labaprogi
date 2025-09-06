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
    /// Логика взаимодействия для TriangleSizeWindow.xaml
    /// </summary>
    public partial class TriangleSizeWindow : Window
    {
        private MainWindow mainWindow;
        public TriangleSizeWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void FinishedTriangle_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(triangl_point1_coordinate_x.Text);
            int b = Convert.ToInt32(triangl_point1_coordinate_y.Text);
            int c = Convert.ToInt32(triangl_point2_coordinate_x.Text);
            int d = Convert.ToInt32(triangl_point2_coordinate_y.Text);
            int ee = Convert.ToInt32(triangl_point3_coordinate_x.Text);
            int f = Convert.ToInt32(triangl_point3_coordinate_y.Text);
            mainWindow.DrawTriangleAtCoordinates(a, b, c, d, ee, f);
            triangl_point1_coordinate_x.Clear();
            triangl_point1_coordinate_y.Clear();
            triangl_point2_coordinate_x.Clear();
            triangl_point2_coordinate_y.Clear();
            triangl_point3_coordinate_x.Clear();
            triangl_point3_coordinate_y.Clear();
            this.Close();
        }
    }
}
