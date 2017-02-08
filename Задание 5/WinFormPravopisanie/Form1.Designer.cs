namespace WinFormPravopisanie
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
            this.rtb_Text = new System.Windows.Forms.RichTextBox();
            this.Button_Check = new System.Windows.Forms.Button();
            this.ofd_LoadFile = new System.Windows.Forms.OpenFileDialog();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.Button_LoadLibrary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_Text
            // 
            this.rtb_Text.Location = new System.Drawing.Point(12, 29);
            this.rtb_Text.Name = "rtb_Text";
            this.rtb_Text.Size = new System.Drawing.Size(615, 141);
            this.rtb_Text.TabIndex = 0;
            this.rtb_Text.Text = "";
            // 
            // Button_Check
            // 
            this.Button_Check.Location = new System.Drawing.Point(500, 255);
            this.Button_Check.Name = "Button_Check";
            this.Button_Check.Size = new System.Drawing.Size(127, 39);
            this.Button_Check.TabIndex = 1;
            this.Button_Check.Text = "Check";
            this.Button_Check.UseVisualStyleBackColor = true;
            this.Button_Check.Click += new System.EventHandler(this.Button_Check_Click);
            // 
            // ofd_LoadFile
            // 
            this.ofd_LoadFile.FileName = "openFileDialog1";
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(12, 202);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.ReadOnly = true;
            this.tb_Path.Size = new System.Drawing.Size(519, 20);
            this.tb_Path.TabIndex = 2;
            // 
            // Button_LoadLibrary
            // 
            this.Button_LoadLibrary.Location = new System.Drawing.Point(552, 200);
            this.Button_LoadLibrary.Name = "Button_LoadLibrary";
            this.Button_LoadLibrary.Size = new System.Drawing.Size(75, 23);
            this.Button_LoadLibrary.TabIndex = 3;
            this.Button_LoadLibrary.Text = "Load Library";
            this.Button_LoadLibrary.UseVisualStyleBackColor = true;
            this.Button_LoadLibrary.Click += new System.EventHandler(this.Button_LoadLibrary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 306);
            this.Controls.Add(this.Button_LoadLibrary);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.Button_Check);
            this.Controls.Add(this.rtb_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Text;
        private System.Windows.Forms.Button Button_Check;
        private System.Windows.Forms.OpenFileDialog ofd_LoadFile;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Button Button_LoadLibrary;
    }
}

