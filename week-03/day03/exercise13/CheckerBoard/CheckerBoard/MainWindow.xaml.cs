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

namespace CheckerBoard
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double x = canvas.Width / 8;
            double y = canvas.Width / 8;

            for (int j = 0; j < 8; j++)
            {
                if (j % 2 != 0)
                {
                 foxDraw.FillColor(Colors.Black);
                }
                else
                {
                 foxDraw.FillColor(Colors.White);
                }
                foxDraw.DrawRectangle(x, y, y, y);
                x += y;
            }
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 != 0)
                {
                    foxDraw.FillColor(Colors.White);
                }
                else
                {
                    foxDraw.FillColor(Colors.Black);
                }
                foxDraw.DrawRectangle(y, x, y, y);
                x += y;
            }
           


            



        }
    }
}
