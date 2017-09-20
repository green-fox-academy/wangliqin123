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

namespace ColoredBox
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

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(100, 50, 200, 50);

            foxDraw.StrokeColor(Colors.Orange);
            foxDraw.DrawLine(100, 200, 200, 200);

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(100, 50, 100, 200);

            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(200, 50, 200, 200);
        }
    }
}
