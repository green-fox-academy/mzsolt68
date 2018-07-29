using MiddleLines;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace CheckBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Draw checkboard texture
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            DrawFrame(foxDraw);
            DrawCheckBoard(foxDraw);
        }

        private void DrawFrame(FoxDraw foxDraw)
        {
            var points = new List<Point>
            {
                new Point(0,0),
                new Point(400,0),
                new Point(400,400),
                new Point(0, 400)
            };
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.White);
            foxDraw.DrawPolygon(points);
        }

        private void DrawCheckBoard(FoxDraw foxDraw)
        {
            Point start = new Point(0, 0);
            int size = 50;
            //foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Black);
            for(int row = 0; row < 8; row++)
            {
                for(int col = 0; col < 8; col++)
                {
                    if((row % 2 == 0) && (col % 2 == 0))
                    {
                        foxDraw.DrawRectangle(start.X + col * size, start.Y + row * size, size, size);
                    }
                    if ((row % 2 != 0) && (col % 2 != 0))
                    {
                        foxDraw.DrawRectangle(start.X + col * size, start.Y + row * size, size, size);
                    }
                }
            }
        }
    }
}
