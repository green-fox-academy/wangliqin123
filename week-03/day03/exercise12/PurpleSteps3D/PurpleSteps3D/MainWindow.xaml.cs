﻿using System;
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

namespace PurpleSteps3D
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int x = 10;
            int y = 10;

            for (int i = 0; i < 6; i++)
            {
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(x, x, y, y);
                x += y;
                y += 10;
            }
        }
    }
}