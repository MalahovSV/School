namespace AIS_School
{
    partial class LoaderForm
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
            this.textLoad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLoad
            // 
            this.textLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLoad.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLoad.Location = new System.Drawing.Point(0, 0);
            this.textLoad.Name = "textLoad";
            this.textLoad.Size = new System.Drawing.Size(800, 450);
            this.textLoad.TabIndex = 0;
            this.textLoad.Text = "Загрузка";
            this.textLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textLoad);
            this.Name = "LoaderForm";
            this.Text = "LoaderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textLoad;
    }
}