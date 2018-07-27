using MiddleLines;
using System.Windows;
using System.Windows.Media;

namespace ColoredBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Draw a box with different colored lines
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawBox(foxDraw);
        }

        void DrawBox(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(100, 100, 200, 100);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(200, 100, 200, 200);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(200, 200, 100, 200);
            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(100, 200, 100, 100);
        }
    }
}
