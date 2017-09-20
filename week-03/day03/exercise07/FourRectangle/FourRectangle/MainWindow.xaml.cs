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
using GreenFox;

namespace FourRectangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
 
            Random coordinates = new Random();

            Point coord = new Point(coordinates.Next(300), coordinates.Next(60));
            int sizeHorizontal = coordinates.Next(30)+10;
            int sizeVertical = coordinates.Next(70);

            for (int i = 0; i < 4; i++)
            {
                RectangleMaker(foxDraw, new Point(coordinates.Next(300),
                               coordinates.Next(60)), coordinates.Next(30)+10, coordinates.Next(70));
            }
            
        }
        public void RectangleMaker(FoxDraw drawer,Point coord, int sizeHorizontal, int sizeVertical)
        {
            List<Point> points = new List<Point>();
            points.Add(coord);
            points.Add(new Point(coord.X + sizeHorizontal, coord.Y));
            points.Add(new Point(coord.X + sizeHorizontal, coord.Y + sizeVertical));
            points.Add(new Point(coord.X, coord.Y + sizeVertical));

            drawer.DrawPolygon(points);
        } 
    }
}
