namespace Mediator
{
    partial class MainForm
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
            this.raceDetails1 = new Framework.UserControls.RaceDetails();
            this.ridersInRace1 = new Framework.UserControls.RidersInRace();
            this.races1 = new Framework.UserControls.Races();
            this.SuspendLayout();
            // 
            // raceDetails1
            // 
            this.raceDetails1.Location = new System.Drawing.Point(12, 64);
            this.raceDetails1.Name = "raceDetails1";
            this.raceDetails1.Size = new System.Drawing.Size(207, 62);
            this.raceDetails1.TabIndex = 2;
            // 
            // ridersInRace1
            // 
            this.ridersInRace1.Location = new System.Drawing.Point(12, 132);
            this.ridersInRace1.Name = "ridersInRace1";
            this.ridersInRace1.Size = new System.Drawing.Size(320, 142);
            this.ridersInRace1.TabIndex = 1;
            // 
            // races1
            // 
            this.races1.Location = new System.Drawing.Point(12, 11);
            this.races1.Name = "races1";
            this.races1.Size = new System.Drawing.Size(287, 27);
            this.races1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 289);
            this.Controls.Add(this.raceDetails1);
            this.Controls.Add(this.ridersInRace1);
            this.Controls.Add(this.races1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.UserControls.Races races1;
        private Framework.UserControls.RidersInRace ridersInRace1;
        private Framework.UserControls.RaceDetails raceDetails1;
    }
}

