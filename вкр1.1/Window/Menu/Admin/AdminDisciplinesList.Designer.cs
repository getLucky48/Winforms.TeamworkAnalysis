
namespace WinFormInfSys.Window
{
    partial class AdminDisciplinesList
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
            this.Editor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_disc = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.Editor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.label1);
            this.Editor.Controls.Add(this.Name_disc);
            this.Editor.Controls.Add(this.Create);
            this.Editor.Location = new System.Drawing.Point(2, 410);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(568, 91);
            this.Editor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование";
            // 
            // Name_disc
            // 
            this.Name_disc.Location = new System.Drawing.Point(126, 43);
            this.Name_disc.Name = "Name_disc";
            this.Name_disc.Size = new System.Drawing.Size(175, 20);
            this.Name_disc.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(334, 42);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(96, 21);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Table
            // 
            this.Table.AutoScroll = true;
            this.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Table.ColumnCount = 3;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table.Size = new System.Drawing.Size(570, 404);
            this.Table.TabIndex = 4;
            // 
            // AdminDisciplinesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 497);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Editor);
            this.Name = "AdminDisciplinesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список дисциплин";
            this.Editor.ResumeLayout(false);
            this.Editor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Editor;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_disc;
        private System.Windows.Forms.TableLayoutPanel Table;
    }
}