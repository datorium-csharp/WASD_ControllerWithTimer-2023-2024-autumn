namespace WASD_ControllerWithTimer_2023_2024_autumn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hero = new System.Windows.Forms.PictureBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.timerRocket = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Fuchsia;
            this.hero.Location = new System.Drawing.Point(439, 250);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(100, 100);
            this.hero.TabIndex = 0;
            this.hero.TabStop = false;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 50;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // timerRocket
            // 
            this.timerRocket.Tick += new System.EventHandler(this.timerRocket_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 624);
            this.Controls.Add(this.hero);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "WASD Controller";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox hero;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Timer timerRocket;
    }
}