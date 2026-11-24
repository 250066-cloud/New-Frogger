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
            this.picVehicle = new System.Windows.Forms.PictureBox();
            this.picVehicle2 = new System.Windows.Forms.PictureBox();
            this.picVehicle3 = new System.Windows.Forms.PictureBox();
            this.labLives = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFrog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle3)).BeginInit();
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
            this.picFrog.Location = new System.Drawing.Point(267, 603);
            this.picFrog.Name = "picFrog";
            this.picFrog.Size = new System.Drawing.Size(41, 41);
            this.picFrog.TabIndex = 2;
            this.picFrog.TabStop = false;
            // 
            // picVehicle
            // 
            this.picVehicle.BackColor = System.Drawing.Color.Transparent;
            this.picVehicle.Image = global::Frogger.Properties.Resources.Car___Frogger_29___11_removebg_preview11;
            this.picVehicle.Location = new System.Drawing.Point(535, 517);
            this.picVehicle.Name = "picVehicle";
            this.picVehicle.Size = new System.Drawing.Size(53, 50);
            this.picVehicle.TabIndex = 3;
            this.picVehicle.TabStop = false;
            this.picVehicle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picVehicle2
            // 
            this.picVehicle2.BackColor = System.Drawing.Color.Transparent;
            this.picVehicle2.Image = global::Frogger.Properties.Resources.ce5195c342b2577e62fa90aea2e6a33b_removebg_preview1;
            this.picVehicle2.Location = new System.Drawing.Point(12, 466);
            this.picVehicle2.Name = "picVehicle2";
            this.picVehicle2.Size = new System.Drawing.Size(53, 39);
            this.picVehicle2.TabIndex = 4;
            this.picVehicle2.TabStop = false;
            // 
            // picVehicle3
            // 
            this.picVehicle3.BackColor = System.Drawing.Color.Transparent;
            this.picVehicle3.Image = global::Frogger.Properties.Resources.images_removebg_preview1;
            this.picVehicle3.Location = new System.Drawing.Point(535, 381);
            this.picVehicle3.Name = "picVehicle3";
            this.picVehicle3.Size = new System.Drawing.Size(53, 48);
            this.picVehicle3.TabIndex = 5;
            this.picVehicle3.TabStop = false;
            // 
            // labLives
            // 
            this.labLives.AutoSize = true;
            this.labLives.BackColor = System.Drawing.Color.Black;
            this.labLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.labLives.ForeColor = System.Drawing.Color.Transparent;
            this.labLives.Location = new System.Drawing.Point(153, 153);
            this.labLives.Name = "labLives";
            this.labLives.Size = new System.Drawing.Size(278, 76);
            this.labLives.TabIndex = 6;
            this.labLives.Text = "LIVES 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frogger.Properties.Resources.New_Project__1_2;
            this.ClientSize = new System.Drawing.Size(600, 761);
            this.Controls.Add(this.labLives);
            this.Controls.Add(this.picVehicle3);
            this.Controls.Add(this.picVehicle2);
            this.Controls.Add(this.picVehicle);
            this.Controls.Add(this.picFrog);
            this.Controls.Add(this.score_label);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ww";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picFrog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVehicle3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.PictureBox picFrog;
        public System.Windows.Forms.PictureBox picVehicle;
        public System.Windows.Forms.PictureBox picVehicle2;
        public System.Windows.Forms.PictureBox picVehicle3;
        private System.Windows.Forms.Label labLives;
    }
}

