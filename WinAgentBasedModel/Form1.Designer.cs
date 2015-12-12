namespace WinAgentBasedModel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.distTop = new System.Windows.Forms.Label();
            this.distLeft = new System.Windows.Forms.Label();
            this.distRight = new System.Windows.Forms.Label();
            this.distBottom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "An empty Agent Based Model that uses Windows forms";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 190);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "step";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(94, 29);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(175, 29);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // distTop
            // 
            this.distTop.AutoSize = true;
            this.distTop.Location = new System.Drawing.Point(279, 59);
            this.distTop.Name = "distTop";
            this.distTop.Size = new System.Drawing.Size(23, 13);
            this.distTop.TabIndex = 5;
            this.distTop.Text = "dist";
            // 
            // distLeft
            // 
            this.distLeft.AutoSize = true;
            this.distLeft.Location = new System.Drawing.Point(278, 72);
            this.distLeft.Name = "distLeft";
            this.distLeft.Size = new System.Drawing.Size(23, 13);
            this.distLeft.TabIndex = 6;
            this.distLeft.Text = "dist";
            // 
            // distRight
            // 
            this.distRight.AutoSize = true;
            this.distRight.Location = new System.Drawing.Point(328, 72);
            this.distRight.Name = "distRight";
            this.distRight.Size = new System.Drawing.Size(23, 13);
            this.distRight.TabIndex = 7;
            this.distRight.Text = "dist";
            // 
            // distBottom
            // 
            this.distBottom.AutoSize = true;
            this.distBottom.Location = new System.Drawing.Point(278, 85);
            this.distBottom.Name = "distBottom";
            this.distBottom.Size = new System.Drawing.Size(23, 13);
            this.distBottom.TabIndex = 8;
            this.distBottom.Text = "dist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.distBottom);
            this.Controls.Add(this.distRight);
            this.Controls.Add(this.distLeft);
            this.Controls.Add(this.distTop);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label distTop;
        private System.Windows.Forms.Label distLeft;
        private System.Windows.Forms.Label distRight;
        private System.Windows.Forms.Label distBottom;
    }
}

