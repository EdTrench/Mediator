namespace Mediator.View.RiderRaces
{
    partial class RiderRaces
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.races = new Framework.UserControls.RacesForRider();
            this.riders = new Framework.UserControls.Riders();
            this.SuspendLayout();
            // 
            // races
            // 
            this.races.Location = new System.Drawing.Point(3, 41);
            this.races.Name = "races";
            this.races.Size = new System.Drawing.Size(320, 142);
            this.races.TabIndex = 4;
            // 
            // riders
            // 
            this.riders.Location = new System.Drawing.Point(12, 8);
            this.riders.Name = "riders";
            this.riders.Size = new System.Drawing.Size(320, 27);
            this.riders.TabIndex = 3;
            // 
            // RiderRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.races);
            this.Controls.Add(this.riders);
            this.Name = "RiderRaces";
            this.Size = new System.Drawing.Size(347, 194);
            this.ResumeLayout(false);

        }

        #endregion

        public Framework.UserControls.RacesForRider races;
        public Framework.UserControls.Riders riders;
    }
}
