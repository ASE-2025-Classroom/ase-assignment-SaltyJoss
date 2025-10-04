using BOOSE;

namespace BOOSECoreApp.Core.Base
{
    /// <summary>
    /// A base class serving as the foundation for all drawing operations using the BOOSE framework.
    /// Implements <see cref="ICanvas"/> interface, providing a bitmap object as a drawing surface.
    /// </summary> 
    public abstract class CanvasBase : ICanvas
    {

        public Bitmap bitmap;
        public Graphics graphics;
        public Brush brush = Brushes.Black;
        private Color penColour = Color.Black;

        public int Xpos { get; set; } = 0;
        public int Ypos { get; set; } = 0;

        public object PenColour { get { return penColour; } set { penColour = (Color)value; brush = new SolidBrush(penColour); } }

        /// <summary>Sets the pen color using RGB values and updates the brush.</summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        public void SetColour(int r, int g, int b) { penColour = Color.FromArgb(r, g, b); brush = new SolidBrush(penColour); }


        // Abstract Methods for Concrete Implementation

        /// <summary>Moves the current drawing position to the specified coordinates.</summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public virtual void MoveTo(int x, int y) { Xpos = x; Ypos = y; }

        /// <summary>Draws a line from the current position to the specified coordinates.</summary>
        /// <param name="x">X coordinate of the endpoint</param>
        /// <param name="y">Y coordinate of the endpoint</param>
        public virtual void DrawTo(int x, int y) {/* stub */}
        
        /// <summary>Draws a circle at the current position with the specified radius.</summary>
        /// <param name="radius">Circle radius</param>
        /// <param name="filled">Whether the circle is filled</param>
        public virtual void Circle(int radius, bool filled) {/* stub */}
        
        /// <summary>Draws a triangle at the current position with given width and height.</summary>
        /// <param name="width">Triangle width</param>
        /// <param name="height">Triangle height</param>
        public virtual void Tri(int width, int height) {/* stub */}
        
        /// <summary>Draws a rectangle at the current position.</summary>
        /// <param name="width">Rectangle width</param>
        /// <param name="height">Rectangle height</param>
        /// <param name="filled">Whether the rectangle is filled</param>
        public virtual void Rect(int width, int height, bool filled) {/* stub */}
        
        /// <summary>Writes text at the current drawing position.</summary>
        /// <param name="text">Text to draw</param>
        public virtual void WriteText(String text) {/* stub */}
        
        /// <summary>Clears the canvas to a blank state.</summary>
        public virtual void Clear() {/* stub */}
        
        /// <summary>Resets the canvas state including position and brush.</summary>
        public virtual void Reset() {/* stub */}
        
        /// <summary>Initializes or resizes the canvas to specified width and height.</summary>
        /// <param name="width">Canvas width</param>
        /// <param name="height">Canvas height</param>
        public virtual void Set(int width, int height) {/* stub */}
        
        /// <summary>Draws text at the current position using the default system font.</summary>
        /// <param name="text">Text to draw</param>
        public virtual void DrawText(string text) { graphics.DrawString(text, SystemFonts.DefaultFont, brush, Xpos, Ypos); }
        
        /// <summary>Returns the underlying bitmap representing the canvas content.</summary>
        /// <returns>The current <see cref="Bitmap"/> of the canvas</returns>
        public virtual object getBitmap() => bitmap;

    }
}
