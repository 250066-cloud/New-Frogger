namespace Frogger
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
            this.score_label = new System.Windows.Forms.Label();
            this.picFrog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFrog)).BeginInit();
            this.SuspendLayout();
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.Color.Black;
            this.score_label.Font = new System.Drawing.Font("Ravie", 19F);
            this.score_label.ForeColor = System.Drawing.Color.Red;
            this.score_label.Location = new System.Drawing.Point(108, 704);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(34, 36);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "0";
            // 
            // picFrog
            // 
            this.picFrog.BackColor = System.Drawing.Color.Transparent;
            this.picFrog.Image = global::Frogger.Properties.Resources.New_Project__3__removebg_preview1;
            this.picFrog.Location = new System.Drawing.Point(254, 603);
            this.picFrog.Name = "picFrog";
            this.picFrog.Size = new System.Drawing.Size(41, 41);
            this.picFrog.TabIndex = 2;
            this.picFrog.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frogger.Properties.Resources.New_Project__1_2;
            this.ClientSize = new System.Drawing.Size(600, 761);
            this.Controls.Add(this.picFrog);
            this.Controls.Add(this.score_label);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picFrog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.PictureBox picFrog;
    }
}

