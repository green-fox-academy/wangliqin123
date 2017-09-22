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
            int level = 4;

            Point top = new Point(150, 0);
            Point right = new Point(300, 300);
            Point left = new Point(0, 300);

            DrawTriangle(foxDraw, level, top, right, left);
        }

        public static void DrawTriangle(FoxDraw drawer, int level, Point top, Point right, Point left)
        {
            if (level == 0)
            {
                List<Point> pointT = new List<Point>();
                pointT.Add(top);
                pointT.Add(right);
                pointT.Add(left);

                drawer.FillColor(Colors.White);
                drawer.DrawPolygon(pointT);
            }
            else
            {
                Point left_mid = new Point((top.X + left.X) / 2f, (top.Y + left.Y) / 2f);
                Point right_mid = new Point((top.X + right.X) / 2f, (top.Y + right.Y) / 2f);
                Point bottom_mid = new Point((left.X + right.X) / 2f, (left.Y + right.Y) / 2f);

                DrawTriangle(drawer, level - 1, top, left_mid, right_mid);
                DrawTriangle(drawer, level - 1, left_mid, left, bottom_mid);
                DrawTriangle(drawer, level - 1, right_mid, bottom_mid, right);
            }
        }
    }
}