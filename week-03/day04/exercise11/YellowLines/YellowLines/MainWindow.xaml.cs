using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace YellowLines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            foxDraw.FillColor(Colors.Yellow);

            int level = 6;
            double Height = canvas.Height;
            double Width = canvas.Width;
            double coordX = 0;
            double coordY = 0;
           
            DrawRecta(foxDraw, level, Height, Width, coordX, coordY);  
        }

        public static void DrawRecta(FoxDraw drawer, int level, double Height, double Width, double x, double y)
        {
            if (level == 0)
            {
                return;
            }
            else
            {
                drawer.DrawRectangle(x, y, Height, Width);

                double wid = Width / 3f;
                double hgt = Height / 3f;
                double x1 = x + wid;
                double y1 = y + hgt;
                double x2 = x + wid * 2f;
                double y2 = y + hgt * 2f;

                DrawRecta(drawer, level - 1, wid, hgt, x, y1);
                DrawRecta(drawer, level - 1, wid, hgt, x1, y);
                DrawRecta(drawer, level - 1, wid, hgt, x1, y2);
                DrawRecta(drawer, level - 1, wid, hgt, x2, y1);
            }
        }
    }
}