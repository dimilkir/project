namespace App8
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.numberBithday = new System.Windows.Forms.NumericUpDown();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBithday)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(5, 7);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(240, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(5, 34);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(52, 17);
            this.fancyBox.TabIndex = 1;
            this.fancyBox.Text = "fancy";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(5, 63);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(60, 17);
            this.healthyBox.TabIndex = 2;
            this.healthyBox.Text = "healthy";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLabel.Location = new System.Drawing.Point(71, 32);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(174, 51);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "///";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 115);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.healthyBox);
            this.tabPage1.Controls.Add(this.fancyBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 89);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.numberBithday);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 89);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthdayCost.Location = new System.Drawing.Point(161, 34);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(84, 49);
            this.birthdayCost.TabIndex = 7;
            this.birthdayCost.Text = "///";
            this.birthdayCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberBithday
            // 
            this.numberBithday.Location = new System.Drawing.Point(5, 7);
            this.numberBithday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBithday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBithday.Name = "numberBithday";
            this.numberBithday.Size = new System.Drawing.Size(240, 20);
            this.numberBithday.TabIndex = 4;
            this.numberBithday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBithday.ValueChanged += new System.EventHandler(this.numberBithday_ValueChanged);
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Checked = true;
            this.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthday.Location = new System.Drawing.Point(5, 34);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(52, 17);
            this.fancyBirthday.TabIndex = 5;
            this.fancyBirthday.Text = "fancy";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(43, 63);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(112, 20);
            this.cakeWriting.TabIndex = 8;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.BackColor = System.Drawing.Color.Transparent;
            this.tooLongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tooLongLabel.ForeColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(52, 34);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(103, 17);
            this.tooLongLabel.TabIndex = 10;
            this.tooLongLabel.Text = "TOO LONG";
            this.tooLongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 136);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "///";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBithday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.NumericUpDown numberBithday;
        private System.Windows.Forms.CheckBox fancyBirthday;
    }
}

