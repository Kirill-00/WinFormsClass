﻿namespace Lesson2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addSizeText = new System.Windows.Forms.Button();
            this.subSizeText = new System.Windows.Forms.Button();
            this.clearBth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(661, 274);
            this.textBox1.TabIndex = 1;
            // 
            // addSizeText
            // 
            this.addSizeText.Location = new System.Drawing.Point(12, 342);
            this.addSizeText.Name = "addSizeText";
            this.addSizeText.Size = new System.Drawing.Size(139, 45);
            this.addSizeText.TabIndex = 2;
            this.addSizeText.Text = "Увеличить шрифт";
            this.addSizeText.UseVisualStyleBackColor = true;
            this.addSizeText.Click += new System.EventHandler(this.addSizeText_Click);
            // 
            // subSizeText
            // 
            this.subSizeText.Location = new System.Drawing.Point(271, 342);
            this.subSizeText.Name = "subSizeText";
            this.subSizeText.Size = new System.Drawing.Size(143, 45);
            this.subSizeText.TabIndex = 3;
            this.subSizeText.Text = "Уменьшить шрифт";
            this.subSizeText.UseVisualStyleBackColor = true;
            this.subSizeText.Click += new System.EventHandler(this.subSizeText_Click);
            // 
            // clearBth
            // 
            this.clearBth.Location = new System.Drawing.Point(534, 342);
            this.clearBth.Name = "clearBth";
            this.clearBth.Size = new System.Drawing.Size(139, 45);
            this.clearBth.TabIndex = 4;
            this.clearBth.Text = "Очистить";
            this.clearBth.UseVisualStyleBackColor = true;
            this.clearBth.Click += new System.EventHandler(this.clearBth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 408);
            this.Controls.Add(this.clearBth);
            this.Controls.Add(this.subSizeText);
            this.Controls.Add(this.addSizeText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addSizeText;
        private System.Windows.Forms.Button subSizeText;
        private System.Windows.Forms.Button clearBth;
    }
}

