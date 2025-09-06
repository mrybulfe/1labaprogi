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
    Rectangle re;
    Random rnd = new Random();
    //предыдущее значение слайдеров 
    private int previousX = 0;
    private int previousY = 0;
    public MainWindow()
    {
        InitializeComponent();
        XShift.ValueChanged += XShift_ValueChanged;
        YShift.ValueChanged += YShift_ValueChanged;

    }
    private void XShift_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        int newX = (int)e.NewValue;
        int deltaX = newX - previousX;
        previousX = newX;

        if (tr != null)
        {
            tr.addX(deltaX);
            RedrawTriangle();
        }

        if (re != null)
        {
            re.addX(deltaX);
            RedrawRectangle();
        }
    }
    private void YShift_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        int newY = (int)e.NewValue;
        int deltaY = newY - previousY;
        previousY = newY;

        if (tr != null)
        {
            tr.addY(deltaY);
            RedrawTriangle();
        }

        if (re != null)
        {
            re.addY(deltaY);
            RedrawRectangle();
        }
    }



    private void RedrawRectangle()
    {
        ClearScene();
        DrawRectangle(re);
    }
    private void RedrawTriangle()
    {
        ClearScene();
        DrawTriangle(tr);
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

    private void DrawRectangle(Rectangle re)
    {
        DrawLine(re.getP1(), re.getP2());
        DrawLine(re.getP2(), re.getP4());
        DrawLine(re.getP4(), re.getP3());
        DrawLine(re.getP3(), re.getP1());
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

    private void CreateRectangle_Click(object sender, RoutedEventArgs e)
    {
        int a = rnd.Next(0, (int)Scene.Width);
        int b = rnd.Next(0, (int)Scene.Height);
        int c = rnd.Next(0, (int)Scene.Width);
        int d = rnd.Next(0, (int)Scene.Height);
        Point2d p1 = new Point2d(a,b);
        Point2d p2 = new Point2d(c,b);
        Point2d p3 = new Point2d(a,d);
        Point2d p4 = new Point2d(c,d);
        re = new Rectangle(p1, p2, p3, p4);
        DrawRectangle(re);
    }

    private void CreareSquare_Click(object sender, RoutedEventArgs e)
    {
        int sizeScene = Math.Min((int)Scene.Height, (int)Scene.Width);
        int size = rnd.Next(0, sizeScene);


        int a = rnd.Next(0, (int)Scene.Width - size);
        int b = rnd.Next(0, (int)Scene.Height - size);

        Point2d p1 = new Point2d(a, b);
        Point2d p2 = new Point2d(a+size, b);
        Point2d p3 = new Point2d(a,b+size);
        Point2d p4 = new Point2d(a+size,b+size);
        re = new Rectangle(p1, p2, p3, p4);
        DrawRectangle(re);
    }

    private void SetСoordinates_Click(object sender, RoutedEventArgs e)
    {
        CreatingFigures form2 = new CreatingFigures(this);
        form2.Show();
    }


    public void DrawSquareAtCoordinates(int a, int b, int size)
    {
        Point2d p1 = new Point2d(a, b);
        Point2d p2 = new Point2d(a + size, b);
        Point2d p3 = new Point2d(a, b + size);
        Point2d p4 = new Point2d(a + size, b + size);

        re = new Rectangle(p1, p2, p3, p4);
        DrawRectangle(re);
    }
    public void DrawTriangleAtCoordinates(int a,int b,int c,int d, int e, int f)
    {
        Point2d p1 = new Point2d(a,b);
        Point2d p2 = new Point2d(c,d);
        Point2d p3 = new Point2d(e,f);
        tr = new Triangle(p1, p2, p3);
        DrawTriangle(tr);
    }
}