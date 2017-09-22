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

            Point pointA = new Point(0, 0);
            Point pointB = new Point(300, 0);
            Point pointC = new Point(150, 300);

            DrawTriangle(foxDraw, level, pointA, pointB, pointC);
        }

        public static void DrawTriangle(FoxDraw drawer, int level, Point pointA, Point pointB, Point pointC)
        {
            if (level == 0)
            {
                List<Point> pointTriangle = new List<Point>();
                pointTriangle.Add(pointA);
                pointTriangle.Add(pointB);
                pointTriangle.Add(pointC);

                drawer.FillColor(Colors.White);
                drawer.DrawPolygon(pointTriangle);
            }
            else
            {
                Point pointD = new Point((pointA.X + pointB.X) / 2f, (pointA.Y + pointB.Y) / 2f);
                Point pointE = new Point((pointB.X + pointC.X) / 2f, (pointB.Y + pointC.Y) / 2f);
                Point pointF = new Point((pointC.X + pointA.X) / 2f, (pointC.Y + pointA.Y) / 2f);

                DrawTriangle(drawer, level - 1, pointA, pointD, pointF);
                DrawTriangle(drawer, level - 1, pointD, pointB, pointE);
                DrawTriangle(drawer, level - 1, pointF, pointE, pointC);
            }
        }
    }
}