
namespace Task1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.photoAlbum = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Button();
            this.countingGame = new System.Windows.Forms.Button();
            this.unitConversion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // photoAlbum
            // 
            this.photoAlbum.BackColor = System.Drawing.SystemColors.Control;
            this.photoAlbum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.photoAlbum.Location = new System.Drawing.Point(67, 191);
            this.photoAlbum.Name = "photoAlbum";
            this.photoAlbum.Size = new System.Drawing.Size(178, 69);
            this.photoAlbum.TabIndex = 0;
            this.photoAlbum.Text = "Photo Album";
            this.photoAlbum.UseVisualStyleBackColor = false;
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(320, 191);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(178, 69);
            this.clock.TabIndex = 1;
            this.clock.Text = "Digital/Analog Clock";
            this.clock.UseVisualStyleBackColor = true;
            this.clock.Click += new System.EventHandler(this.clock_Click);
            // 
            // countingGame
            // 
            this.countingGame.Location = new System.Drawing.Point(601, 191);
            this.countingGame.Name = "countingGame";
            this.countingGame.Size = new System.Drawing.Size(178, 69);
            this.countingGame.TabIndex = 2;
            this.countingGame.Text = "Counting Game";
            this.countingGame.UseVisualStyleBackColor = true;
            this.countingGame.Click += new System.EventHandler(this.countingGame_Click);
            // 
            // unitConversion
            // 
            this.unitConversion.Location = new System.Drawing.Point(870, 191);
            this.unitConversion.Name = "unitConversion";
            this.unitConversion.Size = new System.Drawing.Size(178, 69);
            this.unitConversion.TabIndex = 3;
            this.unitConversion.Text = "Unit Conversion";
            this.unitConversion.UseVisualStyleBackColor = true;
            this.unitConversion.Click += new System.EventHandler(this.unitConversion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1149, 517);
            this.Controls.Add(this.unitConversion);
            this.Controls.Add(this.countingGame);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.photoAlbum);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button photoAlbum;
        private System.Windows.Forms.Button clock;
        private System.Windows.Forms.Button countingGame;
        private System.Windows.Forms.Button unitConversion;
    }
}

