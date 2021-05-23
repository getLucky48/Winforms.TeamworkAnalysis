using System;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{

    public partial class TeacherSurveyResults : Form
    {

        public TeacherSurveyResults() { InitializeComponent(); }

        private void first_Click(object sender, EventArgs e)    { Utils.switchWindow(this, new Menu.Teacher.TeacherSurveyLayouts.Layout1()); }

        private void second_Click(object sender, EventArgs e)   { Utils.switchWindow(this, new Menu.Teacher.TeacherSurveyLayouts.Layout2(true)); }

        private void third_Click(object sender, EventArgs e)    { Utils.switchWindow(this, new Menu.Teacher.TeacherSurveyLayouts.Layout2(false)); }

        private void fourth_Click(object sender, EventArgs e)   { Utils.switchWindow(this, new Menu.Teacher.TeacherSurveyLayouts.Layout3()); }

    }

}
