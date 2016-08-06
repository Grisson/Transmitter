namespace Transmitter
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
            this.SA = new System.Windows.Forms.Button();
            this.SB = new System.Windows.Forms.Button();
            this.SC = new System.Windows.Forms.Button();
            this.SD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SA
            // 
            this.SA.Location = new System.Drawing.Point(33, 39);
            this.SA.Name = "SA";
            this.SA.Size = new System.Drawing.Size(70, 45);
            this.SA.TabIndex = 0;
            this.SA.Text = "S&1";
            this.SA.UseVisualStyleBackColor = true;
            this.SA.Click += new System.EventHandler(this.SA_Click);
            // 
            // SB
            // 
            this.SB.Location = new System.Drawing.Point(170, 39);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(70, 45);
            this.SB.TabIndex = 1;
            this.SB.Text = "S&2";
            this.SB.UseVisualStyleBackColor = true;
            this.SB.Click += new System.EventHandler(this.SB_Click);
            // 
            // SC
            // 
            this.SC.Location = new System.Drawing.Point(311, 39);
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(70, 45);
            this.SC.TabIndex = 2;
            this.SC.Text = "S&3";
            this.SC.UseVisualStyleBackColor = true;
            this.SC.Click += new System.EventHandler(this.SC_Click);
            // 
            // SD
            // 
            this.SD.Location = new System.Drawing.Point(471, 39);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(70, 45);
            this.SD.TabIndex = 3;
            this.SD.Text = "S&4";
            this.SD.UseVisualStyleBackColor = true;
            this.SD.Click += new System.EventHandler(this.SD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.SC);
            this.Controls.Add(this.SB);
            this.Controls.Add(this.SA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SA;
        private System.Windows.Forms.Button SB;
        private System.Windows.Forms.Button SC;
        private System.Windows.Forms.Button SD;
    }
}

