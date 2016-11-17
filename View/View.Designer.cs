namespace View
{
    partial class View
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
            this.openImageButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainImageBox = new System.Windows.Forms.PictureBox();
            this.openRGBChartButton = new System.Windows.Forms.Button();
            this.negativeFilter = new System.Windows.Forms.Button();
            this.lowFreqFilter = new System.Windows.Forms.Button();
            this.binaryFilter = new System.Windows.Forms.Button();
            this.originalImageOpenButton = new System.Windows.Forms.Button();
            this.brightBar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.openClassDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightBar)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(27, 404);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(112, 43);
            this.openImageButton.TabIndex = 0;
            this.openImageButton.Text = "Open Image";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openImageDialog";
            // 
            // mainImageBox
            // 
            this.mainImageBox.Location = new System.Drawing.Point(27, 11);
            this.mainImageBox.Name = "mainImageBox";
            this.mainImageBox.Size = new System.Drawing.Size(402, 375);
            this.mainImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImageBox.TabIndex = 1;
            this.mainImageBox.TabStop = false;
            // 
            // openRGBChartButton
            // 
            this.openRGBChartButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openRGBChartButton.Location = new System.Drawing.Point(27, 474);
            this.openRGBChartButton.Name = "openRGBChartButton";
            this.openRGBChartButton.Size = new System.Drawing.Size(112, 40);
            this.openRGBChartButton.TabIndex = 3;
            this.openRGBChartButton.Text = "Show RGBChart";
            this.openRGBChartButton.UseVisualStyleBackColor = true;
            this.openRGBChartButton.Click += new System.EventHandler(this.openRGBChartButton_Click);
            // 
            // negativeFilter
            // 
            this.negativeFilter.Location = new System.Drawing.Point(160, 404);
            this.negativeFilter.Margin = new System.Windows.Forms.Padding(2);
            this.negativeFilter.Name = "negativeFilter";
            this.negativeFilter.Size = new System.Drawing.Size(140, 43);
            this.negativeFilter.TabIndex = 4;
            this.negativeFilter.Text = "Negative";
            this.negativeFilter.UseVisualStyleBackColor = true;
            this.negativeFilter.Click += new System.EventHandler(this.negativeFilter_Click);
            // 
            // lowFreqFilter
            // 
            this.lowFreqFilter.Location = new System.Drawing.Point(160, 474);
            this.lowFreqFilter.Margin = new System.Windows.Forms.Padding(2);
            this.lowFreqFilter.Name = "lowFreqFilter";
            this.lowFreqFilter.Size = new System.Drawing.Size(140, 40);
            this.lowFreqFilter.TabIndex = 5;
            this.lowFreqFilter.Text = "Low Freq Filter";
            this.lowFreqFilter.UseVisualStyleBackColor = true;
            this.lowFreqFilter.Click += new System.EventHandler(this.lowFreqFilter_Click);
            // 
            // binaryFilter
            // 
            this.binaryFilter.Location = new System.Drawing.Point(325, 404);
            this.binaryFilter.Margin = new System.Windows.Forms.Padding(2);
            this.binaryFilter.Name = "binaryFilter";
            this.binaryFilter.Size = new System.Drawing.Size(104, 43);
            this.binaryFilter.TabIndex = 6;
            this.binaryFilter.Text = "Binarization";
            this.binaryFilter.UseVisualStyleBackColor = true;
            this.binaryFilter.Click += new System.EventHandler(this.binaryFilter_Click);
            // 
            // originalImageOpenButton
            // 
            this.originalImageOpenButton.Location = new System.Drawing.Point(329, 477);
            this.originalImageOpenButton.Name = "originalImageOpenButton";
            this.originalImageOpenButton.Size = new System.Drawing.Size(99, 36);
            this.originalImageOpenButton.TabIndex = 7;
            this.originalImageOpenButton.Text = "OpenOriginal";
            this.originalImageOpenButton.UseVisualStyleBackColor = true;
            this.originalImageOpenButton.Click += new System.EventHandler(this.openOriginalImage_Click);
            // 
            // brightBar
            // 
            this.brightBar.Location = new System.Drawing.Point(447, 49);
            this.brightBar.Maximum = 255;
            this.brightBar.Name = "brightBar";
            this.brightBar.Size = new System.Drawing.Size(137, 45);
            this.brightBar.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openClassDialog
            // 
            this.openClassDialog.FileName = "openClassDialog";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 75);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 549);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.brightBar);
            this.Controls.Add(this.originalImageOpenButton);
            this.Controls.Add(this.binaryFilter);
            this.Controls.Add(this.lowFreqFilter);
            this.Controls.Add(this.negativeFilter);
            this.Controls.Add(this.openRGBChartButton);
            this.Controls.Add(this.mainImageBox);
            this.Controls.Add(this.openImageButton);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.PictureBox mainImageBox;
        private System.Windows.Forms.Button openRGBChartButton;
        private System.Windows.Forms.Button negativeFilter;
        private System.Windows.Forms.Button lowFreqFilter;
        private System.Windows.Forms.Button binaryFilter;
        private System.Windows.Forms.Button originalImageOpenButton;
        private System.Windows.Forms.TrackBar brightBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openClassDialog;
        private System.Windows.Forms.Button button2;
    }
}

