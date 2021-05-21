using System;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{

    public partial class TeacherSurveyResults : Form
    {

        //renderSection(Table1, group, discipline, "Мои ожидания от командной работы");
        //renderSection(Table2, group, discipline, "Анкета для оценки качества взаимодействия членов команды в процессе разработки программного продукта");
        //renderSection(Table3, group, discipline, "Анкета для оценки качества взаимодействия членов команды в завершении разработки программного продукта");
        //renderSection(Table4, group, discipline, "Я в команде: сильные и слабые стороны");

        public TeacherSurveyResults() { InitializeComponent(); }

        private void first_Click(object sender, EventArgs e) { Utils.switchWindow(this, new Menu.Teacher.TeacherSurveyLayouts.Layout1()); }

        private void second_Click(object sender, EventArgs e)
        {

        }

        private void third_Click(object sender, EventArgs e)
        {

        }

        private void fourth_Click(object sender, EventArgs e) { Utils.switchWindow(this, new Menu.Teacher.TeacherSurveyLayouts.Layout3()); }

    }

}
