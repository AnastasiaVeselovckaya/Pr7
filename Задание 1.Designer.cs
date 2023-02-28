using System.ComponentModel;

namespace Задание__1
{
    partial class Lab_7
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
            this.pct = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.file2 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(34, 59);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(625, 469);
            this.pct.TabIndex = 0;
            this.pct.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(34, 597);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(221, 37);
            this.btn.TabIndex = 1;
            this.btn.Text = "Загрузить рисунок";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // file1
            // 
            this.file1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить рисунок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 569);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(534, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Lab_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 670);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pct);
            this.Name = "Lab_7";
            this.Text = "Просмотр графического файла ";
            this.Load += new System.EventHandler(this.Lab_7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.OpenFileDialog file1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog file2;
        private System.Windows.Forms.TextBox textBox1;
        private CancelEventHandler saveFileDialog1_FileOk;
    }
}

