using MiddleLines;
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

namespace PurpleSteps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
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
            int size = 20;
            double x = 0;
            double y = 0;
            for(int i = 0; i < 10; i++)
            {
                foxdraw.DrawRectangle(x, y, size, size);
                x += size;
                y += size;
            }
        }
    }
}
