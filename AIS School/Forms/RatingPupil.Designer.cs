namespace AIS_School.Forms
{
    partial class RatingPupil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPupilsRating = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endData = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выводНаПечатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPupil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePupil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassPupil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вДокументWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridPupilsRating)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPupilsRating
            // 
            this.gridPupilsRating.AllowUserToAddRows = false;
            this.gridPupilsRating.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPupilsRating.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridPupilsRating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.gridPupilsRating.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridPupilsRating.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridPupilsRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPupilsRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.IDPupil,
            this.NamePupil,
            this.ClassPupil,
            this.Balls});
            this.gridPupilsRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPupilsRating.Location = new System.Drawing.Point(5, 188);
            this.gridPupilsRating.Margin = new System.Windows.Forms.Padding(5);
            this.gridPupilsRating.Name = "gridPupilsRating";
            this.gridPupilsRating.ReadOnly = true;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPupilsRating.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridPupilsRating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPupilsRating.Size = new System.Drawing.Size(1366, 420);
            this.gridPupilsRating.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchDate);
            this.groupBox1.Controls.Add(this.endData);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1366, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // endData
            // 
            this.endData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endData.Location = new System.Drawing.Point(272, 48);
            this.endData.Name = "endData";
            this.endData.Size = new System.Drawing.Size(135, 27);
            this.endData.TabIndex = 1;
            this.endData.Value = new System.DateTime(2022, 5, 19, 0, 23, 37, 0);
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(86, 48);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(145, 27);
            this.startDate.TabIndex = 0;
            this.startDate.Value = new System.DateTime(2022, 5, 19, 0, 23, 42, 0);
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridPupilsRating, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1376, 613);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // searchDate
            // 
            this.searchDate.Location = new System.Drawing.Point(137, 96);
            this.searchDate.Name = "searchDate";
            this.searchDate.Size = new System.Drawing.Size(200, 59);
            this.searchDate.TabIndex = 2;
            this.searchDate.Text = "Найти по дате";
            this.searchDate.UseVisualStyleBackColor = true;
            this.searchDate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "по";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводНаПечатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1376, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выводНаПечатьToolStripMenuItem
            // 
            this.выводНаПечатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вДокументWordToolStripMenuItem});
            this.выводНаПечатьToolStripMenuItem.Name = "выводНаПечатьToolStripMenuItem";
            this.выводНаПечатьToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.выводНаПечатьToolStripMenuItem.Text = "Вывод на печать";
            this.выводНаПечатьToolStripMenuItem.Click += new System.EventHandler(this.выводНаПечатьToolStripMenuItem_Click);
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.number.Frozen = true;
            this.number.HeaderText = "№ п/п";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 86;
            // 
            // IDPupil
            // 
            this.IDPupil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDPupil.Frozen = true;
            this.IDPupil.HeaderText = "ID";
            this.IDPupil.Name = "IDPupil";
            this.IDPupil.ReadOnly = true;
            this.IDPupil.Width = 53;
            // 
            // NamePupil
            // 
            this.NamePupil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NamePupil.HeaderText = "ФИО";
            this.NamePupil.Name = "NamePupil";
            this.NamePupil.ReadOnly = true;
            this.NamePupil.Width = 72;
            // 
            // ClassPupil
            // 
            this.ClassPupil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ClassPupil.HeaderText = "Класс";
            this.ClassPupil.Name = "ClassPupil";
            this.ClassPupil.ReadOnly = true;
            this.ClassPupil.Width = 83;
            // 
            // Balls
            // 
            this.Balls.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Balls.HeaderText = "Баллы";
            this.Balls.Name = "Balls";
            this.Balls.ReadOnly = true;
            this.Balls.Width = 87;
            // 
            // вДокументWordToolStripMenuItem
            // 
            this.вДокументWordToolStripMenuItem.Name = "вДокументWordToolStripMenuItem";
            this.вДокументWordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вДокументWordToolStripMenuItem.Text = "В документ Word";
            this.вДокументWordToolStripMenuItem.Click += new System.EventHandler(this.вДокументWordToolStripMenuItem_Click);
            // 
            // RatingPupil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1376, 637);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RatingPupil";
            this.Text = "Рейтинг учеников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RatingPupil_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridPupilsRating)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPupilsRating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker endData;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button searchDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPupil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePupil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassPupil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balls;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выводНаПечатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вДокументWordToolStripMenuItem;
    }
}