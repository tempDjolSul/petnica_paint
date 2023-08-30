namespace paintproje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnPaint = new System.Windows.Forms.Button();
            this.BtnEllipse = new System.Windows.Forms.Button();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.BtnPencil);
            this.panel1.Controls.Add(this.BtnEraser);
            this.panel1.Controls.Add(this.BtnColor);
            this.panel1.Controls.Add(this.BtnPaint);
            this.panel1.Controls.Add(this.BtnEllipse);
            this.panel1.Controls.Add(this.BtnRectangle);
            this.panel1.Controls.Add(this.BtnLine);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnUndo
            // 
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUndo.Location = new System.Drawing.Point(610, 2);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(64, 19);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(360, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(454, 12);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // BtnPencil
            // 
            this.BtnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPencil.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPencil.Location = new System.Drawing.Point(3, 2);
            this.BtnPencil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(49, 40);
            this.BtnPencil.TabIndex = 8;
            this.BtnPencil.Text = "pencil";
            this.BtnPencil.UseVisualStyleBackColor = true;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // BtnEraser
            // 
            this.BtnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEraser.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEraser.Location = new System.Drawing.Point(49, 2);
            this.BtnEraser.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(49, 40);
            this.BtnEraser.TabIndex = 7;
            this.BtnEraser.Text = "eraser";
            this.BtnEraser.UseVisualStyleBackColor = true;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click);
            this.BtnEraser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnEraser_MouseClick);
            // 
            // BtnColor
            // 
            this.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColor.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnColor.Location = new System.Drawing.Point(94, 2);
            this.BtnColor.Margin = new System.Windows.Forms.Padding(2);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(49, 40);
            this.BtnColor.TabIndex = 6;
            this.BtnColor.Text = "color";
            this.BtnColor.UseVisualStyleBackColor = true;
            // 
            // BtnPaint
            // 
            this.BtnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaint.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPaint.Location = new System.Drawing.Point(140, 2);
            this.BtnPaint.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPaint.Name = "BtnPaint";
            this.BtnPaint.Size = new System.Drawing.Size(49, 40);
            this.BtnPaint.TabIndex = 5;
            this.BtnPaint.Text = "paint";
            this.BtnPaint.UseVisualStyleBackColor = true;
            this.BtnPaint.Click += new System.EventHandler(this.BtnPaint_Click);
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEllipse.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEllipse.Location = new System.Drawing.Point(186, 2);
            this.BtnEllipse.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEllipse.Name = "BtnEllipse";
            this.BtnEllipse.Size = new System.Drawing.Size(49, 40);
            this.BtnEllipse.TabIndex = 4;
            this.BtnEllipse.Text = "Ellipse";
            this.BtnEllipse.UseVisualStyleBackColor = true;
            this.BtnEllipse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnEllipse_MouseClick);
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangle.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnRectangle.Location = new System.Drawing.Point(232, 2);
            this.BtnRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(49, 40);
            this.BtnRectangle.TabIndex = 3;
            this.BtnRectangle.Text = "Rectangle";
            this.BtnRectangle.UseVisualStyleBackColor = true;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLine.Location = new System.Drawing.Point(278, 2);
            this.BtnLine.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(49, 40);
            this.BtnLine.TabIndex = 2;
            this.BtnLine.Text = "Line";
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClear.Location = new System.Drawing.Point(542, 24);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(64, 19);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSave.Location = new System.Drawing.Point(542, 2);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(64, 19);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pic
            // 
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(0, 45);
            this.Pic.Margin = new System.Windows.Forms.Padding(2);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(682, 417);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Click += new System.EventHandler(this.Pic_Click);
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 462);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnPencil;
        private System.Windows.Forms.Button BtnEraser;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnPaint;
        private System.Windows.Forms.Button BtnEllipse;
        private System.Windows.Forms.Button BtnRectangle;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button btnUndo;

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

