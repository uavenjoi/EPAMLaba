namespace WindowsForm1
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
            if (disposing && (components != null))
            {
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
            this.VivodStr = new System.Windows.Forms.TextBox();
            this.VvodStr = new System.Windows.Forms.TextBox();
            this.Exec = new System.Windows.Forms.Button();
            this.Revers = new System.Windows.Forms.CheckBox();
            this.ToUpper = new System.Windows.Forms.CheckBox();
            this.Space = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // VivodStr
            // 
            this.VivodStr.Location = new System.Drawing.Point(12, 212);
            this.VivodStr.Multiline = true;
            this.VivodStr.Name = "VivodStr";
            this.VivodStr.ReadOnly = true;
            this.VivodStr.Size = new System.Drawing.Size(339, 75);
            this.VivodStr.TabIndex = 6;
            // 
            // VvodStr
            // 
            this.VvodStr.Location = new System.Drawing.Point(12, 131);
            this.VvodStr.Multiline = true;
            this.VvodStr.Name = "VvodStr";
            this.VvodStr.Size = new System.Drawing.Size(339, 75);
            this.VvodStr.TabIndex = 5;
            // 
            // Exec
            // 
            this.Exec.Location = new System.Drawing.Point(251, 30);
            this.Exec.Name = "Exec";
            this.Exec.Size = new System.Drawing.Size(96, 75);
            this.Exec.TabIndex = 4;
            this.Exec.Text = "Excuite";
            this.Exec.UseVisualStyleBackColor = true;
            this.Exec.Click += new System.EventHandler(this.button1_Click);
            // 
            // Revers
            // 
            this.Revers.AutoSize = true;
            this.Revers.Location = new System.Drawing.Point(12, 30);
            this.Revers.Name = "Revers";
            this.Revers.Size = new System.Drawing.Size(90, 17);
            this.Revers.TabIndex = 1;
            this.Revers.Text = "Revers Stroki";
            this.Revers.UseVisualStyleBackColor = true;
            this.Revers.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ToUpper
            // 
            this.ToUpper.AutoSize = true;
            this.ToUpper.Location = new System.Drawing.Point(12, 60);
            this.ToUpper.Name = "ToUpper";
            this.ToUpper.Size = new System.Drawing.Size(101, 17);
            this.ToUpper.TabIndex = 2;
            this.ToUpper.Text = "Stroka to Upper";
            this.ToUpper.UseVisualStyleBackColor = true;
            this.ToUpper.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Space
            // 
            this.Space.AutoSize = true;
            this.Space.Location = new System.Drawing.Point(12, 88);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(84, 17);
            this.Space.TabIndex = 3;
            this.Space.Text = "PasteSpace";
            this.Space.UseVisualStyleBackColor = true;
            this.Space.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 311);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.ToUpper);
            this.Controls.Add(this.Revers);
            this.Controls.Add(this.Exec);
            this.Controls.Add(this.VvodStr);
            this.Controls.Add(this.VivodStr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VivodStr;
        private System.Windows.Forms.TextBox VvodStr;
        private System.Windows.Forms.Button Exec;
        private System.Windows.Forms.CheckBox Revers;
        private System.Windows.Forms.CheckBox ToUpper;
        private System.Windows.Forms.CheckBox Space;
    }
}

