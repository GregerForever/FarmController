namespace FarmController
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
            this.BeginButton = new System.Windows.Forms.Button();
            this.NumericDuration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HotkeyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // BeginButton
            // 
            this.BeginButton.Location = new System.Drawing.Point(127, 140);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(75, 23);
            this.BeginButton.TabIndex = 0;
            this.BeginButton.Text = "Старт";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // NumericDuration
            // 
            this.NumericDuration.Location = new System.Drawing.Point(165, 84);
            this.NumericDuration.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericDuration.Name = "NumericDuration";
            this.NumericDuration.Size = new System.Drawing.Size(120, 20);
            this.NumericDuration.TabIndex = 2;
            this.NumericDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericDuration.ValueChanged += new System.EventHandler(this.NumericDuration_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Периодичность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Горячая клавиша: ";
            // 
            // HotkeyButton
            // 
            this.HotkeyButton.Location = new System.Drawing.Point(165, 110);
            this.HotkeyButton.Name = "HotkeyButton";
            this.HotkeyButton.Size = new System.Drawing.Size(120, 23);
            this.HotkeyButton.TabIndex = 5;
            this.HotkeyButton.Text = "button1";
            this.HotkeyButton.UseVisualStyleBackColor = true;
            this.HotkeyButton.Click += new System.EventHandler(this.HotkeyButton_Click);
            this.HotkeyButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeyButton_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 285);
            this.Controls.Add(this.HotkeyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericDuration);
            this.Controls.Add(this.BeginButton);
            this.Name = "Form1";
            this.Text = "FarmController";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.NumericUpDown NumericDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HotkeyButton;
    }
}

