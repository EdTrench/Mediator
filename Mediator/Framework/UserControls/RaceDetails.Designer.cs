namespace Mediator.Framework.UserControls
{
    partial class RaceDetails
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
            this.lblRaceName = new System.Windows.Forms.Label();
            this.txtRaceName = new System.Windows.Forms.TextBox();
            this.txtRaceLength = new System.Windows.Forms.TextBox();
            this.lblRaceLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRaceName
            // 
            this.lblRaceName.AutoSize = true;
            this.lblRaceName.Location = new System.Drawing.Point(8, 12);
            this.lblRaceName.Name = "lblRaceName";
            this.lblRaceName.Size = new System.Drawing.Size(38, 13);
            this.lblRaceName.TabIndex = 0;
            this.lblRaceName.Text = "Name:";
            // 
            // txtRaceName
            // 
            this.txtRaceName.Location = new System.Drawing.Point(62, 9);
            this.txtRaceName.Name = "txtRaceName";
            this.txtRaceName.Size = new System.Drawing.Size(128, 20);
            this.txtRaceName.TabIndex = 1;
            // 
            // txtRaceLength
            // 
            this.txtRaceLength.Location = new System.Drawing.Point(62, 35);
            this.txtRaceLength.Name = "txtRaceLength";
            this.txtRaceLength.Size = new System.Drawing.Size(128, 20);
            this.txtRaceLength.TabIndex = 3;
            // 
            // lblRaceLength
            // 
            this.lblRaceLength.AutoSize = true;
            this.lblRaceLength.Location = new System.Drawing.Point(8, 38);
            this.lblRaceLength.Name = "lblRaceLength";
            this.lblRaceLength.Size = new System.Drawing.Size(43, 13);
            this.lblRaceLength.TabIndex = 2;
            this.lblRaceLength.Text = "Length:";
            // 
            // RaceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRaceLength);
            this.Controls.Add(this.lblRaceLength);
            this.Controls.Add(this.txtRaceName);
            this.Controls.Add(this.lblRaceName);
            this.Name = "RaceDetails";
            this.Size = new System.Drawing.Size(207, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaceName;
        private System.Windows.Forms.TextBox txtRaceName;
        private System.Windows.Forms.TextBox txtRaceLength;
        private System.Windows.Forms.Label lblRaceLength;
    }
}
