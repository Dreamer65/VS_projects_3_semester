namespace lab_8_new_order_
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
            if (disposing && (components != null)) {
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
            this.gbRemainers = new System.Windows.Forms.GroupBox();
            this.lbRem3 = new System.Windows.Forms.Label();
            this.tbRem3 = new System.Windows.Forms.TextBox();
            this.tbRem5 = new System.Windows.Forms.TextBox();
            this.lbRem5 = new System.Windows.Forms.Label();
            this.tbRem7 = new System.Windows.Forms.TextBox();
            this.lbRem7 = new System.Windows.Forms.Label();
            this.pbAct = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.gbRemainers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRemainers
            // 
            this.gbRemainers.Controls.Add(this.tbRem7);
            this.gbRemainers.Controls.Add(this.lbRem7);
            this.gbRemainers.Controls.Add(this.tbRem5);
            this.gbRemainers.Controls.Add(this.lbRem5);
            this.gbRemainers.Controls.Add(this.tbRem3);
            this.gbRemainers.Controls.Add(this.lbRem3);
            this.gbRemainers.Location = new System.Drawing.Point(12, 12);
            this.gbRemainers.Name = "gbRemainers";
            this.gbRemainers.Size = new System.Drawing.Size(164, 117);
            this.gbRemainers.TabIndex = 0;
            this.gbRemainers.TabStop = false;
            this.gbRemainers.Text = "Остатки от деления";
            // 
            // lbRem3
            // 
            this.lbRem3.AutoSize = true;
            this.lbRem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRem3.Location = new System.Drawing.Point(19, 30);
            this.lbRem3.Name = "lbRem3";
            this.lbRem3.Size = new System.Drawing.Size(32, 13);
            this.lbRem3.TabIndex = 0;
            this.lbRem3.Text = "на 3";
            // 
            // tbRem3
            // 
            this.tbRem3.Location = new System.Drawing.Point(84, 27);
            this.tbRem3.Name = "tbRem3";
            this.tbRem3.Size = new System.Drawing.Size(68, 20);
            this.tbRem3.TabIndex = 1;
            this.tbRem3.TextChanged += new System.EventHandler(this.tbRem3_TextChanged);
            this.tbRem3.DoubleClick += new System.EventHandler(this.tbRem3_DoubleClick);
            this.tbRem3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRem3_KeyPress);
            // 
            // tbRem5
            // 
            this.tbRem5.Location = new System.Drawing.Point(84, 53);
            this.tbRem5.Name = "tbRem5";
            this.tbRem5.Size = new System.Drawing.Size(68, 20);
            this.tbRem5.TabIndex = 3;
            this.tbRem5.TextChanged += new System.EventHandler(this.tbRem3_TextChanged);
            this.tbRem5.DoubleClick += new System.EventHandler(this.tbRem3_DoubleClick);
            this.tbRem5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRem3_KeyPress);
            // 
            // lbRem5
            // 
            this.lbRem5.AutoSize = true;
            this.lbRem5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRem5.Location = new System.Drawing.Point(19, 56);
            this.lbRem5.Name = "lbRem5";
            this.lbRem5.Size = new System.Drawing.Size(32, 13);
            this.lbRem5.TabIndex = 2;
            this.lbRem5.Text = "на 5";
            // 
            // tbRem7
            // 
            this.tbRem7.Location = new System.Drawing.Point(84, 79);
            this.tbRem7.Name = "tbRem7";
            this.tbRem7.Size = new System.Drawing.Size(68, 20);
            this.tbRem7.TabIndex = 5;
            this.tbRem7.TextChanged += new System.EventHandler(this.tbRem3_TextChanged);
            this.tbRem7.DoubleClick += new System.EventHandler(this.tbRem3_DoubleClick);
            this.tbRem7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRem3_KeyPress);
            // 
            // lbRem7
            // 
            this.lbRem7.AutoSize = true;
            this.lbRem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRem7.Location = new System.Drawing.Point(19, 82);
            this.lbRem7.Name = "lbRem7";
            this.lbRem7.Size = new System.Drawing.Size(32, 13);
            this.lbRem7.TabIndex = 4;
            this.lbRem7.Text = "на 7";
            // 
            // pbAct
            // 
            this.pbAct.Location = new System.Drawing.Point(302, 12);
            this.pbAct.Name = "pbAct";
            this.pbAct.Size = new System.Drawing.Size(75, 23);
            this.pbAct.TabIndex = 1;
            this.pbAct.Text = "Расчитать";
            this.pbAct.UseVisualStyleBackColor = true;
            this.pbAct.Click += new System.EventHandler(this.pbAct_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(182, 94);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(71, 13);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Результат = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 141);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.pbAct);
            this.Controls.Add(this.gbRemainers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbRemainers.ResumeLayout(false);
            this.gbRemainers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRemainers;
        private System.Windows.Forms.TextBox tbRem3;
        private System.Windows.Forms.Label lbRem3;
        private System.Windows.Forms.TextBox tbRem7;
        private System.Windows.Forms.Label lbRem7;
        private System.Windows.Forms.TextBox tbRem5;
        private System.Windows.Forms.Label lbRem5;
        private System.Windows.Forms.Button pbAct;
        private System.Windows.Forms.Label lbResult;
    }
}

