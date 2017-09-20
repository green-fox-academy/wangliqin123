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

namespace CenteredSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            var points = new List<Point>();
            points.Add(new Point(40, 70));
            points.Add(new Point(50, 70));
            points.Add(new Point(50, 80));
            points.Add(new Point(40, 80));

            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
    }
}
