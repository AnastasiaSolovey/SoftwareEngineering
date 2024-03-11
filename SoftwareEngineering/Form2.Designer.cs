namespace SoftwareEngineering
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OldText = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptionButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.DecryptionButton = new System.Windows.Forms.Button();
            this.OutputButton = new System.Windows.Forms.Button();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OldText
            // 
            this.OldText.Location = new System.Drawing.Point(133, 12);
            this.OldText.Multiline = true;
            this.OldText.Name = "OldText";
            this.OldText.Size = new System.Drawing.Size(346, 128);
            this.OldText.TabIndex = 0;
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(133, 239);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(346, 128);
            this.ResultText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат\r\nпреобразования";
            // 
            // EncryptionButton
            // 
            this.EncryptionButton.Location = new System.Drawing.Point(136, 406);
            this.EncryptionButton.Name = "EncryptionButton";
            this.EncryptionButton.Size = new System.Drawing.Size(108, 48);
            this.EncryptionButton.TabIndex = 11;
            this.EncryptionButton.Text = "Шифрование";
            this.EncryptionButton.UseVisualStyleBackColor = true;
            this.EncryptionButton.Click += new System.EventHandler(this.EncryptionButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(371, 406);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(108, 48);
            this.NextButton.TabIndex = 12;
            this.NextButton.Text = "Следующее задание";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // DecryptionButton
            // 
            this.DecryptionButton.Location = new System.Drawing.Point(254, 406);
            this.DecryptionButton.Name = "DecryptionButton";
            this.DecryptionButton.Size = new System.Drawing.Size(108, 48);
            this.DecryptionButton.TabIndex = 13;
            this.DecryptionButton.Text = "Дешифрование";
            this.DecryptionButton.UseVisualStyleBackColor = true;
            this.DecryptionButton.Click += new System.EventHandler(this.DecryptionButton_Click);
            // 
            // OutputButton
            // 
            this.OutputButton.Location = new System.Drawing.Point(15, 406);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(108, 48);
            this.OutputButton.TabIndex = 14;
            this.OutputButton.Text = "Вывод";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(133, 184);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(346, 20);
            this.AmountBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Число строк\r\nдля шифрования";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.DecryptionButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.EncryptionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.OldText);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldText;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EncryptionButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button DecryptionButton;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label label3;
    }
}