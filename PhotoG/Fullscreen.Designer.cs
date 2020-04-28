namespace PhotoG
{
    partial class Fullscreen
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
            this.SuspendLayout();
            // 
            // Fullscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 482);
            this.KeyPreview = true;
            this.Name = "Fullscreen";
            this.Text = "Fullscreen";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Fullscreen_Load);
            this.MaximumSizeChanged += new System.EventHandler(this.Fullscreen_Load);
            this.Load += new System.EventHandler(this.Fullscreen_Load);
            this.ResizeBegin += new System.EventHandler(this.Fullscreen_Load);
            this.ResizeEnd += new System.EventHandler(this.Fullscreen_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.Fullscreen_Load);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.Fullscreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fullscreen_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

    }
}