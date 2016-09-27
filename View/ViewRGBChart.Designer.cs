namespace View
{
    partial class ViewRGBChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.imageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.redCheckBox = new System.Windows.Forms.CheckBox();
            this.greenCheckBox = new System.Windows.Forms.CheckBox();
            this.blueCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageChart)).BeginInit();
            this.SuspendLayout();
            // 
            // imageChart
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Maximum = 256D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.imageChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.imageChart.Legends.Add(legend2);
            this.imageChart.Location = new System.Drawing.Point(16, 15);
            this.imageChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageChart.Name = "imageChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "R";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Color = System.Drawing.Color.Lime;
            series5.Legend = "Legend1";
            series5.Name = "G";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.Legend = "Legend1";
            series6.Name = "B";
            this.imageChart.Series.Add(series4);
            this.imageChart.Series.Add(series5);
            this.imageChart.Series.Add(series6);
            this.imageChart.Size = new System.Drawing.Size(1032, 556);
            this.imageChart.TabIndex = 3;
            this.imageChart.Text = "chart1";
            // 
            // redCheckBox
            // 
            this.redCheckBox.AutoSize = true;
            this.redCheckBox.Checked = true;
            this.redCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redCheckBox.Location = new System.Drawing.Point(1072, 27);
            this.redCheckBox.Name = "redCheckBox";
            this.redCheckBox.Size = new System.Drawing.Size(56, 21);
            this.redCheckBox.TabIndex = 4;
            this.redCheckBox.Text = "Red";
            this.redCheckBox.UseVisualStyleBackColor = true;
            this.redCheckBox.CheckedChanged += new System.EventHandler(this.redCheckBox_CheckedChanged);
            // 
            // greenCheckBox
            // 
            this.greenCheckBox.AutoSize = true;
            this.greenCheckBox.Checked = true;
            this.greenCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.greenCheckBox.Location = new System.Drawing.Point(1072, 55);
            this.greenCheckBox.Name = "greenCheckBox";
            this.greenCheckBox.Size = new System.Drawing.Size(70, 21);
            this.greenCheckBox.TabIndex = 5;
            this.greenCheckBox.Text = "Green";
            this.greenCheckBox.UseVisualStyleBackColor = true;
            this.greenCheckBox.CheckedChanged += new System.EventHandler(this.greenCheckBox_CheckedChanged);
            // 
            // blueCheckBox
            // 
            this.blueCheckBox.AutoSize = true;
            this.blueCheckBox.Checked = true;
            this.blueCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueCheckBox.Location = new System.Drawing.Point(1072, 83);
            this.blueCheckBox.Name = "blueCheckBox";
            this.blueCheckBox.Size = new System.Drawing.Size(58, 21);
            this.blueCheckBox.TabIndex = 6;
            this.blueCheckBox.Text = "Blue";
            this.blueCheckBox.UseVisualStyleBackColor = true;
            this.blueCheckBox.CheckedChanged += new System.EventHandler(this.blueCheckBox_CheckedChanged);
            // 
            // ViewRGBChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 591);
            this.Controls.Add(this.blueCheckBox);
            this.Controls.Add(this.greenCheckBox);
            this.Controls.Add(this.redCheckBox);
            this.Controls.Add(this.imageChart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewRGBChart";
            this.Text = "ViewRGBChart";
            ((System.ComponentModel.ISupportInitialize)(this.imageChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart imageChart;
        private System.Windows.Forms.CheckBox redCheckBox;
        private System.Windows.Forms.CheckBox greenCheckBox;
        private System.Windows.Forms.CheckBox blueCheckBox;
    }
}