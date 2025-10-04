
// External Libraries
using System;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;

// BOOSE libraries
using BOOSE;
using BOOSECoreApp;

namespace BOOSECoreApp
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class and its components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        }

        private Bitmap canvasBitmap = null!;

        /// <summary>
        /// Handles form load events and initializes a blank bitmap canvas for rendering.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise a blank canvas
            canvasBitmap = new Bitmap(outputCanvas.Width, outputCanvas.Height);
            outputCanvas.Image = canvasBitmap;
        }

        /// <summary>
        /// Executes the BOOSE program from the input textbox and updates the canvas with the result.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data.</param>
        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Run BOOSE program on bitmap
                String booseCode = txtProgram.Text;

                // Clear canvas
                Bitmap bmp = BOOSEWrapper.RunProgram(booseCode, outputCanvas.Width, outputCanvas.Height);

                // Display the result in the pictureBox
                outputCanvas.Image = bmp;
                outputCanvas.Refresh();
            }
            catch (Exception ex)
            {
                // Show any unexpected errors in console
                Console.WriteLine($"Error running BOOSE program :\n{ex.Message}");
            }

        }

        /// <summary>
        /// Clears the program input textbox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data.</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            txtProgram.Clear();
        }

        /// <summary>
        /// Handles changes to the program input textbox {currently stubbed ~ Change later}.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data.</param>
        private void txtProgram_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles clicks on the canvas display {currently stubbed ~ Change later}.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data.</param>
        private void outputCanvas_Click(object sender, EventArgs e)
        {

        }

    }
}
