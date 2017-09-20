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

namespace PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Random coordies = new Random();
            Point coord = new Point(coordies.Next(200), coordies.Next(70));
            int sizechange = 50;

            for (int i = 0; i < 3; i++)
            {
                SquareMaker(foxDraw, new Point(coordies.Next(200), coordies.Next(70)), sizechange);
            }
        }

        public void SquareMaker(FoxDraw drawer, Point coord, int sizechange)
        {
            List<Point> points = new List<Point>();
            points.Add(coord);
            points.Add(new Point(coord.X + sizechange, coord.Y));
            points.Add(new Point(coord.X + sizechange, coord.Y + sizechange));
            points.Add(new Point(coord.X, coord.Y + sizechange));

            drawer.DrawPolygon(points);
        }
    }
}
