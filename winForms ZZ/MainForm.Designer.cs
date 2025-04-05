namespace winForms_ZZ
{
    partial class MainForm
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
            this.ListQueshions_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.ListDisciplines_comboBox = new System.Windows.Forms.ComboBox();
            this.EnteringNumber = new System.Windows.Forms.TextBox();
            this.Press = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListQueshions_RichTextBox
            // 
            this.ListQueshions_RichTextBox.Location = new System.Drawing.Point(12, 36);
            this.ListQueshions_RichTextBox.Name = "ListQueshions_RichTextBox";
            this.ListQueshions_RichTextBox.Size = new System.Drawing.Size(443, 381);
            this.ListQueshions_RichTextBox.TabIndex = 0;
            this.ListQueshions_RichTextBox.Text = "";
           
            // 
            // ListDisciplines_comboBox
            // 
            this.ListDisciplines_comboBox.BackColor = System.Drawing.SystemColors.Info;
            this.ListDisciplines_comboBox.FormattingEnabled = true;
            this.ListDisciplines_comboBox.Location = new System.Drawing.Point(480, 47);
            this.ListDisciplines_comboBox.Name = "ListDisciplines_comboBox";
            this.ListDisciplines_comboBox.Size = new System.Drawing.Size(121, 21);
            this.ListDisciplines_comboBox.TabIndex = 1;
            this.ListDisciplines_comboBox.SelectedIndexChanged += new System.EventHandler(this.ListDisciplines_comboBox_SelectedIndexChanged);
            // 
            // EnteringNumber
            // 
            this.EnteringNumber.Location = new System.Drawing.Point(501, 161);
            this.EnteringNumber.Name = "EnteringNumber";
            this.EnteringNumber.Size = new System.Drawing.Size(100, 20);
            this.EnteringNumber.TabIndex = 2;
            // 
            // Press
            // 
            this.Press.Location = new System.Drawing.Point(490, 187);
            this.Press.Name = "Press";
            this.Press.Size = new System.Drawing.Size(134, 34);
            this.Press.TabIndex = 3;
            this.Press.Text = "Выбрать";
            this.Press.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список вопросов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список дисциплин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выбор номеров вопросов";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Press);
            this.Controls.Add(this.EnteringNumber);
            this.Controls.Add(this.ListDisciplines_comboBox);
            this.Controls.Add(this.ListQueshions_RichTextBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ListQueshions_RichTextBox;
        private System.Windows.Forms.ComboBox ListDisciplines_comboBox;
        private System.Windows.Forms.TextBox EnteringNumber;
        private System.Windows.Forms.Button Press;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

