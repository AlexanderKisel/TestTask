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
            this.sortGB = new System.Windows.Forms.GroupBox();
            this.dropSortBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortDown = new System.Windows.Forms.RadioButton();
            this.sortUp = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dismissedLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dropStatBtn = new System.Windows.Forms.Button();
            this.statBtn = new System.Windows.Forms.Button();
            this.endPeriodLbl = new System.Windows.Forms.Label();
            this.startPeriodLbl = new System.Windows.Forms.Label();
            this.statusLblForStat = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusCmbBoxForStat = new System.Windows.Forms.ComboBox();
            this.statOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.statisticsOutputLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personDgv)).BeginInit();
            this.filterGB.SuspendLayout();
            this.sortGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statOutputGroupBox.SuspendLayout();
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
            this.postCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postCmbBox.FormattingEnabled = true;
            this.postCmbBox.Location = new System.Drawing.Point(101, 74);
            this.postCmbBox.Name = "postCmbBox";
            this.postCmbBox.Size = new System.Drawing.Size(200, 21);
            this.postCmbBox.TabIndex = 2;
            // 
            // depCmbBox
            // 
            this.depCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depCmbBox.FormattingEnabled = true;
            this.depCmbBox.Location = new System.Drawing.Point(101, 47);
            this.depCmbBox.Name = "depCmbBox";
            this.depCmbBox.Size = new System.Drawing.Size(200, 21);
            this.depCmbBox.TabIndex = 1;
            // 
            // statusCmbBox
            // 
            this.statusCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCmbBox.FormattingEnabled = true;
            this.statusCmbBox.Location = new System.Drawing.Point(101, 20);
            this.statusCmbBox.Name = "statusCmbBox";
            this.statusCmbBox.Size = new System.Drawing.Size(200, 21);
            this.statusCmbBox.TabIndex = 0;
            // 
            // sortGB
            // 
            this.sortGB.Controls.Add(this.dropSortBtn);
            this.sortGB.Controls.Add(this.sortBtn);
            this.sortGB.Controls.Add(this.sortDown);
            this.sortGB.Controls.Add(this.sortUp);
            this.sortGB.Location = new System.Drawing.Point(608, 207);
            this.sortGB.Name = "sortGB";
            this.sortGB.Size = new System.Drawing.Size(307, 82);
            this.sortGB.TabIndex = 2;
            this.sortGB.TabStop = false;
            this.sortGB.Text = "Сортировка";
            // 
            // dropSortBtn
            // 
            this.dropSortBtn.Location = new System.Drawing.Point(165, 43);
            this.dropSortBtn.Name = "dropSortBtn";
            this.dropSortBtn.Size = new System.Drawing.Size(136, 23);
            this.dropSortBtn.TabIndex = 11;
            this.dropSortBtn.Text = "Сбросить";
            this.dropSortBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropSortBtn.UseVisualStyleBackColor = true;
            this.dropSortBtn.Click += new System.EventHandler(this.dropSortBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(6, 43);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(136, 23);
            this.sortBtn.TabIndex = 10;
            this.sortBtn.Text = "Сортировать";
            this.sortBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortDown
            // 
            this.sortDown.AutoSize = true;
            this.sortDown.Location = new System.Drawing.Point(165, 20);
            this.sortDown.Name = "sortDown";
            this.sortDown.Size = new System.Drawing.Size(125, 17);
            this.sortDown.TabIndex = 1;
            this.sortDown.TabStop = true;
            this.sortDown.Text = "Сортировать от Я-А";
            this.sortDown.UseVisualStyleBackColor = true;
            // 
            // sortUp
            // 
            this.sortUp.AutoSize = true;
            this.sortUp.Location = new System.Drawing.Point(7, 20);
            this.sortUp.Name = "sortUp";
            this.sortUp.Size = new System.Drawing.Size(125, 17);
            this.sortUp.TabIndex = 0;
            this.sortUp.TabStop = true;
            this.sortUp.Text = "Сортировать от А-Я";
            this.sortUp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(13, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 3;
            // 
            // dismissedLbl
            // 
            this.dismissedLbl.AutoSize = true;
            this.dismissedLbl.Location = new System.Drawing.Point(49, 361);
            this.dismissedLbl.Name = "dismissedLbl";
            this.dismissedLbl.Size = new System.Drawing.Size(270, 13);
            this.dismissedLbl.TabIndex = 4;
            this.dismissedLbl.Text = "Уволенные сотрудники выделены красным цветом";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dropStatBtn);
            this.groupBox1.Controls.Add(this.statBtn);
            this.groupBox1.Controls.Add(this.endPeriodLbl);
            this.groupBox1.Controls.Add(this.startPeriodLbl);
            this.groupBox1.Controls.Add(this.statusLblForStat);
            this.groupBox1.Controls.Add(this.endDateTimePicker);
            this.groupBox1.Controls.Add(this.startDateTimePicker);
            this.groupBox1.Controls.Add(this.statusCmbBoxForStat);
            this.groupBox1.Location = new System.Drawing.Point(608, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 160);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // dropStatBtn
            // 
            this.dropStatBtn.Location = new System.Drawing.Point(165, 121);
            this.dropStatBtn.Name = "dropStatBtn";
            this.dropStatBtn.Size = new System.Drawing.Size(136, 23);
            this.dropStatBtn.TabIndex = 12;
            this.dropStatBtn.Text = "Сбросить статистику";
            this.dropStatBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dropStatBtn.UseVisualStyleBackColor = true;
            this.dropStatBtn.Click += new System.EventHandler(this.dropStatBtn_Click);
            // 
            // statBtn
            // 
            this.statBtn.Location = new System.Drawing.Point(10, 121);
            this.statBtn.Name = "statBtn";
            this.statBtn.Size = new System.Drawing.Size(136, 23);
            this.statBtn.TabIndex = 12;
            this.statBtn.Text = "Показать статистику";
            this.statBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.statBtn.UseVisualStyleBackColor = true;
            this.statBtn.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // endPeriodLbl
            // 
            this.endPeriodLbl.AutoSize = true;
            this.endPeriodLbl.Location = new System.Drawing.Point(7, 92);
            this.endPeriodLbl.Name = "endPeriodLbl";
            this.endPeriodLbl.Size = new System.Drawing.Size(83, 13);
            this.endPeriodLbl.TabIndex = 12;
            this.endPeriodLbl.Text = "Конец периода";
            // 
            // startPeriodLbl
            // 
            this.startPeriodLbl.AutoSize = true;
            this.startPeriodLbl.Location = new System.Drawing.Point(4, 54);
            this.startPeriodLbl.Name = "startPeriodLbl";
            this.startPeriodLbl.Size = new System.Drawing.Size(89, 13);
            this.startPeriodLbl.TabIndex = 11;
            this.startPeriodLbl.Text = "Начало периода";
            // 
            // statusLblForStat
            // 
            this.statusLblForStat.AutoSize = true;
            this.statusLblForStat.Location = new System.Drawing.Point(23, 22);
            this.statusLblForStat.Name = "statusLblForStat";
            this.statusLblForStat.Size = new System.Drawing.Size(41, 13);
            this.statusLblForStat.TabIndex = 10;
            this.statusLblForStat.Text = "Статус";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(94, 89);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(94, 52);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // statusCmbBoxForStat
            // 
            this.statusCmbBoxForStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCmbBoxForStat.FormattingEnabled = true;
            this.statusCmbBoxForStat.Location = new System.Drawing.Point(94, 19);
            this.statusCmbBoxForStat.Name = "statusCmbBoxForStat";
            this.statusCmbBoxForStat.Size = new System.Drawing.Size(200, 21);
            this.statusCmbBoxForStat.TabIndex = 1;
            // 
            // statOutputGroupBox
            // 
            this.statOutputGroupBox.Controls.Add(this.statisticsOutputLbl);
            this.statOutputGroupBox.Location = new System.Drawing.Point(13, 389);
            this.statOutputGroupBox.Name = "statOutputGroupBox";
            this.statOutputGroupBox.Size = new System.Drawing.Size(589, 80);
            this.statOutputGroupBox.TabIndex = 6;
            this.statOutputGroupBox.TabStop = false;
            this.statOutputGroupBox.Text = "Окно вывода статистики";
            // 
            // statisticsOutputLbl
            // 
            this.statisticsOutputLbl.AutoSize = true;
            this.statisticsOutputLbl.Location = new System.Drawing.Point(6, 32);
            this.statisticsOutputLbl.Name = "statisticsOutputLbl";
            this.statisticsOutputLbl.Size = new System.Drawing.Size(0, 13);
            this.statisticsOutputLbl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 481);
            this.Controls.Add(this.statOutputGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dismissedLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sortGB);
            this.Controls.Add(this.filterGB);
            this.Controls.Add(this.personDgv);
            this.Name = "MainForm";
            this.Text = "Список сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.personDgv)).EndInit();
            this.filterGB.ResumeLayout(false);
            this.filterGB.PerformLayout();
            this.sortGB.ResumeLayout(false);
            this.sortGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statOutputGroupBox.ResumeLayout(false);
            this.statOutputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox sortGB;
        private System.Windows.Forms.Button dropSortBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.RadioButton sortDown;
        private System.Windows.Forms.RadioButton sortUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dismissedLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.ComboBox statusCmbBoxForStat;
        private System.Windows.Forms.Button dropStatBtn;
        private System.Windows.Forms.Button statBtn;
        private System.Windows.Forms.Label endPeriodLbl;
        private System.Windows.Forms.Label startPeriodLbl;
        private System.Windows.Forms.Label statusLblForStat;
        private System.Windows.Forms.GroupBox statOutputGroupBox;
        private System.Windows.Forms.Label statisticsOutputLbl;
    }
}

