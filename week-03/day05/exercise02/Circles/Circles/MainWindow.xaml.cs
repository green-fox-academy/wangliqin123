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

namespace Circles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double width = 10;
            double height = 10;

            CreateEllipse(foxDraw, width, height);

            public static void CreateEllipse(double desiredLeft, double desiredTop)
            {
                Canvas canvas = new Canvas();
                Ellipse ellipse = SomeEllipseConstructionMethod();
                Canvas.SetLeft(ellipse, desiredLeft);
                Canvas.SetTop(ellipse, desiredTop);
            }



            //    InitializeComponent();
            //    var foxDraw = new FoxDraw(canvas);
            //    int level = 2;

            //    int x = 0;
            //    int y = 0;
            //    int size = 300;

            //    DrawCircle(foxDraw, level, x, y, size);
            //}

            //public static void DrawCircle(FoxDraw drawer, int level, int x, int y, int size)
            //{
            //    //if (level == 0)
            //    //{


            //        drawer.FillColor(Colors.White);
            //        drawer.DrawEllipse(x, y, size);
            //    //}
            //else
            //{
            //    int newx = x + 75;
            //    int newy = y + 75;
            //    int newsize = size / 2;

            //    drawer.FillColor(Colors.Green);
            //    DrawCircle(drawer, level - 1, newx, newy, newsize);

            //}
        }
    }
}
