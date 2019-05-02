namespace WindowsFormsApp1
{
    partial class Form1
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
            this.redHScrollBar = new System.Windows.Forms.HScrollBar();
            this.greenHScrollBar = new System.Windows.Forms.HScrollBar();
            this.blueHScrollBar = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // redHScrollBar
            // 
            this.redHScrollBar.Location = new System.Drawing.Point(59, 62);
            this.redHScrollBar.Name = "redHScrollBar";
            this.redHScrollBar.Size = new System.Drawing.Size(359, 41);
            this.redHScrollBar.TabIndex = 0;
            this.redHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
            // 
            // greenHScrollBar
            // 
            this.greenHScrollBar.Location = new System.Drawing.Point(59, 103);
            this.greenHScrollBar.Name = "greenHScrollBar";
            this.greenHScrollBar.Size = new System.Drawing.Size(359, 41);
            this.greenHScrollBar.TabIndex = 1;
            this.greenHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
            // 
            // blueHScrollBar
            // 
            this.blueHScrollBar.Location = new System.Drawing.Point(59, 144);
            this.blueHScrollBar.Name = "blueHScrollBar";
            this.blueHScrollBar.Size = new System.Drawing.Size(359, 41);
            this.blueHScrollBar.TabIndex = 2;
            this.blueHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 276);
            this.Controls.Add(this.blueHScrollBar);
            this.Controls.Add(this.greenHScrollBar);
            this.Controls.Add(this.redHScrollBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar redHScrollBar;
        private System.Windows.Forms.HScrollBar greenHScrollBar;
        private System.Windows.Forms.HScrollBar blueHScrollBar;
    }
}

