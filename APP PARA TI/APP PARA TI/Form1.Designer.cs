namespace APP_PARA_TI
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
            this.bPinchar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPinchar
            // 
            this.bPinchar.BackColor = System.Drawing.Color.Red;
            this.bPinchar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.bPinchar.Location = new System.Drawing.Point(53, 184);
            this.bPinchar.Name = "bPinchar";
            this.bPinchar.Size = new System.Drawing.Size(150, 47);
            this.bPinchar.TabIndex = 0;
            this.bPinchar.Text = "PINCHAR";
            this.bPinchar.UseVisualStyleBackColor = false;
            this.bPinchar.Click += new System.EventHandler(this.bPinchar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bPinchar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPinchar;
    }
}

