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

namespace SCarpet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int level = 6;
            float Width = 300;
            float Height = 300;
            float Left = 0;
            float Top = 0;
            Rectangle Recti = new Rectangle();
            DrawRectangle(foxDraw, level, Width, Height, Left, Top, Recti);
        }
        
        public static void DrawRectangle(FoxDraw drawer, int level, float Width, float Height, float Left, float Top, Rectangle Recti)
        {
            if (level == 0)
            { 
                drawer.FillColor(Colors.Black);
                drawer.DrawRectangle(Left, Top, Width, Height);
            }
            else
            {
                float width = Width / 3f;
                float x0 = Left;
                float x1 = x0 + width;
                float x2 = x0 + width * 2f;

                float height = Height / 3f;
                float y0 = Top;
                float y1 = y0 + height;
                float y2 = y0 + height * 2f;

                DrawRectangle(drawer, level - 1, new Recti(x0, y0, width, height));
                DrawRectangle(drawer, level - 1, new Recti(x1, y0, width, height));
                DrawRectangle(drawer, level - 1, new Recti(x2, y0, width, height));
                DrawRectangle(drawer, level - 1, new Recti(x0, y1, width, height));
                DrawRectangle(drawer, level - 1, new Recti(x2, y1, width, height));
                DrawRectangle(drawer, level - 1, new Recti(x0, y2, width, height));
                DrawRectangle(drawer, level - 1, new Recti(x1, y2, width, height));
                DrawRectangle(drawer, level - 1, new Recti(x2, y2, width, height));
            }
        }
    }
}