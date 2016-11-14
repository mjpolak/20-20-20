namespace _20_20_20
{
    partial class Break
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
            this.label1 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1134, 661);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wzrok na 20 sekund od monitora!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // counter
            // 
            this.counter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.counter.Location = new System.Drawing.Point(0, 661);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(1134, 25);
            this.counter.TabIndex = 1;
            this.counter.Text = "Pozostało:";
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Break
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(1134, 686);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Break";
            this.ShowInTaskbar = false;
            this.Text = "Break";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Break_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Break_FormClosing);
            this.Load += new System.EventHandler(this.Break_Load);
            this.Shown += new System.EventHandler(this.Break_Shown);
            this.VisibleChanged += new System.EventHandler(this.Break_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Break_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label counter;
    }
}