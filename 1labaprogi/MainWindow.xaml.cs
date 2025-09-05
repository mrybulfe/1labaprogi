using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Formats.Asn1.AsnWriter;

namespace _1labaprogi;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Triangle tr;
    Random rnd = new Random();
    public MainWindow()
    {
        InitializeComponent();
        
    }
    public void DrawLine(Point2d p1, Point2d p2)
    {
        Line line = new Line();
        line.Stroke = Brushes.Red;
        line.StrokeThickness = 3;

        line.X1 = p1.getX();
        line.Y1 = p1.getY();
        line.X2 = p2.getX();
        line.Y2 = p2.getY();
        Scene.Children.Add(line);

    }
     private void DrawTriangle(Triangle tr)
    {
        DrawLine(tr.getP1(), tr.getP2());
        DrawLine(tr.getP2(), tr.getP3());
        DrawLine(tr.getP3(), tr.getP1());

    }
    public void ClearScene()
    {
        Scene.Children.Clear();
    }

    private void ClearBordButton_Click(object sender, RoutedEventArgs e)
    {
        ClearScene();
    }

    private void CreateTriangle_Click(object sender, RoutedEventArgs e)
    {
        Point2d p1 = new Point2d(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        Point2d p2 = new Point2d(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        Point2d p3 = new Point2d(rnd.Next(0, (int)Scene.Width), rnd.Next(0, (int)Scene.Height));
        tr = new Triangle(p1, p2, p3);
        DrawTriangle(tr);
    }
}