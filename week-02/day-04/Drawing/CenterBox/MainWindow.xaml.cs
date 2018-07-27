using System;
using System.Windows;
using MiddleLines;

namespace CenterBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;
        Random rnd;
        public MainWindow()
        {
            InitializeComponent();
            rnd = new Random();
            foxDraw = new FoxDraw(canvas);
            for(int i = 0; i < 3; i++)
            {
                DrawToCenter(rnd.Next(50, (int)this.Height - 50));
            }
        }

        private void DrawToCenter(int size)
        {
            double startX = (this.Width / 2) - (size / 2);
            double startY = (this.Height / 2) - (size / 2);
            foxDraw.DrawLine(startX, startY, startX + size, startY);
            foxDraw.DrawLine(startX + size, startY, startX + size, startY + size);
            foxDraw.DrawLine(startX + size, startY + size, startX, startY + size);
            foxDraw.DrawLine(startX, startY + size, startX, startY);
        }
    }
}
