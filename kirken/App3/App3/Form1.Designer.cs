namespace App3
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
            this.pluhaLabel = new System.Windows.Forms.Label();
            this.limonLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pluhaLabel
            // 
            this.pluhaLabel.Location = new System.Drawing.Point(12, 9);
            this.pluhaLabel.Name = "pluhaLabel";
            this.pluhaLabel.Size = new System.Drawing.Size(260, 20);
            this.pluhaLabel.TabIndex = 1;
            this.pluhaLabel.Text = "Бананов у Плюхи:";
            this.pluhaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // limonLabel
            // 
            this.limonLabel.Location = new System.Drawing.Point(12, 29);
            this.limonLabel.Name = "limonLabel";
            this.limonLabel.Size = new System.Drawing.Size(260, 19);
            this.limonLabel.TabIndex = 3;
            this.limonLabel.Text = "Бананов словил на лицо Лимон:";
            this.limonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Накидать на лицо Лимону!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Взять банан!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.limonLabel);
            this.Controls.Add(this.pluhaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Бананов всего:";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label pluhaLabel;
        private System.Windows.Forms.Label limonLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

