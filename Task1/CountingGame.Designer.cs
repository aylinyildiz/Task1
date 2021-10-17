
namespace Task1
{
    partial class CountingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountingGame));
            this.lblText = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnPrediction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(22, 90);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(321, 28);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "1-10 arasında bir sayı tahmin ediniz";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(480, 94);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(178, 27);
            this.tbxNumber.TabIndex = 1;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.BackColor = System.Drawing.Color.Transparent;
            this.lblGuess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuess.Location = new System.Drawing.Point(31, 306);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(113, 28);
            this.lblGuess.TabIndex = 2;
            this.lblGuess.Text = "Tahmininiz :";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.Location = new System.Drawing.Point(31, 359);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(126, 25);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Doğru Cevap :";
            // 
            // btnPrediction
            // 
            this.btnPrediction.Location = new System.Drawing.Point(496, 143);
            this.btnPrediction.Name = "btnPrediction";
            this.btnPrediction.Size = new System.Drawing.Size(144, 36);
            this.btnPrediction.TabIndex = 4;
            this.btnPrediction.Text = "Tahmin Et";
            this.btnPrediction.UseVisualStyleBackColor = true;
            this.btnPrediction.Click += new System.EventHandler(this.btnPrediction_Click);
            // 
            // CountingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrediction);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.lblText);
            this.Name = "CountingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CountingGame";
            this.Load += new System.EventHandler(this.CountingGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnPrediction;
    }
}