namespace Mediator.Framework.UserControls
{
    partial class RacesForRider
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
            this.lstRaces = new System.Windows.Forms.ListBox();
            this.lblRaces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRaces
            // 
            this.lstRaces.FormattingEnabled = true;
            this.lstRaces.Location = new System.Drawing.Point(50, 5);
            this.lstRaces.Name = "lstRaces";
            this.lstRaces.Size = new System.Drawing.Size(267, 134);
            this.lstRaces.TabIndex = 0;
            // 
            // lblRaces
            // 
            this.lblRaces.AutoSize = true;
            this.lblRaces.Location = new System.Drawing.Point(4, 5);
            this.lblRaces.Name = "lblRaces";
            this.lblRaces.Size = new System.Drawing.Size(41, 13);
            this.lblRaces.TabIndex = 1;
            this.lblRaces.Text = "Races:";
            // 
            // RidersInRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRaces);
            this.Controls.Add(this.lstRaces);
            this.Name = "RidersInRace";
            this.Size = new System.Drawing.Size(320, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRaces;
        private System.Windows.Forms.Label lblRaces;
    }
}
