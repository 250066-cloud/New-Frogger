namespace Frogger
{
    partial class Form3
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
            this.butPlayAgain = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butPlayAgain
            // 
            this.butPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.butPlayAgain.FlatAppearance.BorderSize = 0;
            this.butPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPlayAgain.Location = new System.Drawing.Point(152, 265);
            this.butPlayAgain.Name = "butPlayAgain";
            this.butPlayAgain.Size = new System.Drawing.Size(313, 53);
            this.butPlayAgain.TabIndex = 0;
            this.butPlayAgain.UseVisualStyleBackColor = false;
            this.butPlayAgain.Click += new System.EventHandler(this.butPlayAgain_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(229, 491);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(132, 41);
            this.butExit.TabIndex = 1;
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frogger.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(600, 761);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butPlayAgain);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butPlayAgain;
        private System.Windows.Forms.Button butExit;
    }
}