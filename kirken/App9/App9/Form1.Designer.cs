namespace App9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bananas = new System.Windows.Forms.NumericUpDown();
            this.bananasLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bananas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bananas
            // 
            this.bananas.Location = new System.Drawing.Point(15, 41);
            this.bananas.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.bananas.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bananas.Name = "bananas";
            this.bananas.Size = new System.Drawing.Size(120, 20);
            this.bananas.TabIndex = 0;
            this.bananas.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.bananas.ValueChanged += new System.EventHandler(this.bananas_ValueChanged);
            // 
            // bananasLabel
            // 
            this.bananasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bananasLabel.Location = new System.Drawing.Point(12, 11);
            this.bananasLabel.Name = "bananasLabel";
            this.bananasLabel.Size = new System.Drawing.Size(130, 20);
            this.bananasLabel.TabIndex = 1;
            this.bananasLabel.Text = "BANAAANAAAAS!!!1";
            this.bananasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App9.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(66, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 183);
            this.Controls.Add(this.bananasLabel);
            this.Controls.Add(this.bananas);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Banana bag calc";
            ((System.ComponentModel.ISupportInitialize)(this.bananas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown bananas;
        private System.Windows.Forms.Label bananasLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

