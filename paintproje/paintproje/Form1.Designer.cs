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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnReactangle = new System.Windows.Forms.Button();
            this.BtnPaint = new System.Windows.Forms.Button();
            this.BtnEllipse = new System.Windows.Forms.Button();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.BtnPencil);
            this.panel1.Controls.Add(this.BtnEraser);
            this.panel1.Controls.Add(this.BtnColor);
            this.panel1.Controls.Add(this.BtnPaint);
            this.panel1.Controls.Add(this.BtnEllipse);
            this.panel1.Controls.Add(this.BtnReactangle);
            this.panel1.Controls.Add(this.BtnLine);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSave.Location = new System.Drawing.Point(723, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(85, 23);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClear.Location = new System.Drawing.Point(723, 29);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(85, 23);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // BtnLine
            // 
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLine.Location = new System.Drawing.Point(370, 3);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(65, 49);
            this.BtnLine.TabIndex = 2;
            this.BtnLine.Text = "Line";
            this.BtnLine.UseVisualStyleBackColor = true;
            // 
            // BtnReactangle
            // 
            this.BtnReactangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReactangle.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnReactangle.Location = new System.Drawing.Point(309, 3);
            this.BtnReactangle.Name = "BtnReactangle";
            this.BtnReactangle.Size = new System.Drawing.Size(65, 49);
            this.BtnReactangle.TabIndex = 3;
            this.BtnReactangle.Text = "Reactangle";
            this.BtnReactangle.UseVisualStyleBackColor = true;
            // 
            // BtnPaint
            // 
            this.BtnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaint.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPaint.Location = new System.Drawing.Point(187, 3);
            this.BtnPaint.Name = "BtnPaint";
            this.BtnPaint.Size = new System.Drawing.Size(65, 49);
            this.BtnPaint.TabIndex = 5;
            this.BtnPaint.Text = "paint";
            this.BtnPaint.UseVisualStyleBackColor = true;
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEllipse.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEllipse.Location = new System.Drawing.Point(248, 3);
            this.BtnEllipse.Name = "BtnEllipse";
            this.BtnEllipse.Size = new System.Drawing.Size(65, 49);
            this.BtnEllipse.TabIndex = 4;
            this.BtnEllipse.Text = "Ellipse";
            this.BtnEllipse.UseVisualStyleBackColor = true;
            // 
            // BtnEraser
            // 
            this.BtnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEraser.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEraser.Location = new System.Drawing.Point(65, 3);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(65, 49);
            this.BtnEraser.TabIndex = 7;
            this.BtnEraser.Text = "eraser";
            this.BtnEraser.UseVisualStyleBackColor = true;
            // 
            // BtnColor
            // 
            this.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColor.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnColor.Location = new System.Drawing.Point(126, 3);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(65, 49);
            this.BtnColor.TabIndex = 6;
            this.BtnColor.Text = "color";
            this.BtnColor.UseVisualStyleBackColor = true;
            // 
            // BtnPencil
            // 
            this.BtnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPencil.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPencil.Location = new System.Drawing.Point(4, 3);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(65, 49);
            this.BtnPencil.TabIndex = 8;
            this.BtnPencil.Text = "pencil";
            this.BtnPencil.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 395);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button BtnReactangle;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

