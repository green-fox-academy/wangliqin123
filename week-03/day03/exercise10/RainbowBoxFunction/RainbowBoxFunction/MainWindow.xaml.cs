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

namespace RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int size = 150;

            for (int i = 0; i < 20; i++)
            {
                CenterSquareCreator(foxDraw, size, RandomColor(random));
                size = size - 5;
            }
        }

        public Color RandomColor(Random random)
        {
             return Color.FromRgb((byte)random.Next(255), 
                                  (byte)random.Next(255), 
                                  (byte)random.Next(255));
        }

        public void CenterSquareCreator(FoxDraw drawer, int size, Color color)   
        {
            Point coord = new Point(canvas.Height / 2 , canvas.Width / 2 );
            List<Point> points = new List<Point>();
            points.Add(new Point(coord.X - size, coord.Y - size));
            points.Add(new Point(coord.X + size, coord.Y - size));
            points.Add(new Point(coord.X + size, coord.Y + size));
            points.Add(new Point(coord.X - size, coord.Y + size));

            drawer.FillColor(color);
            drawer.DrawPolygon(points);
        }
    }
}