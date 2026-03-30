namespace WinFormsSparkline
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sparkLine1 = new Syncfusion.Windows.Forms.Chart.SparkLine();
            this.sparkLine1.LineStyle.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.sparkLine1.Markers.ShowMarker = true;
            sparkLine1.Text = "Sprkline";
            this.SuspendLayout();
            // 
            // sparkLine1
            // 
            this.sparkLine1.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.sparkLine1.EndPoint = 10D;
            this.sparkLine1.HighPoint = 90D;
            this.sparkLine1.Location = new System.Drawing.Point(55, 48);
            this.sparkLine1.LowPoint = 10D;
            this.sparkLine1.Name = "sparkLine1";

            this.sparkLine1.Size = new System.Drawing.Size(396, 276);
            this.sparkLine1.Source = new double[] { 20, 90, 30, 60, 10, -50, 70, -40, 10 };
            this.sparkLine1.StartPoint = 20D;
            this.sparkLine1.TabIndex = 0;
            this.sparkLine1.Text = "sparkLine1";
            this.sparkLine1.Type = Syncfusion.Windows.Forms.Chart.SparkLineType.Line;
            // 
            // Form1
            // 

            this.sparkLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 603);
            this.Controls.Add(this.sparkLine1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.SparkLine sparkLine1;
    }
}
