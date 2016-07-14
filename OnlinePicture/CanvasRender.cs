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

namespace OnlinePicture
{
    class CanvasRender
    {
        public Random random;
        public Canvas myCanvas;
        public int xSize;
        public int ySize;
        private Rectangle[,] map;
        private SolidColorBrush[,] colorMap;

        public void Initialize()
        {
            random = new Random();
            map = new Rectangle[xSize, ySize];
            colorMap = new SolidColorBrush[xSize, ySize];
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    CreatePixel(x, y, Colors.Blue);
                }
            }
        }


        public void CreatePixel(int x, int y, Color color)
        {
            Rectangle rec = new Rectangle();
            Canvas.SetTop(rec, y *10);
            Canvas.SetLeft(rec, x * 10);
            rec.Width = 10;
            rec.Height = 10;
            if (random.Next(2) == 0)
            {
                colorMap[x, y] = new SolidColorBrush(Colors.White);
            }else
            {
                colorMap[x, y] = new SolidColorBrush(Colors.Black);
            }
            
            rec.Fill = colorMap[x, y];
            myCanvas.Children.Add(rec);
            map[x, y] = rec;

        }

        public void ChangePixel(int x, int y, Color color)
        {
            colorMap[x, y].Color = color;
        }

    }
}
