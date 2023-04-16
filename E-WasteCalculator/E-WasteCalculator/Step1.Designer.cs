namespace E_WasteCalculator
{
    partial class Step1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step1));
            this.FatetyduaLabel = new System.Windows.Forms.Label();
            this.EyfButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FatetyduaLabel
            // 
            this.FatetyduaLabel.AutoSize = true;
            this.FatetyduaLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.FatetyduaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatetyduaLabel.Location = new System.Drawing.Point(319, 284);
            this.FatetyduaLabel.Name = "FatetyduaLabel";
            this.FatetyduaLabel.Size = new System.Drawing.Size(165, 26);
            this.FatetyduaLabel.TabIndex = 0;
            this.FatetyduaLabel.Text = "Find all those electronics\r\nthat you don’t use anymore.";
            this.FatetyduaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EyfButton
            // 
            this.EyfButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EyfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EyfButton.Location = new System.Drawing.Point(341, 356);
            this.EyfButton.Name = "EyfButton";
            this.EyfButton.Size = new System.Drawing.Size(115, 23);
            this.EyfButton.TabIndex = 1;
            this.EyfButton.Text = "-> Enter your findings";
            this.EyfButton.UseVisualStyleBackColor = false;
            this.EyfButton.Click += new System.EventHandler(this.EyfButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(177, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 263);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EyfButton);
            this.Controls.Add(this.FatetyduaLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Step1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FatetyduaLabel;
        private System.Windows.Forms.Button EyfButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

