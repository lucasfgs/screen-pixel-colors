using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ScreenPixel
{
    public class ColorManager
    {
        public static Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);


        public static Color getColorAt(Point location)
        {

            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        public static Dictionary<string, List<Color>> getRandomPixelColor(Point resolution, int quantity = 4)
        {
            Random rng = new Random();
            List<Color> topLeftCorner = new List<Color>();
            List<Color> topRightCorner = new List<Color>();
            List<Color> bottomLeftCorner = new List<Color>();
            List<Color> bottomRightCorner = new List<Color>();

            int quantityByCorner = quantity / 4;
            Point position = new Point();

            for(int i = 0; i < quantityByCorner; i++)
            {
                //TOP LEFT
                position.X = rng.Next(resolution.X / 2);
                position.Y = rng.Next(resolution.Y / 2);
                topLeftCorner.Add(getColorAt(position));
                //TOP RIGHT
                position.X = rng.Next(resolution.X / 2, (resolution.X/2) +1);
                topRightCorner.Add(getColorAt(position));
                //BOTTOM LEFT
                position.X = rng.Next(resolution.X / 2);
                position.Y = rng.Next(resolution.Y / 2, (resolution.Y / 2) + 1);
                bottomLeftCorner.Add(getColorAt(position));
                //BOTTOM RIGHT
                position.X = rng.Next(resolution.X / 2, (resolution.X / 2) + 1);
                bottomRightCorner.Add(getColorAt(position));
            }

            Dictionary<string, List<Color>> allColors = new Dictionary<string, List<Color>>();
            allColors.Add("topLeft", topLeftCorner);
            allColors.Add("topRight", topRightCorner);
            allColors.Add("bottomLeft", bottomLeftCorner);
            allColors.Add("bottomRight", bottomRightCorner);

            return allColors;

        }

/*        public static Color getAverageColorsFromScreen()
        {
            using var screen = new Bitmap(width, height);
            using var screenGfx = Graphics.FromImage(screen);

            using var avg = new Bitmap(1, 1);
            using var avgGfx = Graphics.FromImage(avg);
            avgGfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            while (true)
            {
                screenGfx.CopyFromScreen(left, top, 0, 0, screen.Size);
                avgGfx.DrawImage(screen, 0, 0, avg.Width, avg.Height);
                var color = avg.GetPixel(0, 0);
                var bright = (int)Math.Round(Math.Clamp(color.GetBrightness() * 100, 1, 100));
                // set color and brightness on your device
                // wait 1000/fps milliseconds
            }

        }*/

       /* public static Color getBorderAverageColor(List<Color> topColors, List<Color> rightColors, List<Color> bottomColors, List<Color> leftColors)
        {



        }*/
    }
}
