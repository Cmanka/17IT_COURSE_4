namespace labaTxt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressList = new System.Windows.Forms.ListBox();
            this.phoneList = new System.Windows.Forms.ListBox();
            this.groupList = new System.Windows.Forms.ListBox();
            this.dateList = new System.Windows.Forms.ListBox();
            this.fullNameList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.isDeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.binRadioButton = new System.Windows.Forms.RadioButton();
            this.txtRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addressList);
            this.groupBox1.Controls.Add(this.phoneList);
            this.groupBox1.Controls.Add(this.groupList);
            this.groupBox1.Controls.Add(this.dateList);
            this.groupBox1.Controls.Add(this.fullNameList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(625, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Адрес";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(467, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(327, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Группа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(155, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(43, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "ФИО";
            // 
            // addressList
            // 
            this.addressList.FormattingEnabled = true;
            this.addressList.ItemHeight = 16;
            this.addressList.Location = new System.Drawing.Point(592, 53);
            this.addressList.Name = "addressList";
            this.addressList.Size = new System.Drawing.Size(120, 468);
            this.addressList.TabIndex = 4;
            // 
            // phoneList
            // 
            this.phoneList.FormattingEnabled = true;
            this.phoneList.ItemHeight = 16;
            this.phoneList.Location = new System.Drawing.Point(442, 53);
            this.phoneList.Name = "phoneList";
            this.phoneList.Size = new System.Drawing.Size(120, 468);
            this.phoneList.TabIndex = 3;
            // 
            // groupList
            // 
            this.groupList.FormattingEnabled = true;
            this.groupList.ItemHeight = 16;
            this.groupList.Location = new System.Drawing.Point(296, 53);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(120, 468);
            this.groupList.TabIndex = 2;
            // 
            // dateList
            // 
            this.dateList.FormattingEnabled = true;
            this.dateList.ItemHeight = 16;
            this.dateList.Location = new System.Drawing.Point(151, 53);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(120, 468);
            this.dateList.TabIndex = 1;
            // 
            // fullNameList
            // 
            this.fullNameList.FormattingEnabled = true;
            this.fullNameList.ItemHeight = 16;
            this.fullNameList.Location = new System.Drawing.Point(6, 53);
            this.fullNameList.Name = "fullNameList";
            this.fullNameList.Size = new System.Drawing.Size(120, 468);
            this.fullNameList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.addressTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.phoneTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.fullNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(758, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление записи";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(70, 234);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 36);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(113, 183);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Адрес";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(113, 147);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон";
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(113, 108);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(100, 22);
            this.groupTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Группа";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(113, 70);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(113, 32);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.isDeleteCheckBox);
            this.groupBox3.Controls.Add(this.removeButton);
            this.groupBox3.Location = new System.Drawing.Point(758, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удалить выделенную запись";
            // 
            // isDeleteCheckBox
            // 
            this.isDeleteCheckBox.AutoSize = true;
            this.isDeleteCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isDeleteCheckBox.Location = new System.Drawing.Point(9, 21);
            this.isDeleteCheckBox.Name = "isDeleteCheckBox";
            this.isDeleteCheckBox.Size = new System.Drawing.Size(183, 21);
            this.isDeleteCheckBox.TabIndex = 12;
            this.isDeleteCheckBox.Text = "Подтвердить удаление";
            this.isDeleteCheckBox.UseVisualStyleBackColor = true;
            this.isDeleteCheckBox.CheckedChanged += new System.EventHandler(this.isDeleteCheckBox_CheckedChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(70, 44);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(143, 36);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.binRadioButton);
            this.groupBox4.Controls.Add(this.txtRadioButton);
            this.groupBox4.Controls.Add(this.saveButton);
            this.groupBox4.Controls.Add(this.loadButton);
            this.groupBox4.Location = new System.Drawing.Point(758, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 135);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Загрузить/Сохранить базу";
            // 
            // binRadioButton
            // 
            this.binRadioButton.AutoSize = true;
            this.binRadioButton.Location = new System.Drawing.Point(9, 92);
            this.binRadioButton.Name = "binRadioButton";
            this.binRadioButton.Size = new System.Drawing.Size(52, 21);
            this.binRadioButton.TabIndex = 15;
            this.binRadioButton.TabStop = true;
            this.binRadioButton.Text = ".bin";
            this.binRadioButton.UseVisualStyleBackColor = true;
            // 
            // txtRadioButton
            // 
            this.txtRadioButton.AutoSize = true;
            this.txtRadioButton.Location = new System.Drawing.Point(9, 43);
            this.txtRadioButton.Name = "txtRadioButton";
            this.txtRadioButton.Size = new System.Drawing.Size(47, 21);
            this.txtRadioButton.TabIndex = 14;
            this.txtRadioButton.TabStop = true;
            this.txtRadioButton.Text = ".txt";
            this.txtRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(70, 84);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(143, 36);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(70, 35);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(143, 36);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 560);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox addressList;
        private System.Windows.Forms.ListBox phoneList;
        private System.Windows.Forms.ListBox groupList;
        private System.Windows.Forms.ListBox dateList;
        private System.Windows.Forms.ListBox fullNameList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox isDeleteCheckBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton binRadioButton;
        private System.Windows.Forms.RadioButton txtRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

