
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPage = new System.Windows.Forms.ToolStripMenuItem();
            this.тестБелбинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаПроектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherPage = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаданийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаПроектовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыТестаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБригадыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиУспеваемостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыОпросовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкипроектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкидисциплинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPage = new System.Windows.Forms.ToolStripMenuItem();
            this.списокГруппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДисциплинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserInfo = new System.Windows.Forms.Label();
            this.Alerts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPage,
            this.studentPage,
            this.teacherPage,
            this.adminPage,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
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
            this.сменитьПользователяToolStripMenuItem.AutoToolTip = true;
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.ToolTipText = "Открыть окно авторизации";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.AutoToolTip = true;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.ToolTipText = "Закрыть приложение";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // studentPage
            // 
            this.studentPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестБелбинаToolStripMenuItem,
            this.таблицаПроектовToolStripMenuItem,
            this.опросыToolStripMenuItem});
            this.studentPage.Enabled = false;
            this.studentPage.Name = "studentPage";
            this.studentPage.Size = new System.Drawing.Size(71, 20);
            this.studentPage.Text = "Студенты";
            // 
            // тестБелбинаToolStripMenuItem
            // 
            this.тестБелбинаToolStripMenuItem.AutoToolTip = true;
            this.тестБелбинаToolStripMenuItem.Name = "тестБелбинаToolStripMenuItem";
            this.тестБелбинаToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.тестБелбинаToolStripMenuItem.Text = "Тест Белбина";
            this.тестБелбинаToolStripMenuItem.ToolTipText = "Тест состоит из 7 блоков, пройдя тест вы узнаете свою командную роль";
            this.тестБелбинаToolStripMenuItem.Click += new System.EventHandler(this.тестБелбинаToolStripMenuItem_Click);
            // 
            // таблицаПроектовToolStripMenuItem
            // 
            this.таблицаПроектовToolStripMenuItem.AutoToolTip = true;
            this.таблицаПроектовToolStripMenuItem.Name = "таблицаПроектовToolStripMenuItem";
            this.таблицаПроектовToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.таблицаПроектовToolStripMenuItem.Text = "Выполнение заданий";
            this.таблицаПроектовToolStripMenuItem.ToolTipText = resources.GetString("таблицаПроектовToolStripMenuItem.ToolTipText");
            this.таблицаПроектовToolStripMenuItem.Click += new System.EventHandler(this.таблицаПроектовToolStripMenuItem_Click);
            // 
            // опросыToolStripMenuItem
            // 
            this.опросыToolStripMenuItem.AutoToolTip = true;
            this.опросыToolStripMenuItem.Name = "опросыToolStripMenuItem";
            this.опросыToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.опросыToolStripMenuItem.Text = "Опросы";
            this.опросыToolStripMenuItem.ToolTipText = "Пройти опросы";
            this.опросыToolStripMenuItem.Click += new System.EventHandler(this.опросыToolStripMenuItem_Click);
            // 
            // teacherPage
            // 
            this.teacherPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаданиеToolStripMenuItem,
            this.списокЗаданийToolStripMenuItem,
            this.таблицаПроектовToolStripMenuItem1,
            this.результатыТестаToolStripMenuItem,
            this.создатьБригадыToolStripMenuItem,
            this.графикиУспеваемостиToolStripMenuItem,
            this.результатыОпросовToolStripMenuItem,
            this.оценкипроектыToolStripMenuItem,
            this.оценкидисциплинаToolStripMenuItem});
            this.teacherPage.Enabled = false;
            this.teacherPage.Name = "teacherPage";
            this.teacherPage.Size = new System.Drawing.Size(104, 20);
            this.teacherPage.Text = "Преподаватели";
            // 
            // добавитьЗаданиеToolStripMenuItem
            // 
            this.добавитьЗаданиеToolStripMenuItem.AutoToolTip = true;
            this.добавитьЗаданиеToolStripMenuItem.Name = "добавитьЗаданиеToolStripMenuItem";
            this.добавитьЗаданиеToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.добавитьЗаданиеToolStripMenuItem.Text = "Добавить задание";
            this.добавитьЗаданиеToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаданиеToolStripMenuItem_Click);
            // 
            // списокЗаданийToolStripMenuItem
            // 
            this.списокЗаданийToolStripMenuItem.Name = "списокЗаданийToolStripMenuItem";
            this.списокЗаданийToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.списокЗаданийToolStripMenuItem.Text = "Список заданий";
            this.списокЗаданийToolStripMenuItem.Click += new System.EventHandler(this.списокЗаданийToolStripMenuItem_Click);
            // 
            // таблицаПроектовToolStripMenuItem1
            // 
            this.таблицаПроектовToolStripMenuItem1.AutoToolTip = true;
            this.таблицаПроектовToolStripMenuItem1.Name = "таблицаПроектовToolStripMenuItem1";
            this.таблицаПроектовToolStripMenuItem1.Size = new System.Drawing.Size(217, 22);
            this.таблицаПроектовToolStripMenuItem1.Text = "Выполнение заданий";
            this.таблицаПроектовToolStripMenuItem1.Click += new System.EventHandler(this.таблицаПроектовToolStripMenuItem1_Click);
            // 
            // результатыТестаToolStripMenuItem
            // 
            this.результатыТестаToolStripMenuItem.AutoToolTip = true;
            this.результатыТестаToolStripMenuItem.Name = "результатыТестаToolStripMenuItem";
            this.результатыТестаToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.результатыТестаToolStripMenuItem.Text = "Результаты теста Белбина";
            this.результатыТестаToolStripMenuItem.ToolTipText = "Открыть результаты  теста Белбина";
            this.результатыТестаToolStripMenuItem.Click += new System.EventHandler(this.результатыТестаToolStripMenuItem_Click_1);
            // 
            // создатьБригадыToolStripMenuItem
            // 
            this.создатьБригадыToolStripMenuItem.AutoToolTip = true;
            this.создатьБригадыToolStripMenuItem.Name = "создатьБригадыToolStripMenuItem";
            this.создатьБригадыToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.создатьБригадыToolStripMenuItem.Text = "Создать команды";
            this.создатьБригадыToolStripMenuItem.Click += new System.EventHandler(this.создатьБригадыToolStripMenuItem_Click_1);
            // 
            // графикиУспеваемостиToolStripMenuItem
            // 
            this.графикиУспеваемостиToolStripMenuItem.AutoToolTip = true;
            this.графикиУспеваемостиToolStripMenuItem.Name = "графикиУспеваемостиToolStripMenuItem";
            this.графикиУспеваемостиToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.графикиУспеваемостиToolStripMenuItem.Text = "Качество выполнения";
            this.графикиУспеваемостиToolStripMenuItem.Click += new System.EventHandler(this.графикиУспеваемостиToolStripMenuItem_Click);
            // 
            // результатыОпросовToolStripMenuItem
            // 
            this.результатыОпросовToolStripMenuItem.AutoToolTip = true;
            this.результатыОпросовToolStripMenuItem.Name = "результатыОпросовToolStripMenuItem";
            this.результатыОпросовToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.результатыОпросовToolStripMenuItem.Text = "Результаты опросов";
            this.результатыОпросовToolStripMenuItem.Click += new System.EventHandler(this.результатыОпросовToolStripMenuItem_Click);
            // 
            // оценкипроектыToolStripMenuItem
            // 
            this.оценкипроектыToolStripMenuItem.AutoToolTip = true;
            this.оценкипроектыToolStripMenuItem.Name = "оценкипроектыToolStripMenuItem";
            this.оценкипроектыToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.оценкипроектыToolStripMenuItem.Text = "Оценки (проект)";
            this.оценкипроектыToolStripMenuItem.Click += new System.EventHandler(this.оценкипроектыToolStripMenuItem_Click);
            // 
            // оценкидисциплинаToolStripMenuItem
            // 
            this.оценкидисциплинаToolStripMenuItem.AutoToolTip = true;
            this.оценкидисциплинаToolStripMenuItem.Name = "оценкидисциплинаToolStripMenuItem";
            this.оценкидисциплинаToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.оценкидисциплинаToolStripMenuItem.Text = "Оценки (дисциплина)";
            this.оценкидисциплинаToolStripMenuItem.Click += new System.EventHandler(this.оценкидисциплинаToolStripMenuItem_Click);
            // 
            // adminPage
            // 
            this.adminPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокГруппToolStripMenuItem,
            this.списокСтудентовToolStripMenuItem,
            this.списокДисциплинToolStripMenuItem});
            this.adminPage.Enabled = false;
            this.adminPage.Name = "adminPage";
            this.adminPage.Size = new System.Drawing.Size(134, 20);
            this.adminPage.Text = "Администрирование";
            // 
            // списокГруппToolStripMenuItem
            // 
            this.списокГруппToolStripMenuItem.AutoToolTip = true;
            this.списокГруппToolStripMenuItem.Name = "списокГруппToolStripMenuItem";
            this.списокГруппToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.списокГруппToolStripMenuItem.Text = "Список групп";
            this.списокГруппToolStripMenuItem.Click += new System.EventHandler(this.списокГруппToolStripMenuItem_Click);
            // 
            // списокСтудентовToolStripMenuItem
            // 
            this.списокСтудентовToolStripMenuItem.AutoToolTip = true;
            this.списокСтудентовToolStripMenuItem.Name = "списокСтудентовToolStripMenuItem";
            this.списокСтудентовToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.списокСтудентовToolStripMenuItem.Text = "Список студентов";
            this.списокСтудентовToolStripMenuItem.Click += new System.EventHandler(this.списокСтудентовToolStripMenuItem_Click);
            // 
            // списокДисциплинToolStripMenuItem
            // 
            this.списокДисциплинToolStripMenuItem.AutoToolTip = true;
            this.списокДисциплинToolStripMenuItem.Name = "списокДисциплинToolStripMenuItem";
            this.списокДисциплинToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.списокДисциплинToolStripMenuItem.Text = "Список дисциплин";
            this.списокДисциплинToolStripMenuItem.Click += new System.EventHandler(this.списокДисциплинToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.AutoToolTip = true;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.ToolTipText = "Руководство пользователя";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // UserInfo
            // 
            this.UserInfo.AutoSize = true;
            this.UserInfo.Location = new System.Drawing.Point(12, 24);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(0, 13);
            this.UserInfo.TabIndex = 1;
            // 
            // Alerts
            // 
            this.Alerts.FormattingEnabled = true;
            this.Alerts.IntegralHeight = false;
            this.Alerts.Location = new System.Drawing.Point(15, 66);
            this.Alerts.Name = "Alerts";
            this.Alerts.Size = new System.Drawing.Size(629, 264);
            this.Alerts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оповещения";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alerts);
            this.Controls.Add(this.UserInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem teacherPage;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаПроектовToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem результатыТестаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьБригадыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикиУспеваемостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыОпросовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPage;
        private System.Windows.Forms.ToolStripMenuItem списокГруппToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСтудентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокДисциплинToolStripMenuItem;
        private System.Windows.Forms.Label UserInfo;
        private System.Windows.Forms.ListBox Alerts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem оценкипроектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкидисциплинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗаданийToolStripMenuItem;
    }
}

