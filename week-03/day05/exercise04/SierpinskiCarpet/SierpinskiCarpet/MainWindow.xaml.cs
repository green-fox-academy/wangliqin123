using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace SierpinskiCarpet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int level = 6;
            double Height = canvas.Height;
            double Width = canvas.Width;
            double coordX = 0;
            double coordY = 0;

            DrawCarpet(foxDraw, level, Height, Width, coordX, coordY);
        }

        public static void DrawCarpet(FoxDraw drawer, int level, double Height, double Width, double x, double y)
        {
            if (level == 0)
            {
                drawer.DrawRectangle(x, y, Height, Width);
            }
            else
            {
                double wid = Width / 3f;
                double hgt = Height / 3f;
                double x1 = x + wid;
                double y1 = y + hgt;
                double x2 = x + wid * 2f;
                double y2 = y + hgt * 2f;

                drawer.BackgroundColor(Colors.IndianRed);
                drawer.FillColor(Colors.Blue);
                drawer.StrokeColor(Colors.White);

                DrawCarpet(drawer, level - 1, wid, hgt, x, y);
                DrawCarpet(drawer, level - 1, wid, hgt, x1, y);
                DrawCarpet(drawer, level - 1, wid, hgt, x2, y);
                DrawCarpet(drawer, level - 1, wid, hgt, x, y1);
                DrawCarpet(drawer, level - 1, wid, hgt, x2, y1);
                DrawCarpet(drawer, level - 1, wid, hgt, x, y2);
                DrawCarpet(drawer, level - 1, wid, hgt, x1, y2);
                DrawCarpet(drawer, level - 1, wid, hgt, x2, y2);
            }
        }
    }
}