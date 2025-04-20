namespace ТаксиМастер
{
    partial class TripsForm
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
            this.panelTrips = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelTrips
            // 
            this.panelTrips.AutoScroll = true;
            this.panelTrips.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelTrips.Location = new System.Drawing.Point(12, 12);
            this.panelTrips.Name = "panelTrips";
            this.panelTrips.Size = new System.Drawing.Size(480, 472);
            this.panelTrips.TabIndex = 11;
            // 
            // TripsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 496);
            this.Controls.Add(this.panelTrips);
            this.Name = "TripsForm";
            this.Text = "История поездок";
            this.Load += new System.EventHandler(this.TripsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelTrips;
    }
}