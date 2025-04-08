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
            this.ListDisciplines_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Redakt = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListDisciplines_comboBox
            // 
            this.ListDisciplines_comboBox.BackColor = System.Drawing.SystemColors.Info;
            this.ListDisciplines_comboBox.FormattingEnabled = true;
            this.ListDisciplines_comboBox.Location = new System.Drawing.Point(407, 45);
            this.ListDisciplines_comboBox.Name = "ListDisciplines_comboBox";
            this.ListDisciplines_comboBox.Size = new System.Drawing.Size(121, 21);
            this.ListDisciplines_comboBox.TabIndex = 1;
            this.ListDisciplines_comboBox.SelectedIndexChanged += new System.EventHandler(this.ListDisciplines_comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список дисциплин";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1020, 251);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Redakt
            // 
            this.Redakt.Location = new System.Drawing.Point(266, 391);
            this.Redakt.Name = "Redakt";
            this.Redakt.Size = new System.Drawing.Size(75, 23);
            this.Redakt.TabIndex = 8;
            this.Redakt.Text = "Редактировать";
            this.Redakt.UseVisualStyleBackColor = true;
            this.Redakt.Click += new System.EventHandler(this.Redakt_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(674, 390);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 534);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Redakt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListDisciplines_comboBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ListDisciplines_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Redakt;
        private System.Windows.Forms.Button save;
    }
}

