
namespace WinFormInfSys
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPage = new System.Windows.Forms.ToolStripMenuItem();
            this.тестБелбинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаПроектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherPage = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаПроектовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыТестаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБригадыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиУспеваемостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыОпросовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоПользователяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPage = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПреподавателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокГруппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДисциплинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPage,
            this.studentPage,
            this.teacherPage,
            this.adminPage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainPage
            // 
            this.mainPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(63, 20);
            this.mainPage.Text = "Главная";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // studentPage
            // 
            this.studentPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестБелбинаToolStripMenuItem,
            this.таблицаПроектовToolStripMenuItem,
            this.опросыToolStripMenuItem,
            this.руководствоПользователяToolStripMenuItem});
            this.studentPage.Enabled = false;
            this.studentPage.Name = "studentPage";
            this.studentPage.Size = new System.Drawing.Size(71, 20);
            this.studentPage.Text = "Студенты";
            // 
            // тестБелбинаToolStripMenuItem
            // 
            this.тестБелбинаToolStripMenuItem.Name = "тестБелбинаToolStripMenuItem";
            this.тестБелбинаToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.тестБелбинаToolStripMenuItem.Text = "Тест Белбина";
            this.тестБелбинаToolStripMenuItem.Click += new System.EventHandler(this.тестБелбинаToolStripMenuItem_Click);
            // 
            // таблицаПроектовToolStripMenuItem
            // 
            this.таблицаПроектовToolStripMenuItem.Name = "таблицаПроектовToolStripMenuItem";
            this.таблицаПроектовToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.таблицаПроектовToolStripMenuItem.Text = "Таблица проектов";
            this.таблицаПроектовToolStripMenuItem.Click += new System.EventHandler(this.таблицаПроектовToolStripMenuItem_Click);
            // 
            // опросыToolStripMenuItem
            // 
            this.опросыToolStripMenuItem.Name = "опросыToolStripMenuItem";
            this.опросыToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.опросыToolStripMenuItem.Text = "Опросы";
            this.опросыToolStripMenuItem.Click += new System.EventHandler(this.опросыToolStripMenuItem_Click);
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            this.руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            this.руководствоПользователяToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            this.руководствоПользователяToolStripMenuItem.Click += new System.EventHandler(this.руководствоПользователяToolStripMenuItem_Click);
            // 
            // teacherPage
            // 
            this.teacherPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаданиеToolStripMenuItem,
            this.таблицаПроектовToolStripMenuItem1,
            this.результатыТестаToolStripMenuItem,
            this.создатьБригадыToolStripMenuItem,
            this.графикиУспеваемостиToolStripMenuItem,
            this.результатыОпросовToolStripMenuItem,
            this.руководствоПользователяToolStripMenuItem1});
            this.teacherPage.Enabled = false;
            this.teacherPage.Name = "teacherPage";
            this.teacherPage.Size = new System.Drawing.Size(104, 20);
            this.teacherPage.Text = "Преподаватели";
            // 
            // добавитьЗаданиеToolStripMenuItem
            // 
            this.добавитьЗаданиеToolStripMenuItem.Name = "добавитьЗаданиеToolStripMenuItem";
            this.добавитьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.добавитьЗаданиеToolStripMenuItem.Text = "Добавить задание";
            this.добавитьЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаданиеToolStripMenuItem_Click);
            // 
            // таблицаПроектовToolStripMenuItem1
            // 
            this.таблицаПроектовToolStripMenuItem1.Name = "таблицаПроектовToolStripMenuItem1";
            this.таблицаПроектовToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.таблицаПроектовToolStripMenuItem1.Text = "Таблица проектов";
            this.таблицаПроектовToolStripMenuItem1.Click += new System.EventHandler(this.таблицаПроектовToolStripMenuItem1_Click);
            // 
            // результатыТестаToolStripMenuItem
            // 
            this.результатыТестаToolStripMenuItem.Name = "результатыТестаToolStripMenuItem";
            this.результатыТестаToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.результатыТестаToolStripMenuItem.Text = "Результаты теста Белбина";
            this.результатыТестаToolStripMenuItem.Click += new System.EventHandler(this.результатыТестаToolStripMenuItem_Click_1);
            // 
            // создатьБригадыToolStripMenuItem
            // 
            this.создатьБригадыToolStripMenuItem.Name = "создатьБригадыToolStripMenuItem";
            this.создатьБригадыToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.создатьБригадыToolStripMenuItem.Text = "Создать бригады";
            this.создатьБригадыToolStripMenuItem.Click += new System.EventHandler(this.создатьБригадыToolStripMenuItem_Click_1);
            // 
            // графикиУспеваемостиToolStripMenuItem
            // 
            this.графикиУспеваемостиToolStripMenuItem.Name = "графикиУспеваемостиToolStripMenuItem";
            this.графикиУспеваемостиToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.графикиУспеваемостиToolStripMenuItem.Text = "Графики успеваемости";
            this.графикиУспеваемостиToolStripMenuItem.Click += new System.EventHandler(this.графикиУспеваемостиToolStripMenuItem_Click);
            // 
            // результатыОпросовToolStripMenuItem
            // 
            this.результатыОпросовToolStripMenuItem.Name = "результатыОпросовToolStripMenuItem";
            this.результатыОпросовToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.результатыОпросовToolStripMenuItem.Text = "Результаты опросов";
            this.результатыОпросовToolStripMenuItem.Click += new System.EventHandler(this.результатыОпросовToolStripMenuItem_Click);
            // 
            // руководствоПользователяToolStripMenuItem1
            // 
            this.руководствоПользователяToolStripMenuItem1.Name = "руководствоПользователяToolStripMenuItem1";
            this.руководствоПользователяToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.руководствоПользователяToolStripMenuItem1.Text = "Руководство пользователя";
            this.руководствоПользователяToolStripMenuItem1.Click += new System.EventHandler(this.руководствоПользователяToolStripMenuItem1_Click);
            // 
            // adminPage
            // 
            this.adminPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПреподавателейToolStripMenuItem,
            this.списокГруппToolStripMenuItem,
            this.списокСтудентовToolStripMenuItem,
            this.списокДисциплинToolStripMenuItem});
            this.adminPage.Enabled = false;
            this.adminPage.Name = "adminPage";
            this.adminPage.Size = new System.Drawing.Size(134, 20);
            this.adminPage.Text = "Администрирование";
            // 
            // списокПреподавателейToolStripMenuItem
            // 
            this.списокПреподавателейToolStripMenuItem.Name = "списокПреподавателейToolStripMenuItem";
            this.списокПреподавателейToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.списокПреподавателейToolStripMenuItem.Text = "Список преподавателей";
            this.списокПреподавателейToolStripMenuItem.Click += new System.EventHandler(this.списокПреподавателейToolStripMenuItem_Click);
            // 
            // списокГруппToolStripMenuItem
            // 
            this.списокГруппToolStripMenuItem.Name = "списокГруппToolStripMenuItem";
            this.списокГруппToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.списокГруппToolStripMenuItem.Text = "Список групп";
            this.списокГруппToolStripMenuItem.Click += new System.EventHandler(this.списокГруппToolStripMenuItem_Click);
            // 
            // списокСтудентовToolStripMenuItem
            // 
            this.списокСтудентовToolStripMenuItem.Name = "списокСтудентовToolStripMenuItem";
            this.списокСтудентовToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.списокСтудентовToolStripMenuItem.Text = "Список студентов";
            this.списокСтудентовToolStripMenuItem.Click += new System.EventHandler(this.списокСтудентовToolStripMenuItem_Click);
            // 
            // списокДисциплинToolStripMenuItem
            // 
            this.списокДисциплинToolStripMenuItem.Name = "списокДисциплинToolStripMenuItem";
            this.списокДисциплинToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.списокДисциплинToolStripMenuItem.Text = "Список дисциплин";
            this.списокДисциплинToolStripMenuItem.Click += new System.EventHandler(this.списокДисциплинToolStripMenuItem_Click);
            // 
            // UserInfo
            // 
            this.UserInfo.AutoSize = true;
            this.UserInfo.Location = new System.Drawing.Point(12, 24);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(0, 13);
            this.UserInfo.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 348);
            this.Controls.Add(this.UserInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Информационная система";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainPage;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentPage;
        private System.Windows.Forms.ToolStripMenuItem тестБелбинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаПроектовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherPage;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаПроектовToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem результатыТестаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьБригадыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикиУспеваемостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыОпросовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоПользователяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminPage;
        private System.Windows.Forms.ToolStripMenuItem списокПреподавателейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокГруппToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСтудентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокДисциплинToolStripMenuItem;
        private System.Windows.Forms.Label UserInfo;
    }
}

