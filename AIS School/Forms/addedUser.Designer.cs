namespace AIS_School.Forms
{
    partial class addedUser
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
            this.exampleButton = new System.Windows.Forms.Button();
            this.canscelButton = new System.Windows.Forms.Button();
            this.roleGroup = new System.Windows.Forms.GroupBox();
            this.adminRadio = new System.Windows.Forms.RadioButton();
            this.teacherRadio = new System.Windows.Forms.RadioButton();
            this.pupilRadio = new System.Windows.Forms.RadioButton();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.SecondNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.DateBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.classGroup = new System.Windows.Forms.GroupBox();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.NumberPhone = new System.Windows.Forms.MaskedTextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionCombo = new System.Windows.Forms.ComboBox();
            this.roleGroup.SuspendLayout();
            this.classGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // exampleButton
            // 
            this.exampleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.exampleButton.FlatAppearance.BorderSize = 0;
            this.exampleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.exampleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.exampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exampleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exampleButton.Location = new System.Drawing.Point(46, 377);
            this.exampleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exampleButton.Name = "exampleButton";
            this.exampleButton.Size = new System.Drawing.Size(195, 78);
            this.exampleButton.TabIndex = 100;
            this.exampleButton.Text = "Добавить";
            this.exampleButton.UseVisualStyleBackColor = false;
            this.exampleButton.Click += new System.EventHandler(this.exampleButton_Click);
            // 
            // canscelButton
            // 
            this.canscelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.canscelButton.FlatAppearance.BorderSize = 0;
            this.canscelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.canscelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.canscelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canscelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canscelButton.Location = new System.Drawing.Point(621, 377);
            this.canscelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.canscelButton.Name = "canscelButton";
            this.canscelButton.Size = new System.Drawing.Size(222, 78);
            this.canscelButton.TabIndex = 110;
            this.canscelButton.Text = "Отмена";
            this.canscelButton.UseVisualStyleBackColor = false;
            this.canscelButton.Click += new System.EventHandler(this.canscelButton_Click);
            // 
            // roleGroup
            // 
            this.roleGroup.Controls.Add(this.pupilRadio);
            this.roleGroup.Controls.Add(this.teacherRadio);
            this.roleGroup.Controls.Add(this.classGroup);
            this.roleGroup.Controls.Add(this.adminRadio);
            this.roleGroup.Location = new System.Drawing.Point(463, 51);
            this.roleGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roleGroup.Name = "roleGroup";
            this.roleGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roleGroup.Size = new System.Drawing.Size(380, 284);
            this.roleGroup.TabIndex = 90;
            this.roleGroup.TabStop = false;
            this.roleGroup.Text = "Роль";
            // 
            // adminRadio
            // 
            this.adminRadio.AutoSize = true;
            this.adminRadio.Location = new System.Drawing.Point(22, 40);
            this.adminRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminRadio.Name = "adminRadio";
            this.adminRadio.Size = new System.Drawing.Size(149, 24);
            this.adminRadio.TabIndex = 0;
            this.adminRadio.TabStop = true;
            this.adminRadio.Text = "Администратор";
            this.adminRadio.UseVisualStyleBackColor = true;
            this.adminRadio.CheckedChanged += new System.EventHandler(this.adminRadio_CheckedChanged);
            // 
            // teacherRadio
            // 
            this.teacherRadio.AutoSize = true;
            this.teacherRadio.Location = new System.Drawing.Point(22, 75);
            this.teacherRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacherRadio.Name = "teacherRadio";
            this.teacherRadio.Size = new System.Drawing.Size(92, 24);
            this.teacherRadio.TabIndex = 1;
            this.teacherRadio.TabStop = true;
            this.teacherRadio.Text = "Учитель";
            this.teacherRadio.UseVisualStyleBackColor = true;
            this.teacherRadio.CheckedChanged += new System.EventHandler(this.teacherRadio_CheckedChanged);
            // 
            // pupilRadio
            // 
            this.pupilRadio.AutoSize = true;
            this.pupilRadio.Location = new System.Drawing.Point(22, 111);
            this.pupilRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pupilRadio.Name = "pupilRadio";
            this.pupilRadio.Size = new System.Drawing.Size(81, 24);
            this.pupilRadio.TabIndex = 2;
            this.pupilRadio.TabStop = true;
            this.pupilRadio.Text = "Ученик";
            this.pupilRadio.UseVisualStyleBackColor = true;
            this.pupilRadio.CheckedChanged += new System.EventHandler(this.pupilRadio_CheckedChanged);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(189, 51);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(256, 26);
            this.loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(189, 83);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(256, 26);
            this.passwordBox.TabIndex = 10;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(189, 150);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(256, 26);
            this.SurnameBox.TabIndex = 30;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(189, 182);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(256, 26);
            this.FirstNameBox.TabIndex = 40;
            // 
            // SecondNameBox
            // 
            this.SecondNameBox.Location = new System.Drawing.Point(189, 214);
            this.SecondNameBox.Name = "SecondNameBox";
            this.SecondNameBox.Size = new System.Drawing.Size(256, 26);
            this.SecondNameBox.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Почта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Номер телефона";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(189, 309);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(256, 26);
            this.emailBox.TabIndex = 80;
            // 
            // DateBirthPucker
            // 
            this.DateBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBirthPicker.Location = new System.Drawing.Point(189, 245);
            this.DateBirthPicker.Name = "DateBirthPucker";
            this.DateBirthPicker.Size = new System.Drawing.Size(256, 26);
            this.DateBirthPicker.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Дата рождения";
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(189, 115);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(160, 24);
            this.showPassword.TabIndex = 20;
            this.showPassword.Text = "Показать пароль";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.clearAllButton.FlatAppearance.BorderSize = 0;
            this.clearAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.clearAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearAllButton.Location = new System.Drawing.Point(314, 377);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(222, 78);
            this.clearAllButton.TabIndex = 101;
            this.clearAllButton.Text = "Отчистить всё";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // classGroup
            // 
            this.classGroup.Controls.Add(this.positionLabel);
            this.classGroup.Controls.Add(this.classLabel);
            this.classGroup.Controls.Add(this.positionCombo);
            this.classGroup.Controls.Add(this.classBox);
            this.classGroup.Location = new System.Drawing.Point(7, 160);
            this.classGroup.Name = "classGroup";
            this.classGroup.Size = new System.Drawing.Size(366, 116);
            this.classGroup.TabIndex = 111;
            this.classGroup.TabStop = false;
            this.classGroup.Text = "Опции";
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(117, 30);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(243, 28);
            this.classBox.TabIndex = 0;
            this.classBox.Visible = false;
            this.classBox.VisibleChanged += new System.EventHandler(this.classBox_VisibleChanged);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(12, 33);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(54, 20);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "Класс";
            this.classLabel.Visible = false;
            // 
            // NumberPhone
            // 
            this.NumberPhone.Location = new System.Drawing.Point(189, 277);
            this.NumberPhone.Mask = "+7 (999) 000-0000";
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.Size = new System.Drawing.Size(256, 26);
            this.NumberPhone.TabIndex = 2;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(16, 33);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(95, 20);
            this.positionLabel.TabIndex = 1;
            this.positionLabel.Text = "Должность";
            this.positionLabel.Visible = false;
            // 
            // positionCombo
            // 
            this.positionCombo.FormattingEnabled = true;
            this.positionCombo.Location = new System.Drawing.Point(117, 30);
            this.positionCombo.Name = "positionCombo";
            this.positionCombo.Size = new System.Drawing.Size(243, 28);
            this.positionCombo.TabIndex = 0;
            this.positionCombo.Visible = false;
            this.positionCombo.VisibleChanged += new System.EventHandler(this.positionCombo_VisibleChanged);
            // 
            // addedUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 603);
            this.Controls.Add(this.NumberPhone);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateBirthPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.roleGroup);
            this.Controls.Add(this.canscelButton);
            this.Controls.Add(this.exampleButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addedUser";
            this.Text = "Новый пользователь";
            this.Load += new System.EventHandler(this.addedUser_Load);
            this.roleGroup.ResumeLayout(false);
            this.roleGroup.PerformLayout();
            this.classGroup.ResumeLayout(false);
            this.classGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exampleButton;
        private System.Windows.Forms.Button canscelButton;
        private System.Windows.Forms.GroupBox roleGroup;
        private System.Windows.Forms.RadioButton pupilRadio;
        private System.Windows.Forms.RadioButton teacherRadio;
        private System.Windows.Forms.RadioButton adminRadio;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox SecondNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.DateTimePicker DateBirthPicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.GroupBox classGroup;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.MaskedTextBox NumberPhone;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.ComboBox positionCombo;
    }
}