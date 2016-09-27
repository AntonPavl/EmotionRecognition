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
            ((System.ComponentModel.ISupportInitialize)(this.mainImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(36, 497);
            this.openImageButton.Margin = new System.Windows.Forms.Padding(4);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(149, 53);
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
            this.mainImageBox.Location = new System.Drawing.Point(36, 13);
            this.mainImageBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainImageBox.Name = "mainImageBox";
            this.mainImageBox.Size = new System.Drawing.Size(536, 462);
            this.mainImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImageBox.TabIndex = 1;
            this.mainImageBox.TabStop = false;
            // 
            // openRGBChartButton
            // 
            this.openRGBChartButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openRGBChartButton.Location = new System.Drawing.Point(36, 583);
            this.openRGBChartButton.Margin = new System.Windows.Forms.Padding(4);
            this.openRGBChartButton.Name = "openRGBChartButton";
            this.openRGBChartButton.Size = new System.Drawing.Size(149, 49);
            this.openRGBChartButton.TabIndex = 3;
            this.openRGBChartButton.Text = "Show RGBChart";
            this.openRGBChartButton.UseVisualStyleBackColor = true;
            this.openRGBChartButton.Click += new System.EventHandler(this.openRGBChartButton_Click);
            // 
            // negativeFilter
            // 
            this.negativeFilter.Location = new System.Drawing.Point(214, 497);
            this.negativeFilter.Name = "negativeFilter";
            this.negativeFilter.Size = new System.Drawing.Size(187, 53);
            this.negativeFilter.TabIndex = 4;
            this.negativeFilter.Text = "Negative";
            this.negativeFilter.UseVisualStyleBackColor = true;
            this.negativeFilter.Click += new System.EventHandler(this.negativeFilter_Click);
            // 
            // lowFreqFilter
            // 
            this.lowFreqFilter.Location = new System.Drawing.Point(214, 583);
            this.lowFreqFilter.Name = "lowFreqFilter";
            this.lowFreqFilter.Size = new System.Drawing.Size(187, 49);
            this.lowFreqFilter.TabIndex = 5;
            this.lowFreqFilter.Text = "Low Freq Filter";
            this.lowFreqFilter.UseVisualStyleBackColor = true;
            this.lowFreqFilter.Click += new System.EventHandler(this.lowFreqFilter_Click);
            // 
            // binaryFilter
            // 
            this.binaryFilter.Location = new System.Drawing.Point(433, 497);
            this.binaryFilter.Name = "binaryFilter";
            this.binaryFilter.Size = new System.Drawing.Size(139, 53);
            this.binaryFilter.TabIndex = 6;
            this.binaryFilter.Text = "Binarization";
            this.binaryFilter.UseVisualStyleBackColor = true;
            this.binaryFilter.Click += new System.EventHandler(this.binaryFilter_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 670);
            this.Controls.Add(this.binaryFilter);
            this.Controls.Add(this.lowFreqFilter);
            this.Controls.Add(this.negativeFilter);
            this.Controls.Add(this.openRGBChartButton);
            this.Controls.Add(this.mainImageBox);
            this.Controls.Add(this.openImageButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.PictureBox mainImageBox;
        private System.Windows.Forms.Button openRGBChartButton;
        private System.Windows.Forms.Button negativeFilter;
        private System.Windows.Forms.Button lowFreqFilter;
        private System.Windows.Forms.Button binaryFilter;
    }
}

