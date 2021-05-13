﻿using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Window;
using static WinFormInfSys.Auth;

namespace WinFormInfSys
{
    public partial class Menu : Form
    {

        public Menu()
        {

            InitializeComponent();

        }

        public Menu(Tuple<Role, int> role)
        {

            InitializeComponent();

            if (role.Item1 == Role.Teacher)
            {

                teacherPage.Enabled = true;
                adminPage.Enabled = true;

            }
            else if(role.Item1 == Role.Student)
            {

                studentPage.Enabled = true;

            }

            this.role = role;

        }

        private Tuple<Role, int> role;

        private void сменитьПользователяToolStripMenuItem_Click_1(object sender, EventArgs e)       { this.Close(); }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)                       { Application.Exit(); }
        private void тестБелбинаToolStripMenuItem_Click(object sender, EventArgs e)                 { Utils.switchWindow(this, new StudentBelbin(role)); }
        private void таблицаПроектовToolStripMenuItem_Click(object sender, EventArgs e)             { Utils.switchWindow(this, new StudentProjects(role)); }
        private void опросыToolStripMenuItem_Click(object sender, EventArgs e)                      { /*todo*/ }
        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)     { /*todo*/ }
        private void добавитьЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)             { Utils.switchWindow(this, new TeacherTaskAdd(role)); }
        private void таблицаПроектовToolStripMenuItem1_Click(object sender, EventArgs e)            { Utils.switchWindow(this, new TeacherProjects(role)); }
        private void результатыТестаToolStripMenuItem_Click_1(object sender, EventArgs e)           { Utils.switchWindow(this, new TeacherBelbinResults()); }
        private void создатьБригадыToolStripMenuItem_Click_1(object sender, EventArgs e)            { Utils.switchWindow(this, new TeacherTeamAdd(role)); }
        private void графикиУспеваемостиToolStripMenuItem_Click(object sender, EventArgs e)         { /*todo*/ }
        private void результатыОпросовToolStripMenuItem_Click(object sender, EventArgs e)           { /*todo*/ }
        private void руководствоПользователяToolStripMenuItem1_Click(object sender, EventArgs e)    { /*todo*/ }
        private void списокПреподавателейToolStripMenuItem_Click(object sender, EventArgs e)        { Utils.switchWindow(this, new AdminTeachersList()); }
        private void списокГруппToolStripMenuItem_Click(object sender, EventArgs e)                 { Utils.switchWindow(this, new AdminGroupsList()); }
        private void списокСтудентовToolStripMenuItem_Click(object sender, EventArgs e)             { Utils.switchWindow(this, new AdminStudentsList()); }
        private void списокДисциплинToolStripMenuItem_Click(object sender, EventArgs e)             { Utils.switchWindow(this, new AdminDisciplinesList()); }

    }

}
