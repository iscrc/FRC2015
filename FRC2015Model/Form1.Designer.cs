namespace FRC2015Model
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
            this.RunModelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunModelButton
            // 
            this.RunModelButton.Location = new System.Drawing.Point(13, 13);
            this.RunModelButton.Name = "RunModelButton";
            this.RunModelButton.Size = new System.Drawing.Size(75, 23);
            this.RunModelButton.TabIndex = 0;
            this.RunModelButton.Text = "Run Model";
            this.RunModelButton.UseVisualStyleBackColor = true;
            this.RunModelButton.Click += new System.EventHandler(this.RunModelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.RunModelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunModelButton;
    }
}

