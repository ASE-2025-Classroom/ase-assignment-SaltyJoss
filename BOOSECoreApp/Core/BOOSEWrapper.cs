
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
    /// <summary>
    /// Provides a high-level interface for executing BOOSE drawing programs.
    /// </summary>
    /// <remarks>
    /// The <see cref="BOOSEWrapper"/> class serves as a bridge between the BOOSE command language
    /// and the underlying graphics system. It exposes static methods for parsing and executing BOOSE
    /// instructions on a <see cref="BitmapCanvas"/>, returning a rendered <see cref="Bitmap"/> image
    /// that visually represents the program output.
    /// 
    /// This wrapper encapsulates setup, parsing, execution, and error handling, allowing client code
    /// (such as a Windows Forms interface) to run BOOSE programs without managing parser, factory, or
    /// canvas initialization directly.
    /// </remarks>
    public class BOOSEWrapper
    {
        /// <summary>
        /// A static method that interprets and executes BOOSE-commands as a drawing program on a bitmap canvas
        /// Returns the resulting bitmap image.
        /// </summary>
        /// <param name="code">The BOOSE program to parse and execute</param>
        /// <param name="width">The width of the output bitmap in pixels</param>
        /// <param name="height">The height of the output bitmap in pixels</param>
        /// <returns>
        /// A <see cref="Bitmap"/> object representing the final rendered state of the canvas
        /// after executing all BOOSE commands.
        /// </returns>
        /// <remarks>
        /// It safely handles <see cref="ParserException"/>, <see cref="BOOSEException"/>, and generic
        /// <see cref="Exception"/> types to prevent runtime failures, logging diagnostic information
        /// for debugging purposes.
        /// </remarks>
        public static Bitmap RunProgram(string code, int width, int height)
        {
            var bitmap = new Bitmap(width, height);
            var canvas = new BitmapCanvas(bitmap);

            try
            {
                var storedProgram = new StoredProgram(canvas);
                var factory = new CommandFactory();
                var parser = new Parser(factory, storedProgram);

                var program = parser.ParseCommand(code);
                program.Execute();
            }
            catch (ParserException ex)
            {
                System.Diagnostics.Debug.WriteLine($"PARSE Error: {ex.Message}");
            }
            catch (BOOSEException ex)
            {
                System.Diagnostics.Debug.WriteLine($"BOOSE Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"UNEXPECTED Error: {ex.Message}");
            }

            return bitmap;
        }
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
