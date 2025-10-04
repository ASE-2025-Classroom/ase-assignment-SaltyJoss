namespace BOOSECoreApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            printDialog1 = new PrintDialog();
            txtProgram = new TextBox();
            outputCanvas = new PictureBox();
            clearButton = new Button();
            runButton = new Button();
            saveButton = new Button();
            loadButton = new Button();
            textDebug = new TextBox();
            resetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)outputCanvas).BeginInit();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // txtProgram
            // 
            txtProgram.Location = new Point(12, 12);
            txtProgram.Multiline = true;
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(426, 1017);
            txtProgram.TabIndex = 0;
            txtProgram.TextChanged += txtProgram_TextChanged;
            // 
            // outputCanvas
            // 
            outputCanvas.Location = new Point(444, 12);
            outputCanvas.Name = "outputCanvas";
            outputCanvas.Size = new Size(1448, 668);
            outputCanvas.TabIndex = 1;
            outputCanvas.TabStop = false;
            outputCanvas.Click += outputCanvas_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(444, 975);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(210, 54);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // runButton
            // 
            runButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            runButton.Location = new Point(444, 905);
            runButton.Name = "runButton";
            runButton.Size = new Size(210, 54);
            runButton.TabIndex = 2;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(444, 695);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(210, 54);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            loadButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadButton.Location = new Point(444, 765);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(210, 54);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            // 
            // textDebug
            // 
            textDebug.Location = new Point(660, 695);
            textDebug.Multiline = true;
            textDebug.Name = "textDebug";
            textDebug.Size = new Size(1232, 334);
            textDebug.TabIndex = 6;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(444, 835);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(210, 54);
            resetButton.TabIndex = 8;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1904, 1041);
            Controls.Add(resetButton);
            Controls.Add(textDebug);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(clearButton);
            Controls.Add(runButton);
            Controls.Add(outputCanvas);
            Controls.Add(txtProgram);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)outputCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintDialog printDialog1;
        private TextBox txtProgram;
        private PictureBox outputCanvas;
        private Button clearButton;
        private Button runButton;
        private Button saveButton;
        private Button loadButton;
        private TextBox textDebug;
        private Button resetButton;
    }
}
