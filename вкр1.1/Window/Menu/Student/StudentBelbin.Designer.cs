
namespace WinFormInfSys
{
    partial class StudentBelbin
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
            this.Title = new System.Windows.Forms.Label();
            this.Container = new System.Windows.Forms.Panel();
            this.Steps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(0, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(784, 31);
            this.Title.TabIndex = 0;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Container
            // 
            this.Container.Location = new System.Drawing.Point(0, 110);
            this.Container.Margin = new System.Windows.Forms.Padding(0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(784, 448);
            this.Container.TabIndex = 2;
            // 
            // Steps
            // 
            this.Steps.Location = new System.Drawing.Point(0, 40);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(784, 24);
            this.Steps.TabIndex = 3;
            this.Steps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Распределите 10 баллов между вопросами по вашему усмотрению";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentBelbin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Steps);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Title);
            this.Name = "StudentBelbin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест Белбина";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Label Steps;
        private System.Windows.Forms.Label label1;
    }
}