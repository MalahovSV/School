namespace AIS_School.Forms
{
    partial class PortfolioPupil
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
            this.gridPrizers = new System.Windows.Forms.DataGridView();
            this.SurnamePupil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePupil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrizers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPrizers
            // 
            this.gridPrizers.AllowUserToAddRows = false;
            this.gridPrizers.AllowUserToDeleteRows = false;
            this.gridPrizers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridPrizers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridPrizers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrizers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnamePupil,
            this.NamePupil,
            this.SecondName,
            this.EventName,
            this.DateEvent,
            this.LevelEvent,
            this.WinPlace,
            this.TypeEvent,
            this.Balls});
            this.gridPrizers.Location = new System.Drawing.Point(12, 145);
            this.gridPrizers.Name = "gridPrizers";
            this.gridPrizers.ReadOnly = true;
            this.gridPrizers.Size = new System.Drawing.Size(1124, 358);
            this.gridPrizers.TabIndex = 0;
            // 
            // SurnamePupil
            // 
            this.SurnamePupil.HeaderText = "Фамилия";
            this.SurnamePupil.Name = "SurnamePupil";
            this.SurnamePupil.ReadOnly = true;
            this.SurnamePupil.Width = 108;
            // 
            // NamePupil
            // 
            this.NamePupil.HeaderText = "Имя";
            this.NamePupil.Name = "NamePupil";
            this.NamePupil.ReadOnly = true;
            this.NamePupil.Width = 67;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "Отчество";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Width = 110;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Мероприятие";
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.Width = 144;
            // 
            // DateEvent
            // 
            this.DateEvent.HeaderText = "Дата мероприятия";
            this.DateEvent.Name = "DateEvent";
            this.DateEvent.ReadOnly = true;
            this.DateEvent.Width = 170;
            // 
            // LevelEvent
            // 
            this.LevelEvent.HeaderText = "Уровень";
            this.LevelEvent.Name = "LevelEvent";
            this.LevelEvent.ReadOnly = true;
            this.LevelEvent.Width = 104;
            // 
            // WinPlace
            // 
            this.WinPlace.HeaderText = "Место";
            this.WinPlace.Name = "WinPlace";
            this.WinPlace.ReadOnly = true;
            this.WinPlace.Width = 83;
            // 
            // TypeEvent
            // 
            this.TypeEvent.HeaderText = "Классификация";
            this.TypeEvent.Name = "TypeEvent";
            this.TypeEvent.ReadOnly = true;
            this.TypeEvent.Width = 165;
            // 
            // Balls
            // 
            this.Balls.HeaderText = "Баллы";
            this.Balls.Name = "Balls";
            this.Balls.ReadOnly = true;
            this.Balls.Width = 87;
            // 
            // typeFilter
            // 
            this.typeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeFilter.FormattingEnabled = true;
            this.typeFilter.Items.AddRange(new object[] {
            "Отсутствует",
            "По ученику",
            "По событию"});
            this.typeFilter.Location = new System.Drawing.Point(254, 36);
            this.typeFilter.Name = "typeFilter";
            this.typeFilter.Size = new System.Drawing.Size(290, 28);
            this.typeFilter.TabIndex = 1;
            this.typeFilter.SelectedIndexChanged += new System.EventHandler(this.typeFilter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ItemFilter);
            this.groupBox1.Controls.Add(this.typeFilter);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выборка по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип фильтрации";
            // 
            // ItemFilter
            // 
            this.ItemFilter.Enabled = false;
            this.ItemFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemFilter.FormattingEnabled = true;
            this.ItemFilter.Location = new System.Drawing.Point(254, 70);
            this.ItemFilter.Name = "ItemFilter";
            this.ItemFilter.Size = new System.Drawing.Size(290, 28);
            this.ItemFilter.TabIndex = 2;
            this.ItemFilter.SelectedIndexChanged += new System.EventHandler(this.ItemFilter_SelectedIndexChanged);
            // 
            // PortfolioPupil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridPrizers);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PortfolioPupil";
            this.Text = "PortfolioPupil";
            ((System.ComponentModel.ISupportInitialize)(this.gridPrizers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPrizers;
        private System.Windows.Forms.ComboBox typeFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ItemFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnamePupil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePupil;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balls;
    }
}