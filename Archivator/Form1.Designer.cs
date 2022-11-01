namespace Archivator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseCatalog = new System.Windows.Forms.Button();
            this.SaveArchive = new System.Windows.Forms.Button();
            this.CatalogInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseCatalog
            // 
            this.ChooseCatalog.Location = new System.Drawing.Point(83, 80);
            this.ChooseCatalog.Name = "ChooseCatalog";
            this.ChooseCatalog.Size = new System.Drawing.Size(181, 29);
            this.ChooseCatalog.TabIndex = 0;
            this.ChooseCatalog.Text = "Выберите каталог";
            this.ChooseCatalog.UseVisualStyleBackColor = true;
            this.ChooseCatalog.Click += new System.EventHandler(this.ChooseCatalog_Click);
            // 
            // SaveArchive
            // 
            this.SaveArchive.Location = new System.Drawing.Point(23, 176);
            this.SaveArchive.Name = "SaveArchive";
            this.SaveArchive.Size = new System.Drawing.Size(297, 29);
            this.SaveArchive.TabIndex = 1;
            this.SaveArchive.Text = "Сохранить архив";
            this.SaveArchive.UseVisualStyleBackColor = true;
            this.SaveArchive.Click += new System.EventHandler(this.SaveArchive_Click);
            // 
            // CatalogInfo
            // 
            this.CatalogInfo.Location = new System.Drawing.Point(23, 22);
            this.CatalogInfo.Name = "CatalogInfo";
            this.CatalogInfo.Size = new System.Drawing.Size(297, 27);
            this.CatalogInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 253);
            this.Controls.Add(this.CatalogInfo);
            this.Controls.Add(this.SaveArchive);
            this.Controls.Add(this.ChooseCatalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Архиватор папки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ChooseCatalog;
        private Button SaveArchive;
        private TextBox CatalogInfo;
    }
}