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
            this.gridPupilsRating = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDPupil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePupil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassPupil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPupilsRating)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPupilsRating
            // 
            this.gridPupilsRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPupilsRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPupil,
            this.NamePupil,
            this.ClassPupil,
            this.Balls});
            this.gridPupilsRating.Location = new System.Drawing.Point(12, 118);
            this.gridPupilsRating.Name = "gridPupilsRating";
            this.gridPupilsRating.Size = new System.Drawing.Size(962, 421);
            this.gridPupilsRating.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // IDPupil
            // 
            this.IDPupil.HeaderText = "ID";
            this.IDPupil.Name = "IDPupil";
            // 
            // NamePupil
            // 
            this.NamePupil.HeaderText = "ФИО";
            this.NamePupil.Name = "NamePupil";
            // 
            // ClassPupil
            // 
            this.ClassPupil.HeaderText = "Класс";
            this.ClassPupil.Name = "ClassPupil";
            // 
            // Balls
            // 
            this.Balls.HeaderText = "Баллы";
            this.Balls.Name = "Balls";
            // 
            // RatingPupil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridPupilsRating);
            this.Name = "RatingPupil";
            this.Text = "Рейтинг учеников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RatingPupil_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridPupilsRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPupilsRating;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPupil;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePupil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassPupil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balls;
    }
}