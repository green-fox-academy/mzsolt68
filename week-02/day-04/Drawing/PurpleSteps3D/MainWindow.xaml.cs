using System.Windows;
using System.Windows.Media;
using MiddleLines;

namespace PurpleSteps3D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Drawing 3D purple steps
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FoxDraw foxDraw = new FoxDraw(canvas);
            DrawSteps(foxDraw);
        }

        void DrawSteps(FoxDraw foxdraw)
        {
            foxdraw.StrokeColor(Colors.Black);
            foxdraw.FillColor(Colors.Purple);
            int size = 5;
            double x = 0;
            double y = 0;
            for (int i = 0; i < 6; i++)
            {
                foxdraw.DrawRectangle(x, y, size, size);
                x += size;
                y += size;
                size *= 2;
            }
        }
    }
}
