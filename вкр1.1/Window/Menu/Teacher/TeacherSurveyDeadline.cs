using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Teacher;

namespace WinFormInfSys.Window
{
    public partial class TeacherSurveyDeadline : Form
    {
        public TeacherSurveyDeadline()
        {

            InitializeComponent();

            Utils.bind(Discipline, "is_discipline", "name");
            Utils.bind(Group, "is_group", "name");

            Survey.Items.Add("Мои ожидания от командной работы");
            Survey.Items.Add("Анкета для оценки качества взаимодействия членов команды в процессе разработки программного продукта");
            Survey.Items.Add("Анкета для оценки качества взаимодействия членов команды в завершении разработки программного продукта");
            Survey.Items.Add("Я в команде: сильные и слабые стороны");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(Discipline.SelectedIndex == -1 || Group.SelectedIndex == -1 || Survey.SelectedIndex == -1) { MessageBox.Show("Проверьте правильность ввода"); return; }

            bool ignore = checkBox1.Checked;

            DateTime date = dateTimePicker1.Value;
            string preparedDate = $"CAST('{date:yyyyMMdd}' as date)";

            string group = Group.SelectedItem.ToString();
            string discipline = Discipline.SelectedItem.ToString();
            string survey = Survey.SelectedItem.ToString();

            ObjSurveyDeadline obj = new ObjSurveyDeadline() {

                group = group,
                discipline = discipline,
                name = survey,
                deadline = ignore ? "null" : preparedDate
            
            };

            if (ObjSurveyDeadline.isExists(obj)) { ObjSurveyDeadline.update(obj); }
            else { ObjSurveyDeadline.insert(obj); }

            MessageBox.Show("Сохранено");

        }

    }

}
