
namespace WinFormInfSys.Window
{
    partial class _edit_AdminDisciplinesList
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
            this.Disc_name = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Наименование";
            // 
            // Disc_name
            // 
            this.Disc_name.Location = new System.Drawing.Point(16, 47);
            this.Disc_name.Name = "Disc_name";
            this.Disc_name.Size = new System.Drawing.Size(175, 20);
            this.Disc_name.TabIndex = 8;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(58, 93);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(96, 21);
            this.Create.TabIndex = 7;
            this.Create.Text = "Сохранить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // _edit_AdminDisciplinesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 126);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Disc_name);
            this.Controls.Add(this.Create);
            this.Name = "_edit_AdminDisciplinesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Disc_name;
        private System.Windows.Forms.Button Create;
    }
}