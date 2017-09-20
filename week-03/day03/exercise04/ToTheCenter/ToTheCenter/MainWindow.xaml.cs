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

namespace ToTheCenter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            LineDrawer(foxDraw, 40, 70);
            LineDrawer(foxDraw, 120, 80);
            LineDrawer(foxDraw, 230, 90);
        }

        public void LineDrawer(FoxDraw Line, int a, int b)
        {
            Line.StrokeColor(Colors.Green);
            Line.DrawLine(new Point(a, b), new Point(canvas.Height/2, canvas.Width/2));
        }  
    }
}
