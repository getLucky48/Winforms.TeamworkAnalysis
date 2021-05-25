
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
            this.тестированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.срокиПрохожденияТестированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыТестаБелбинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьКомандыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPage = new System.Windows.Forms.ToolStripMenuItem();
            this.списокГруппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокДисциплинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserInfo = new System.Windows.Forms.Label();
            this.Alerts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.добавитьзаданиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаданийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнениеЗаданийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкизаданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкидисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.качествоВыполненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анкетированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыАнкетированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.определениеСроковАнкетированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.опросыToolStripMenuItem.Text = "Анкетирование";
            this.опросыToolStripMenuItem.ToolTipText = "Пройти опросы";
            this.опросыToolStripMenuItem.Click += new System.EventHandler(this.опросыToolStripMenuItem_Click);
            // 
            // teacherPage
            // 
            this.teacherPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестированиеToolStripMenuItem,
            this.заданияToolStripMenuItem,
            this.анкетированиеToolStripMenuItem});
            this.teacherPage.Enabled = false;
            this.teacherPage.Name = "teacherPage";
            this.teacherPage.Size = new System.Drawing.Size(104, 20);
            this.teacherPage.Text = "Преподаватели";
            // 
            // тестированиеToolStripMenuItem
            // 
            this.тестированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.срокиПрохожденияТестированияToolStripMenuItem,
            this.результатыТестаБелбинаToolStripMenuItem,
            this.создатьКомандыToolStripMenuItem});
            this.тестированиеToolStripMenuItem.Name = "тестированиеToolStripMenuItem";
            this.тестированиеToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.тестированиеToolStripMenuItem.Text = "Тестирование";
            // 
            // срокиПрохожденияТестированияToolStripMenuItem
            // 
            this.срокиПрохожденияТестированияToolStripMenuItem.Name = "срокиПрохожденияТестированияToolStripMenuItem";
            this.срокиПрохожденияТестированияToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.срокиПрохожденияТестированияToolStripMenuItem.Text = "Сроки прохождения тестирования";
            this.срокиПрохожденияТестированияToolStripMenuItem.Click += new System.EventHandler(this.срокиПрохожденияТестированияToolStripMenuItem_Click);
            // 
            // результатыТестаБелбинаToolStripMenuItem
            // 
            this.результатыТестаБелбинаToolStripMenuItem.Name = "результатыТестаБелбинаToolStripMenuItem";
            this.результатыТестаБелбинаToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.результатыТестаБелбинаToolStripMenuItem.Text = "Результаты теста Белбина";
            this.результатыТестаБелбинаToolStripMenuItem.Click += new System.EventHandler(this.результатыТестаБелбинаToolStripMenuItem_Click);
            // 
            // создатьКомандыToolStripMenuItem
            // 
            this.создатьКомандыToolStripMenuItem.Name = "создатьКомандыToolStripMenuItem";
            this.создатьКомандыToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.создатьКомандыToolStripMenuItem.Text = "Создать команды";
            this.создатьКомандыToolStripMenuItem.Click += new System.EventHandler(this.создатьКомандыToolStripMenuItem_Click);
            // 
            // заданияToolStripMenuItem
            // 
            this.заданияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьзаданиеToolStripMenuItem1,
            this.списокЗаданийToolStripMenuItem1,
            this.выполнениеЗаданийToolStripMenuItem,
            this.оценкизаданияToolStripMenuItem,
            this.оценкидисциплиныToolStripMenuItem,
            this.качествоВыполненияToolStripMenuItem});
            this.заданияToolStripMenuItem.Name = "заданияToolStripMenuItem";
            this.заданияToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.заданияToolStripMenuItem.Text = "Задания";
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
            this.списокГруппToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.списокГруппToolStripMenuItem.Text = "Список групп";
            this.списокГруппToolStripMenuItem.Click += new System.EventHandler(this.списокГруппToolStripMenuItem_Click);
            // 
            // списокСтудентовToolStripMenuItem
            // 
            this.списокСтудентовToolStripMenuItem.AutoToolTip = true;
            this.списокСтудентовToolStripMenuItem.Name = "списокСтудентовToolStripMenuItem";
            this.списокСтудентовToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.списокСтудентовToolStripMenuItem.Text = "Список студентов";
            this.списокСтудентовToolStripMenuItem.Click += new System.EventHandler(this.списокСтудентовToolStripMenuItem_Click);
            // 
            // списокДисциплинToolStripMenuItem
            // 
            this.списокДисциплинToolStripMenuItem.AutoToolTip = true;
            this.списокДисциплинToolStripMenuItem.Name = "списокДисциплинToolStripMenuItem";
            this.списокДисциплинToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
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
            // добавитьзаданиеToolStripMenuItem1
            // 
            this.добавитьзаданиеToolStripMenuItem1.Name = "добавитьзаданиеToolStripMenuItem1";
            this.добавитьзаданиеToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.добавитьзаданиеToolStripMenuItem1.Text = "Добавитьзадание";
            this.добавитьзаданиеToolStripMenuItem1.Click += new System.EventHandler(this.добавитьзаданиеToolStripMenuItem1_Click);
            // 
            // списокЗаданийToolStripMenuItem1
            // 
            this.списокЗаданийToolStripMenuItem1.Name = "списокЗаданийToolStripMenuItem1";
            this.списокЗаданийToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.списокЗаданийToolStripMenuItem1.Text = "Список заданий";
            this.списокЗаданийToolStripMenuItem1.Click += new System.EventHandler(this.списокЗаданийToolStripMenuItem1_Click);
            // 
            // выполнениеЗаданийToolStripMenuItem
            // 
            this.выполнениеЗаданийToolStripMenuItem.Name = "выполнениеЗаданийToolStripMenuItem";
            this.выполнениеЗаданийToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.выполнениеЗаданийToolStripMenuItem.Text = "Выполнение заданий";
            this.выполнениеЗаданийToolStripMenuItem.Click += new System.EventHandler(this.выполнениеЗаданийToolStripMenuItem_Click);
            // 
            // оценкизаданияToolStripMenuItem
            // 
            this.оценкизаданияToolStripMenuItem.Name = "оценкизаданияToolStripMenuItem";
            this.оценкизаданияToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.оценкизаданияToolStripMenuItem.Text = "Оценки (задания)";
            this.оценкизаданияToolStripMenuItem.Click += new System.EventHandler(this.оценкизаданияToolStripMenuItem_Click);
            // 
            // оценкидисциплиныToolStripMenuItem
            // 
            this.оценкидисциплиныToolStripMenuItem.Name = "оценкидисциплиныToolStripMenuItem";
            this.оценкидисциплиныToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.оценкидисциплиныToolStripMenuItem.Text = "Оценки (дисциплины)";
            this.оценкидисциплиныToolStripMenuItem.Click += new System.EventHandler(this.оценкидисциплиныToolStripMenuItem_Click);
            // 
            // качествоВыполненияToolStripMenuItem
            // 
            this.качествоВыполненияToolStripMenuItem.Name = "качествоВыполненияToolStripMenuItem";
            this.качествоВыполненияToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.качествоВыполненияToolStripMenuItem.Text = "Качество выполнения";
            this.качествоВыполненияToolStripMenuItem.Click += new System.EventHandler(this.качествоВыполненияToolStripMenuItem_Click);
            // 
            // анкетированиеToolStripMenuItem
            // 
            this.анкетированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.определениеСроковАнкетированияToolStripMenuItem,
            this.результатыАнкетированияToolStripMenuItem});
            this.анкетированиеToolStripMenuItem.Name = "анкетированиеToolStripMenuItem";
            this.анкетированиеToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.анкетированиеToolStripMenuItem.Text = "Анкетирование";
            // 
            // результатыАнкетированияToolStripMenuItem
            // 
            this.результатыАнкетированияToolStripMenuItem.Name = "результатыАнкетированияToolStripMenuItem";
            this.результатыАнкетированияToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.результатыАнкетированияToolStripMenuItem.Text = "Результаты анкетирования";
            this.результатыАнкетированияToolStripMenuItem.Click += new System.EventHandler(this.результатыАнкетированияToolStripMenuItem_Click);
            // 
            // определениеСроковАнкетированияToolStripMenuItem
            // 
            this.определениеСроковАнкетированияToolStripMenuItem.Name = "определениеСроковАнкетированияToolStripMenuItem";
            this.определениеСроковАнкетированияToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.определениеСроковАнкетированияToolStripMenuItem.Text = "Определение сроков анкетирования";
            this.определениеСроковАнкетированияToolStripMenuItem.Click += new System.EventHandler(this.определениеСроковАнкетированияToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem adminPage;
        private System.Windows.Forms.ToolStripMenuItem списокГруппToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСтудентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокДисциплинToolStripMenuItem;
        private System.Windows.Forms.Label UserInfo;
        private System.Windows.Forms.ListBox Alerts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem срокиПрохожденияТестированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыТестаБелбинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьКомандыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьзаданиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem списокЗаданийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выполнениеЗаданийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкизаданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкидисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem качествоВыполненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анкетированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem определениеСроковАнкетированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыАнкетированияToolStripMenuItem;
    }
}

