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

            bool ignore1 = checkBox1.Checked;
            bool ignore2 = checkBox2.Checked;

            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            string preparedDate1 = $"CAST('{date1:yyyyMMdd}' as date)";
            string preparedDate2 = $"CAST('{date2:yyyyMMdd}' as date)";

            string group = Group.SelectedItem.ToString();
            string discipline = Discipline.SelectedItem.ToString();
            string survey = Survey.SelectedItem.ToString();

            ObjSurveyDeadline obj = new ObjSurveyDeadline() {

                group = group,
                discipline = discipline,
                name = survey,
                dt_begin = ignore1 ? "null" : preparedDate1,
                dt_end = ignore2 ? "null" : preparedDate2

            };

            if (ObjSurveyDeadline.isExists(obj)) { ObjSurveyDeadline.update(obj); }
            else { ObjSurveyDeadline.insert(obj); }

            ComboBox temp = new ComboBox();
            Utils.bind(temp, "is_user", "id", false, "where role_id = 2");

            string query = "";

            for(int i = 0; i < temp.Items.Count; i++)
            {

                int userId = int.Parse(temp.Items[i].ToString());

                string log = $@"

                    insert into is_alert(user_id, alert, date)

                    values (
                    {userId},
                    'Срок сдачи анкеты ""{survey}"" \n {(obj.dt_begin.Contains("null") ? "Не установлено" : date1.ToString("yyyyMMdd"))} - {(obj.dt_end.Contains("null") ? "Не установлено" : date2.ToString("yyyyMMdd"))}',
                    CURRENT_DATE
                    )

                ;";

                query += log;

            }

            DBUtils.execQuery(query);

            MessageBox.Show("Сохранено");

        }

    }

}
