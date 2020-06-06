namespace Air_Hockey
{
    partial class GameWindow
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
            this.animationTimer_ = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_)).BeginInit();
            this.SuspendLayout();
            // 
            // animationTimer_
            // 
            this.animationTimer_.Enabled = true;
            this.animationTimer_.Interval = 20;
            this.animationTimer_.Tick += new System.EventHandler(this.animationTimer__Tick);
            // 
            // pictureBox_
            // 
            this.pictureBox_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox_.BackgroundImage = global::Air_Hockey.Properties.Resources.Air;
            this.pictureBox_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_.Name = "pictureBox_";
            this.pictureBox_.Size = new System.Drawing.Size(1003, 409);
            this.pictureBox_.TabIndex = 0;
            this.pictureBox_.TabStop = false;
            this.pictureBox_.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 409);
            this.Controls.Add(this.pictureBox_);
            this.Name = "GameWindow";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_;
        private System.Windows.Forms.Timer animationTimer_;
    }
}

