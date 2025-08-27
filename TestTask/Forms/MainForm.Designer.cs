namespace TestTask
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
            this.personDgv = new System.Windows.Forms.DataGridView();
            this.filterGB = new System.Windows.Forms.GroupBox();
            this.surnameTLbl = new System.Windows.Forms.Label();
            this.postLbl = new System.Windows.Forms.Label();
            this.depLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.dropTxtBox = new System.Windows.Forms.Button();
            this.applyTxtBox = new System.Windows.Forms.Button();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.postCmbBox = new System.Windows.Forms.ComboBox();
            this.depCmbBox = new System.Windows.Forms.ComboBox();
            this.statusCmbBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.personDgv)).BeginInit();
            this.filterGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // personDgv
            // 
            this.personDgv.AllowUserToAddRows = false;
            this.personDgv.AllowUserToDeleteRows = false;
            this.personDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDgv.Location = new System.Drawing.Point(12, 12);
            this.personDgv.Name = "personDgv";
            this.personDgv.ReadOnly = true;
            this.personDgv.Size = new System.Drawing.Size(590, 335);
            this.personDgv.TabIndex = 0;
            // 
            // filterGB
            // 
            this.filterGB.Controls.Add(this.surnameTLbl);
            this.filterGB.Controls.Add(this.postLbl);
            this.filterGB.Controls.Add(this.depLbl);
            this.filterGB.Controls.Add(this.statusLbl);
            this.filterGB.Controls.Add(this.dropTxtBox);
            this.filterGB.Controls.Add(this.applyTxtBox);
            this.filterGB.Controls.Add(this.surnameTxtBox);
            this.filterGB.Controls.Add(this.postCmbBox);
            this.filterGB.Controls.Add(this.depCmbBox);
            this.filterGB.Controls.Add(this.statusCmbBox);
            this.filterGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filterGB.Location = new System.Drawing.Point(608, 12);
            this.filterGB.Name = "filterGB";
            this.filterGB.Size = new System.Drawing.Size(307, 161);
            this.filterGB.TabIndex = 1;
            this.filterGB.TabStop = false;
            this.filterGB.Text = "Фильтр";
            // 
            // surnameTLbl
            // 
            this.surnameTLbl.AutoSize = true;
            this.surnameTLbl.Location = new System.Drawing.Point(23, 105);
            this.surnameTLbl.Name = "surnameTLbl";
            this.surnameTLbl.Size = new System.Drawing.Size(56, 13);
            this.surnameTLbl.TabIndex = 9;
            this.surnameTLbl.Text = "Фамилия";
            // 
            // postLbl
            // 
            this.postLbl.AutoSize = true;
            this.postLbl.Location = new System.Drawing.Point(23, 77);
            this.postLbl.Name = "postLbl";
            this.postLbl.Size = new System.Drawing.Size(65, 13);
            this.postLbl.TabIndex = 8;
            this.postLbl.Text = "Должность";
            // 
            // depLbl
            // 
            this.depLbl.AutoSize = true;
            this.depLbl.Location = new System.Drawing.Point(23, 50);
            this.depLbl.Name = "depLbl";
            this.depLbl.Size = new System.Drawing.Size(38, 13);
            this.depLbl.TabIndex = 7;
            this.depLbl.Text = "Отдел";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(23, 23);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(41, 13);
            this.statusLbl.TabIndex = 6;
            this.statusLbl.Text = "Статус";
            // 
            // dropTxtBox
            // 
            this.dropTxtBox.Location = new System.Drawing.Point(165, 128);
            this.dropTxtBox.Name = "dropTxtBox";
            this.dropTxtBox.Size = new System.Drawing.Size(136, 23);
            this.dropTxtBox.TabIndex = 5;
            this.dropTxtBox.Text = "Сбросить";
            this.dropTxtBox.UseVisualStyleBackColor = true;
            this.dropTxtBox.Click += new System.EventHandler(this.dropTxtBox_Click);
            // 
            // applyTxtBox
            // 
            this.applyTxtBox.Location = new System.Drawing.Point(6, 128);
            this.applyTxtBox.Name = "applyTxtBox";
            this.applyTxtBox.Size = new System.Drawing.Size(136, 23);
            this.applyTxtBox.TabIndex = 4;
            this.applyTxtBox.Text = "Применить";
            this.applyTxtBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.applyTxtBox.UseVisualStyleBackColor = true;
            this.applyTxtBox.Click += new System.EventHandler(this.applyTxtBox_Click);
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Location = new System.Drawing.Point(101, 102);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(200, 20);
            this.surnameTxtBox.TabIndex = 3;
            // 
            // postCmbBox
            // 
            this.postCmbBox.FormattingEnabled = true;
            this.postCmbBox.Location = new System.Drawing.Point(101, 74);
            this.postCmbBox.Name = "postCmbBox";
            this.postCmbBox.Size = new System.Drawing.Size(200, 21);
            this.postCmbBox.TabIndex = 2;
            // 
            // depCmbBox
            // 
            this.depCmbBox.FormattingEnabled = true;
            this.depCmbBox.Location = new System.Drawing.Point(101, 47);
            this.depCmbBox.Name = "depCmbBox";
            this.depCmbBox.Size = new System.Drawing.Size(200, 21);
            this.depCmbBox.TabIndex = 1;
            // 
            // statusCmbBox
            // 
            this.statusCmbBox.FormattingEnabled = true;
            this.statusCmbBox.Location = new System.Drawing.Point(101, 20);
            this.statusCmbBox.Name = "statusCmbBox";
            this.statusCmbBox.Size = new System.Drawing.Size(200, 21);
            this.statusCmbBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 481);
            this.Controls.Add(this.filterGB);
            this.Controls.Add(this.personDgv);
            this.Name = "MainForm";
            this.Text = "Список сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.personDgv)).EndInit();
            this.filterGB.ResumeLayout(false);
            this.filterGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView personDgv;
        private System.Windows.Forms.GroupBox filterGB;
        private System.Windows.Forms.Label depLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button dropTxtBox;
        private System.Windows.Forms.Button applyTxtBox;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.ComboBox postCmbBox;
        private System.Windows.Forms.ComboBox depCmbBox;
        private System.Windows.Forms.ComboBox statusCmbBox;
        private System.Windows.Forms.Label surnameTLbl;
        private System.Windows.Forms.Label postLbl;
    }
}

