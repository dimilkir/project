namespace App7
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
            this.objRunner = new System.Windows.Forms.Button();
            this.objField = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.quadrantLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.directionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.victimLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objField)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objRunner
            // 
            this.objRunner.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.objRunner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.objRunner.Location = new System.Drawing.Point(175, 250);
            this.objRunner.Name = "objRunner";
            this.objRunner.Size = new System.Drawing.Size(100, 50);
            this.objRunner.TabIndex = 0;
            this.objRunner.TabStop = false;
            this.objRunner.Text = "ЭТО НЕ ТАК!";
            this.objRunner.UseVisualStyleBackColor = true;
            this.objRunner.Click += new System.EventHandler(this.objRunner_Click);
            this.objRunner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_MouseMove);
            // 
            // objField
            // 
            this.objField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objField.ErrorImage = null;
            this.objField.InitialImage = null;
            this.objField.Location = new System.Drawing.Point(0, 0);
            this.objField.Name = "objField";
            this.objField.Size = new System.Drawing.Size(450, 450);
            this.objField.TabIndex = 2;
            this.objField.TabStop = false;
            this.objField.DoubleClick += new System.EventHandler(this.background_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadrantLabel,
            this.directionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(450, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // quadrantLabel
            // 
            this.quadrantLabel.Name = "quadrantLabel";
            this.quadrantLabel.Size = new System.Drawing.Size(73, 17);
            this.quadrantLabel.Text = "Квадрант: ?";
            // 
            // directionLabel
            // 
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(98, 17);
            this.directionLabel.Text = "Направление: ?";
            // 
            // victimLabel
            // 
            this.victimLabel.AutoSize = true;
            this.victimLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.victimLabel.Location = new System.Drawing.Point(25, 25);
            this.victimLabel.Name = "victimLabel";
            this.victimLabel.Size = new System.Drawing.Size(53, 45);
            this.victimLabel.TabIndex = 4;
            this.victimLabel.Text = "...";
            this.victimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.objRunner);
            this.Controls.Add(this.victimLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.objField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.objField)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button objRunner;
        private System.Windows.Forms.PictureBox objField;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel quadrantLabel;
        private System.Windows.Forms.ToolStripStatusLabel directionLabel;
        private System.Windows.Forms.Label victimLabel;
    }
}

