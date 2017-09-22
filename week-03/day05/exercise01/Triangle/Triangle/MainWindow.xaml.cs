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

namespace Triangle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int level = 6;

            Point left = new Point(0, 0);
            Point right = new Point(300, 0);
            Point bottom = new Point(150, 300);

            DrawTriangle(foxDraw, level, left, right, bottom);
        }

        public static void DrawTriangle(FoxDraw drawer, int level, Point left, Point right, Point bottom)
        {
            if (level == 0)
            {
                List<Point> pointTriangle = new List<Point>();
                pointTriangle.Add(left);
                pointTriangle.Add(right);
                pointTriangle.Add(bottom);

                drawer.FillColor(Colors.White);
                drawer.DrawPolygon(pointTriangle);
            }
            else
            {
                Point top_mid = new Point((left.X + right.X) / 2f, (left.Y + right.Y) / 2f);
                Point right_mid = new Point((right.X + bottom.X) / 2f, (right.Y + bottom.Y) / 2f);
                Point left_mid = new Point((bottom.X + left.X) / 2f, (bottom.Y + left.Y) / 2f);

                DrawTriangle(drawer, level - 1, left, top_mid, left_mid);
                DrawTriangle(drawer, level - 1, top_mid, right, right_mid);
                DrawTriangle(drawer, level - 1, left_mid, right_mid, bottom);
            }
        }
    }
}