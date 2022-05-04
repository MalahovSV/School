
namespace AIS_School.Forms
{
    partial class ConnectDataBaseWindow
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
            this.serverNameBox = new System.Windows.Forms.TextBox();
            this.createConnectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.dataBasesList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewPasswordCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // serverNameBox
            // 
            this.serverNameBox.Location = new System.Drawing.Point(245, 75);
            this.serverNameBox.Name = "serverNameBox";
            this.serverNameBox.Size = new System.Drawing.Size(236, 27);
            this.serverNameBox.TabIndex = 0;
            // 
            // createConnectButton
            // 
            this.createConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.createConnectButton.FlatAppearance.BorderSize = 0;
            this.createConnectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.createConnectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.createConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createConnectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createConnectButton.Location = new System.Drawing.Point(70, 293);
            this.createConnectButton.Name = "createConnectButton";
            this.createConnectButton.Size = new System.Drawing.Size(186, 73);
            this.createConnectButton.TabIndex = 4;
            this.createConnectButton.Text = "Установить соединение";
            this.createConnectButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(325, 293);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(186, 73);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя пользователя";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(245, 117);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(236, 27);
            this.userNameBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пароль";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(245, 164);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(236, 27);
            this.passwordBox.TabIndex = 2;
            // 
            // dataBasesList
            // 
            this.dataBasesList.FormattingEnabled = true;
            this.dataBasesList.Location = new System.Drawing.Point(245, 232);
            this.dataBasesList.Name = "dataBasesList";
            this.dataBasesList.Size = new System.Drawing.Size(236, 28);
            this.dataBasesList.TabIndex = 3;
            this.dataBasesList.DropDown += new System.EventHandler(this.dataBasesList_DropDown);
            this.dataBasesList.SelectedIndexChanged += new System.EventHandler(this.dataBasesList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "База данных";
            // 
            // viewPasswordCheck
            // 
            this.viewPasswordCheck.AutoSize = true;
            this.viewPasswordCheck.Location = new System.Drawing.Point(245, 197);
            this.viewPasswordCheck.Name = "viewPasswordCheck";
            this.viewPasswordCheck.Size = new System.Drawing.Size(167, 24);
            this.viewPasswordCheck.TabIndex = 11;
            this.viewPasswordCheck.Text = "показать пароль";
            this.viewPasswordCheck.UseVisualStyleBackColor = true;
            // 
            // ConnectDataBaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.viewPasswordCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataBasesList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createConnectButton);
            this.Controls.Add(this.serverNameBox);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ConnectDataBaseWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Соединение с базой данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverNameBox;
        private System.Windows.Forms.Button createConnectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.ComboBox dataBasesList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox viewPasswordCheck;
    }
}