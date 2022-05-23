namespace AIS_School.Forms
{
    partial class InsertAchiviment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pupilsCombo = new System.Windows.Forms.ComboBox();
            this.eventCombo = new System.Windows.Forms.ComboBox();
            this.prizzersCoeffCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.canscelButton = new System.Windows.Forms.Button();
            this.exampleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ученик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Мероприятие";
            // 
            // pupilsCombo
            // 
            this.pupilsCombo.FormattingEnabled = true;
            this.pupilsCombo.Location = new System.Drawing.Point(204, 46);
            this.pupilsCombo.Name = "pupilsCombo";
            this.pupilsCombo.Size = new System.Drawing.Size(504, 28);
            this.pupilsCombo.TabIndex = 2;
            // 
            // eventCombo
            // 
            this.eventCombo.FormattingEnabled = true;
            this.eventCombo.Location = new System.Drawing.Point(204, 82);
            this.eventCombo.Name = "eventCombo";
            this.eventCombo.Size = new System.Drawing.Size(504, 28);
            this.eventCombo.TabIndex = 3;
            // 
            // prizzersCoeffCombo
            // 
            this.prizzersCoeffCombo.FormattingEnabled = true;
            this.prizzersCoeffCombo.Location = new System.Drawing.Point(204, 116);
            this.prizzersCoeffCombo.Name = "prizzersCoeffCombo";
            this.prizzersCoeffCombo.Size = new System.Drawing.Size(504, 28);
            this.prizzersCoeffCombo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат";
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.clearAllButton.FlatAppearance.BorderSize = 0;
            this.clearAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.clearAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearAllButton.Location = new System.Drawing.Point(256, 167);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(222, 78);
            this.clearAllButton.TabIndex = 112;
            this.clearAllButton.Text = "Сбросить всё";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // canscelButton
            // 
            this.canscelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.canscelButton.FlatAppearance.BorderSize = 0;
            this.canscelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.canscelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.canscelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canscelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canscelButton.Location = new System.Drawing.Point(486, 167);
            this.canscelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.canscelButton.Name = "canscelButton";
            this.canscelButton.Size = new System.Drawing.Size(222, 78);
            this.canscelButton.TabIndex = 113;
            this.canscelButton.Text = "Отмена";
            this.canscelButton.UseVisualStyleBackColor = false;
            this.canscelButton.Click += new System.EventHandler(this.canscelButton_Click);
            // 
            // exampleButton
            // 
            this.exampleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            this.exampleButton.FlatAppearance.BorderSize = 0;
            this.exampleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.exampleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(210)))));
            this.exampleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exampleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exampleButton.Location = new System.Drawing.Point(53, 167);
            this.exampleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exampleButton.Name = "exampleButton";
            this.exampleButton.Size = new System.Drawing.Size(195, 78);
            this.exampleButton.TabIndex = 111;
            this.exampleButton.Text = "Добавить";
            this.exampleButton.UseVisualStyleBackColor = false;
            this.exampleButton.Click += new System.EventHandler(this.exampleButton_Click);
            // 
            // InsertAchiviment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 293);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.canscelButton);
            this.Controls.Add(this.exampleButton);
            this.Controls.Add(this.prizzersCoeffCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventCombo);
            this.Controls.Add(this.pupilsCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InsertAchiviment";
            this.Text = "Добавление достижения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pupilsCombo;
        private System.Windows.Forms.ComboBox eventCombo;
        private System.Windows.Forms.ComboBox prizzersCoeffCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button canscelButton;
        private System.Windows.Forms.Button exampleButton;
    }
}