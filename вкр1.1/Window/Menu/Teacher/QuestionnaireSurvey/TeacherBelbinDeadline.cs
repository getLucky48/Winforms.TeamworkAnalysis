using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Teacher;

namespace WinFormInfSys.Window
{
    public partial class TeacherBelbinDeadline : Form
    {
        public TeacherBelbinDeadline()
        {

            InitializeComponent();

            Utils.bind(Discipline, "is_discipline", "name");
            Utils.bind(Group, "is_group", "name");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(Discipline.SelectedIndex == -1 || Group.SelectedIndex == -1) { MessageBox.Show("Проверьте правильность ввода"); return; }

            bool ignore1 = checkBox1.Checked;
            bool ignore2 = checkBox2.Checked;

            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            string preparedDate1 = $"CAST('{date1:yyyyMMdd}' as date)";
            string preparedDate2 = $"CAST('{date2:yyyyMMdd}' as date)";

            string group = Group.SelectedItem.ToString();
            string discipline = Discipline.SelectedItem.ToString();

            ObjBelbinDeadline obj = new ObjBelbinDeadline() {

                group = group,
                discipline = discipline,
                dt_begin = ignore1 ? "null" : preparedDate1,
                dt_end = ignore2 ? "null" : preparedDate2
            
            };

            if (ObjBelbinDeadline.isExists(obj)) { ObjBelbinDeadline.update(obj); }
            else { ObjBelbinDeadline.insert(obj); }

            MessageBox.Show("Сохранено");

        }

    }

}
