﻿namespace Mediator.View.BaseForms
{
    partial class BaseForm
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
            this.HostMainPanel = new Framework.UserControls.HostPanel();
            this.SuspendLayout();
            // 
            // HostMainPanel
            // 
            this.HostMainPanel.Location = new System.Drawing.Point(3, 3);
            this.HostMainPanel.Name = "HostMainPanel";
            this.HostMainPanel.Size = new System.Drawing.Size(326, 237);
            this.HostMainPanel.TabIndex = 0;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 241);
            this.Controls.Add(this.HostMainPanel);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        public Framework.UserControls.HostPanel HostMainPanel;
    }
}