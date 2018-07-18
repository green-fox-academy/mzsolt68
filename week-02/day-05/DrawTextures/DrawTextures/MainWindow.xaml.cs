using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace DrawTextures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;
        int step;
        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            LinePlay();
            EnvelopeStar();
        }

        private void EnvelopeStar()
        {
            step = 10;
            Point start = new Point(0, this.Height / 2);
            Point end = new Point(this.Width, this.Height / 2);
            Point middle1 = new Point(this.Width / 2, this.Height / 2 - step);
            Point middle2 = new Point(this.Width / 2, this.Height / 2 + step);
            foxDraw.StrokeColor(Colors.Green);
            while(start.X < this.Width / 2)
            {
                foxDraw.DrawLine(start, middle1);
                foxDraw.DrawLine(middle1, end);
                foxDraw.DrawLine(start, middle2);
                foxDraw.DrawLine(middle2, end);
                start.X += step;
                end.X -= step;
                middle1.Y -= step;
                middle2.Y += step;
            }
        }

        private void LinePlay()
        {
            step = 25;
            Point start1 = new Point(0, 0);
            Point end1 = new Point(this.Width, 0);
            Point start2 = new Point(0, 0);
            Point end2 = new Point(0, this.Height);
            while(start1.X < this.Width)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(start1, end1);
                start1.X += step;
                end1.Y += step;
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(start2, end2);
                start2.Y += step;
                end2.X += step;
            }
        }
    }
}
