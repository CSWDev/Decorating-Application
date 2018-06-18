namespace Splish_Splash_Decorators
{
    partial class Estimate
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
            this.lblSplishDecor3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSplishDecor3
            // 
            this.lblSplishDecor3.AutoSize = true;
            this.lblSplishDecor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplishDecor3.Location = new System.Drawing.Point(832, 40);
            this.lblSplishDecor3.Name = "lblSplishDecor3";
            this.lblSplishDecor3.Size = new System.Drawing.Size(321, 31);
            this.lblSplishDecor3.TabIndex = 0;
            this.lblSplishDecor3.Text = "Splish-Splash Decorators";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Splish_Splash_Decorators.Properties.Resources.SplishSplash;
            this.pictureBox1.Location = new System.Drawing.Point(378, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1227, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 390);
            this.panel1.TabIndex = 2;
            // 
            // Estimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 931);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSplishDecor3);
            this.Name = "Estimate";
            this.Text = "Estimate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplishDecor3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}