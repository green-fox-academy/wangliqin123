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

namespace HoritontalLines
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

            DrawHorizontalLine(foxDraw, 40, 70);
            DrawHorizontalLine(foxDraw, 100, 130);
            DrawHorizontalLine(foxDraw, 200, 180);
        }

        public void DrawHorizontalLine(FoxDraw Line, int x, int y)
        {
            Line.StrokeColor(Colors.Green);
            Line.DrawLine(new Point (x, y), new Point (x + 50, y));
        }
    }
}
