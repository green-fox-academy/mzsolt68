using System.Windows;
using System.Windows.Media;

namespace MiddleLines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Draw lines in the middle of canvas
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLines(foxDraw);
        }

        void DrawLines(FoxDraw foxdraw)
        {
            foxdraw.StrokeColor(Colors.Red);
            foxdraw.DrawLine(0, this.Height / 2, this.Width, this.Height / 2);
            foxdraw.StrokeColor(Colors.Green);
            foxdraw.DrawLine(this.Width / 2, 0, this.Width / 2, this.Height);
        }
    }
}
