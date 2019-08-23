namespace RSelexter
{
    partial class mainForm
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
            this.itemsTextBox = new System.Windows.Forms.TextBox();
            this.rselectButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsTextBox
            // 
            this.itemsTextBox.Location = new System.Drawing.Point(13, 33);
            this.itemsTextBox.Multiline = true;
            this.itemsTextBox.Name = "itemsTextBox";
            this.itemsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemsTextBox.Size = new System.Drawing.Size(616, 257);
            this.itemsTextBox.TabIndex = 0;
            // 
            // rselectButton
            // 
            this.rselectButton.Location = new System.Drawing.Point(13, 311);
            this.rselectButton.Name = "rselectButton";
            this.rselectButton.Size = new System.Drawing.Size(298, 23);
            this.rselectButton.TabIndex = 1;
            this.rselectButton.Text = "Выбрать";
            this.rselectButton.UseVisualStyleBackColor = true;
            this.rselectButton.Click += new System.EventHandler(this.rselectButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(327, 311);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(302, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(24, 349);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(215, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Здесь будет случайно выбранная строка";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 374);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.rselectButton);
            this.Controls.Add(this.itemsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Выбор случайного элемента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemsTextBox;
        private System.Windows.Forms.Button rselectButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

