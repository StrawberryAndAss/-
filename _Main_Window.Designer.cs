namespace 智能工时系统
{
    partial class _Main_Window
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
            this.Depiction_2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Depiction_2
            // 
            this.Depiction_2.AutoSize = true;
            this.Depiction_2.Location = new System.Drawing.Point(0, 326);
            this.Depiction_2.Name = "Depiction_2";
            this.Depiction_2.Size = new System.Drawing.Size(320, 19);
            this.Depiction_2.TabIndex = 10;
            this.Depiction_2.Text = "Copyright © 2021 Strawberry Ass All Rights Reserved";
            // 
            // _Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 346);
            this.Controls.Add(this.Depiction_2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "_Main_Window";
            this.Text = "Intelligent Task Time By Straberry Ass";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Depiction_2;
    }
}