namespace DistenceTraveled
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
            this.outputLB = new System.Windows.Forms.Label();
            this.mphLB = new System.Windows.Forms.Label();
            this.mphTB = new System.Windows.Forms.TextBox();
            this.hoursTB = new System.Windows.Forms.TextBox();
            this.hoursLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLB
            // 
            this.outputLB.AutoSize = true;
            this.outputLB.Location = new System.Drawing.Point(266, 76);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(164, 13);
            this.outputLB.TabIndex = 3;
            this.outputLB.Text = "After x hours you traveled, y miles";
            // 
            // mphLB
            // 
            this.mphLB.AutoSize = true;
            this.mphLB.Location = new System.Drawing.Point(29, 64);
            this.mphLB.Name = "mphLB";
            this.mphLB.Size = new System.Drawing.Size(96, 13);
            this.mphLB.TabIndex = 4;
            this.mphLB.Text = "What is you MPH?";
            // 
            // mphTB
            // 
            this.mphTB.Location = new System.Drawing.Point(32, 80);
            this.mphTB.Name = "mphTB";
            this.mphTB.Size = new System.Drawing.Size(100, 20);
            this.mphTB.TabIndex = 5;
            this.mphTB.TextChanged += new System.EventHandler(this.mphTB_TextChanged);
            // 
            // hoursTB
            // 
            this.hoursTB.Location = new System.Drawing.Point(150, 80);
            this.hoursTB.Name = "hoursTB";
            this.hoursTB.Size = new System.Drawing.Size(100, 20);
            this.hoursTB.TabIndex = 7;
            this.hoursTB.TextChanged += new System.EventHandler(this.hoursTB_TextChanged);
            // 
            // hoursLB
            // 
            this.hoursLB.AutoSize = true;
            this.hoursLB.Location = new System.Drawing.Point(147, 64);
            this.hoursLB.Name = "hoursLB";
            this.hoursLB.Size = new System.Drawing.Size(108, 13);
            this.hoursLB.TabIndex = 6;
            this.hoursLB.Text = "For how many hours?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 183);
            this.Controls.Add(this.hoursTB);
            this.Controls.Add(this.hoursLB);
            this.Controls.Add(this.mphTB);
            this.Controls.Add(this.mphLB);
            this.Controls.Add(this.outputLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label outputLB;
        private System.Windows.Forms.Label mphLB;
        private System.Windows.Forms.TextBox mphTB;
        private System.Windows.Forms.TextBox hoursTB;
        private System.Windows.Forms.Label hoursLB;
    }
}

