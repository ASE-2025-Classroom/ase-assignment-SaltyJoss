
using BOOSE;
using BOOSECoreApp.UI;

using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSECoreApp
{
    public class BOOSEWrapper
    {

    }

    /// <summary>
    /// Implementation class of BOOSE's ICanvas interface, providing a bitmap object as a drawing surface.
    /// Utilising System.Drawing API to enable many graphical operations {see BOOSE ICanvas Docs}
    /// </summary>
    public class BitmapCanvas : ICanvas
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private Brush brush = Brushes.Black;
        private Color penColour = Color.Black;

        // Get and Set pen colours
        public object PenColour { get { return penColour; } set { penColour = (Color)value; brush = new SolidBrush(penColour); } }
        public void SetColour(int r, int g, int b) { penColour = Color.FromArgb(r, g, b); brush = new SolidBrush(penColour); }

        // Get and Set x-, y-position
        public int Xpos { get; set; } = 0;
        public int Ypos { get; set; } = 0;

        //
        public BitmapCanvas(Bitmap bmp)
        {
            bitmap = bmp;
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
        }

        // Methods for ICanvas
        public void MoveTo(int x, int y) { Xpos = x; Ypos = y; }
        public void DrawTo(int x, int y) {/* stub */}
        public void Circle(int radius, bool filled) {/* stub */}
        public void Tri(int width, int height) {/* stub */}
        public void Rect(int width, int height, bool filled) {/* stub */}
        public void WriteText(String text) {/* stub */}
        public void Clear() {/* stub */}
        public void Reset() {/* stub */}
        public void Set(int width, int height) {/* stub */}

        // Helper for About Tex
        public void DrawText(string text) { graphics.DrawString(text, SystemFonts.DefaultFont, brush, Xpos, Ypos); }

        public object getBitmap() { return bitmap; }

    }
}
