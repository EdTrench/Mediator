namespace Mediator.Framework.UserControls
{
    partial class Races
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
            this.cboRiders = new System.Windows.Forms.ComboBox();
            this.lblRider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboRiders
            // 
            this.cboRiders.FormattingEnabled = true;
            this.cboRiders.Location = new System.Drawing.Point(44, 3);
            this.cboRiders.Name = "cboRiders";
            this.cboRiders.Size = new System.Drawing.Size(240, 21);
            this.cboRiders.TabIndex = 0;
            this.cboRiders.SelectedIndexChanged += new System.EventHandler(this.cboRiders_SelectedIndexChanged);
            // 
            // lblRider
            // 
            this.lblRider.AutoSize = true;
            this.lblRider.Location = new System.Drawing.Point(3, 6);
            this.lblRider.Name = "lblRider";
            this.lblRider.Size = new System.Drawing.Size(35, 13);
            this.lblRider.TabIndex = 1;
            this.lblRider.Text = "Rider:";
            // 
            // Races
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRider);
            this.Controls.Add(this.cboRiders);
            this.Name = "Races";
            this.Size = new System.Drawing.Size(287, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRiders;
        private System.Windows.Forms.Label lblRider;
    }
}
