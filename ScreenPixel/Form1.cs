using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenPixel
{
    public partial class Form1 : Form
    {
        /* [DllImport("user32.dll")]
         static extern bool GetCursorPos(ref Point lpPoint);*/

        /* GetCursorPos(ref position);*/


        Point position = new Point();      
        Point resolution = new Point();
        /*int pixelRate = 100;
        string location = "TOPRIGHT";*/
        /*List<Color> topColors = new List<Color>();
        List<Color> rightColors = new List<Color>();
        List<Color> bottomColors = new List<Color>();
        List<Color> leftColors = new List<Color>();*/


        public Form1()
        {
            InitializeComponent();
            position.X = 0;
            position.Y = 0;

            resolution.X = Screen.PrimaryScreen.Bounds.Width;
            resolution.Y = Screen.PrimaryScreen.Bounds.Height;

            timer1.Enabled = true;
            txtResolution.Text = ("Resolution: " + resolution.X.ToString() + "x" + resolution.Y.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Dictionary<string, List<Color>> colors = ColorManager.getRandomPixelColor(resolution);

            // READ BORDER COLORS
            /* if (position.X < resX && position.Y == 0 && location == "TOPRIGHT")
             {
                 position.X += pixelRate;
                 topColors.Add(ColorManager.getColorAt(position));

             }
             else if (position.X == resX && position.Y < resY && location == "TOPRIGHT")
             {
                 position.Y += pixelRate;
                 rightColors.Add(ColorManager.getColorAt(position));

             }
             else
             {
                 if (location != "BOTTOMLEFT")
                 {
                     position.X = 0;
                     position.Y = 0;
                 }
                 location = "BOTTOMLEFT";

             }
             if (position.X == 0 && position.Y < resY && location == "BOTTOMLEFT")
             {
                 position.Y += pixelRate;
                 leftColors.Add(ColorManager.getColorAt(position));
             }
             else if (position.X < resX && position.Y == resY && location == "BOTTOMLEFT")
             {
                 position.X += pixelRate;
                 bottomColors.Add(ColorManager.getColorAt(position));
             } else if (position.X == resX && position.Y == resY && location == "BOTTOMLEFT")
             {
                 timer1.Enabled = false;
             }*/

            foreach(var data in colors)
            {
                switch (data.Key)
                {
                    case "topLeft":
                        topLeftPanel.BackColor = data.Value[0];
                        break;
                    case "topRight":
                        topRightPanel.BackColor = data.Value[0];
                        break;
                    case "bottomLeft":
                        botLeftPanel.BackColor = data.Value[0];
                        break;
                    case "bottomRight":
                        botRightPanel.BackColor = data.Value[0];
                        break;
                }

            }
           /* topLeftPanel.BackColor = colors[0].Value;*/
           /* mousePos.Text = $"X: {position.X} | Y: {position.Y}";*/


        }
    }
}
