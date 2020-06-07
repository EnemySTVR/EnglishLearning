namespace EnglishLearning.Forms
{
    partial class Welcome_menu
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
            this.theBackground = new System.Windows.Forms.PictureBox();
            this.weelcomeText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // theBackground
            // 
            this.theBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theBackground.Image = global::EnglishLearning.Properties.Resources.Flag;
            this.theBackground.Location = new System.Drawing.Point(0, 0);
            this.theBackground.Margin = new System.Windows.Forms.Padding(0);
            this.theBackground.Name = "theBackground";
            this.theBackground.Size = new System.Drawing.Size(800, 450);
            this.theBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theBackground.TabIndex = 0;
            this.theBackground.TabStop = false;
            this.theBackground.Click += new System.EventHandler(this.TheBackground_Click);
            // 
            // weelcomeText
            // 
            this.weelcomeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weelcomeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weelcomeText.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            // Колибровка. Я не знаю откуда эти 40 и 30, но они выравнивают поле текста ровно по центру.
            this.weelcomeText.Location = new System.Drawing.Point
                (
                this.ClientSize.Height / 2 + 40, 
                this.ClientSize.Width / 2 + 30
                );

            this.weelcomeText.Margin = new System.Windows.Forms.Padding(0);
            this.weelcomeText.MaximumSize = new System.Drawing.Size(460, 107);
            this.weelcomeText.MinimumSize = new System.Drawing.Size(460, 107);
            this.weelcomeText.Name = "weelcomeText";
            this.weelcomeText.Size = new System.Drawing.Size(460, 107);
            this.weelcomeText.TabIndex = 1;
            this.weelcomeText.Text = "Привет!\r\nЭта программа поможет тебе выучить новые\r\nи повторить уже изученные англ" +
    "ийские слова.\r\n\r\nКликни в любом месте для продолжения.";
            this.weelcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.weelcomeText.Click += new System.EventHandler(this.TheBackground_Click);
            // 
            // Welcome_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weelcomeText);
            this.Controls.Add(this.theBackground);
            this.Name = "Welcome_menu";
            this.Text = "Welcome_menu";
            ((System.ComponentModel.ISupportInitialize)(this.theBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox theBackground;
        private System.Windows.Forms.Label weelcomeText;
    }
}