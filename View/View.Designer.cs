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
            ((System.ComponentModel.ISupportInitialize)(this.mainImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(57, 356);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(145, 43);
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
            this.mainImageBox.Location = new System.Drawing.Point(12, 115);
            this.mainImageBox.Name = "mainImageBox";
            this.mainImageBox.Size = new System.Drawing.Size(240, 224);
            this.mainImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainImageBox.TabIndex = 1;
            this.mainImageBox.TabStop = false;
            // 
            // openRGBChartButton
            // 
            this.openRGBChartButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openRGBChartButton.Location = new System.Drawing.Point(57, 424);
            this.openRGBChartButton.Name = "openRGBChartButton";
            this.openRGBChartButton.Size = new System.Drawing.Size(145, 40);
            this.openRGBChartButton.TabIndex = 3;
            this.openRGBChartButton.Text = "Show RGBChart";
            this.openRGBChartButton.UseVisualStyleBackColor = true;
            this.openRGBChartButton.Click += new System.EventHandler(this.openRGBChartButton_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 476);
            this.Controls.Add(this.openRGBChartButton);
            this.Controls.Add(this.mainImageBox);
            this.Controls.Add(this.openImageButton);
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
    }
}

