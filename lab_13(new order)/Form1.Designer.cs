namespace lab_13_new_order_
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCrypted = new System.Windows.Forms.TextBox();
            this.pbDecrypting = new System.Windows.Forms.Button();
            this.pbCrypting = new System.Windows.Forms.Button();
            this.tbNormal = new System.Windows.Forms.TextBox();
            this.lbCrypted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCrypted
            // 
            this.tbCrypted.Location = new System.Drawing.Point(12, 30);
            this.tbCrypted.Multiline = true;
            this.tbCrypted.Name = "tbCrypted";
            this.tbCrypted.Size = new System.Drawing.Size(196, 318);
            this.tbCrypted.TabIndex = 0;
            this.tbCrypted.DoubleClick += new System.EventHandler(this.tbCrypted_DoubleClick);
            // 
            // pbDecrypting
            // 
            this.pbDecrypting.Location = new System.Drawing.Point(214, 154);
            this.pbDecrypting.Name = "pbDecrypting";
            this.pbDecrypting.Size = new System.Drawing.Size(130, 23);
            this.pbDecrypting.TabIndex = 1;
            this.pbDecrypting.Text = "Рассшифровка >>";
            this.pbDecrypting.UseVisualStyleBackColor = true;
            this.pbDecrypting.Click += new System.EventHandler(this.pbDecrypting_Click);
            // 
            // pbCrypting
            // 
            this.pbCrypting.Location = new System.Drawing.Point(214, 183);
            this.pbCrypting.Name = "pbCrypting";
            this.pbCrypting.Size = new System.Drawing.Size(130, 23);
            this.pbCrypting.TabIndex = 2;
            this.pbCrypting.Text = "<< Шифрование";
            this.pbCrypting.UseVisualStyleBackColor = true;
            this.pbCrypting.Click += new System.EventHandler(this.pbCrypting_Click);
            // 
            // tbNormal
            // 
            this.tbNormal.Location = new System.Drawing.Point(350, 30);
            this.tbNormal.Multiline = true;
            this.tbNormal.Name = "tbNormal";
            this.tbNormal.Size = new System.Drawing.Size(196, 318);
            this.tbNormal.TabIndex = 3;
            this.tbNormal.DoubleClick += new System.EventHandler(this.tbCrypted_DoubleClick);
            // 
            // lbCrypted
            // 
            this.lbCrypted.AutoSize = true;
            this.lbCrypted.Location = new System.Drawing.Point(9, 9);
            this.lbCrypted.Name = "lbCrypted";
            this.lbCrypted.Size = new System.Drawing.Size(150, 13);
            this.lbCrypted.TabIndex = 4;
            this.lbCrypted.Text = "Зашифрованное сообщение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Исходное сообщение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCrypted);
            this.Controls.Add(this.tbNormal);
            this.Controls.Add(this.pbCrypting);
            this.Controls.Add(this.pbDecrypting);
            this.Controls.Add(this.tbCrypted);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCrypted;
        private System.Windows.Forms.Button pbDecrypting;
        private System.Windows.Forms.Button pbCrypting;
        private System.Windows.Forms.TextBox tbNormal;
        private System.Windows.Forms.Label lbCrypted;
        private System.Windows.Forms.Label label1;
    }
}

