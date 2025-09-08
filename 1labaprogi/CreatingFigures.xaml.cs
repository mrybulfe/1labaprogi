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
    /// Логика взаимодействия для CreatingFigures.xaml
    /// </summary>
    public partial class CreatingFigures : Window
    {
        private MainWindow mainWindow;
        public CreatingFigures(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void CreareSquareSize_Click(object sender, RoutedEventArgs e)
        {
            
            SquareSizeWindow form3 = new SquareSizeWindow(mainWindow);
            form3.Show();
            this.Close();

        }

        private void CreateTriangleSize_Click(object sender, RoutedEventArgs e)
        {
            TriangleSizeWindow form2 = new TriangleSizeWindow(mainWindow);
            form2.Show();
            this.Close();
        }

        private void CreateRectangleSize_Click(object sender, RoutedEventArgs e)
        {
            RectangleSizeWindow form4 = new RectangleSizeWindow(mainWindow);
            form4.Show();
            this.Close();
        }
    }
}
