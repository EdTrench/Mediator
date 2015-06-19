namespace Mediator.Framework.UserControls
{
    partial class RidersInRace
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
            this.lstRiders = new System.Windows.Forms.ListBox();
            this.lblRiders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRiders
            // 
            this.lstRiders.FormattingEnabled = true;
            this.lstRiders.Location = new System.Drawing.Point(50, 5);
            this.lstRiders.Name = "lstRiders";
            this.lstRiders.Size = new System.Drawing.Size(267, 134);
            this.lstRiders.TabIndex = 0;
            // 
            // lblRiders
            // 
            this.lblRiders.AutoSize = true;
            this.lblRiders.Location = new System.Drawing.Point(4, 5);
            this.lblRiders.Name = "lblRiders";
            this.lblRiders.Size = new System.Drawing.Size(40, 13);
            this.lblRiders.TabIndex = 1;
            this.lblRiders.Text = "Riders:";
            // 
            // RidersInRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRiders);
            this.Controls.Add(this.lstRiders);
            this.Name = "RidersInRace";
            this.Size = new System.Drawing.Size(320, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRiders;
        private System.Windows.Forms.Label lblRiders;
    }
}
