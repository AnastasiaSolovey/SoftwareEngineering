namespace SoftwareEngineering
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
            this.MatrixDataGridView = new System.Windows.Forms.DataGridView();
            this.CheckInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nBox = new System.Windows.Forms.TextBox();
            this.mBox = new System.Windows.Forms.TextBox();
            this.ChangeMinElement = new System.Windows.Forms.Button();
            this.CreateMatrix = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixDataGridView
            // 
            this.MatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixDataGridView.Location = new System.Drawing.Point(28, 23);
            this.MatrixDataGridView.Name = "MatrixDataGridView";
            this.MatrixDataGridView.Size = new System.Drawing.Size(867, 278);
            this.MatrixDataGridView.TabIndex = 0;
            // 
            // CheckInput
            // 
            this.CheckInput.Location = new System.Drawing.Point(541, 321);
            this.CheckInput.Name = "CheckInput";
            this.CheckInput.Size = new System.Drawing.Size(114, 48);
            this.CheckInput.TabIndex = 1;
            this.CheckInput.Text = "Проверить корректность ввода";
            this.CheckInput.UseVisualStyleBackColor = true;
            this.CheckInput.Click += new System.EventHandler(this.CheckInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "n";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(241, 321);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(145, 20);
            this.nBox.TabIndex = 6;
            // 
            // mBox
            // 
            this.mBox.Location = new System.Drawing.Point(49, 321);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(145, 20);
            this.mBox.TabIndex = 8;
            // 
            // ChangeMinElement
            // 
            this.ChangeMinElement.Location = new System.Drawing.Point(661, 321);
            this.ChangeMinElement.Name = "ChangeMinElement";
            this.ChangeMinElement.Size = new System.Drawing.Size(114, 48);
            this.ChangeMinElement.TabIndex = 9;
            this.ChangeMinElement.Text = "Заменить мин. на 99";
            this.ChangeMinElement.UseVisualStyleBackColor = true;
            this.ChangeMinElement.Click += new System.EventHandler(this.ChangeMinElement_Click);
            // 
            // CreateMatrix
            // 
            this.CreateMatrix.Location = new System.Drawing.Point(421, 321);
            this.CreateMatrix.Name = "CreateMatrix";
            this.CreateMatrix.Size = new System.Drawing.Size(114, 48);
            this.CreateMatrix.TabIndex = 10;
            this.CreateMatrix.Text = "Создание матриц";
            this.CreateMatrix.UseVisualStyleBackColor = true;
            this.CreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(781, 321);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(114, 48);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "Следующее задание";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(28, 356);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(291, 13);
            this.ErrorLabel.TabIndex = 14;
            this.ErrorLabel.Text = "Значение элемента A[i,j]  не корректно. Повторите ввод";
            this.ErrorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 382);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CreateMatrix);
            this.Controls.Add(this.ChangeMinElement);
            this.Controls.Add(this.mBox);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckInput);
            this.Controls.Add(this.MatrixDataGridView);
            this.Name = "Form1";
            this.Text = "Работа с матрицами";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatrixDataGridView;
        private System.Windows.Forms.Button CheckInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.TextBox mBox;
        private System.Windows.Forms.Button ChangeMinElement;
        private System.Windows.Forms.Button CreateMatrix;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

