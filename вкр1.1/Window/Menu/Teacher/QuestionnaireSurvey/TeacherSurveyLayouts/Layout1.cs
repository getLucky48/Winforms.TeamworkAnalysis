using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Teacher;

namespace WinFormInfSys.Window.Menu.Teacher.TeacherSurveyLayouts
{
    public partial class Layout1 : Form
    {
        public Layout1()
        {

            InitializeComponent();

            Utils.bind(DisciplineList, "is_discipline", "name");
            Utils.bind(GroupList, "is_group", "name");


            Utils.fillRow(Table, new Control[] {

                Utils.buildLabel("Дата"),
                Utils.buildLabel("Результат")

            }, 0);

        }

        private void buildTable()
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            count1.Text = $"Количество положительных мнений {listBox1.Items.Count}";
            count2.Text = $"Количество положительных мнений {listBox2.Items.Count}";

            if (DisciplineList.SelectedIndex == -1 || GroupList.SelectedIndex == -1) { return; }

            Table.SuspendLayout();

            Table.Controls.Clear();

            Utils.fillRow(Table, new Control[] {

                Utils.buildLabel("Дата"),
                Utils.buildLabel("Результат")

            }, 0);

            List<ObjSurveyRes_Layout1> list = ObjSurveyRes_Layout1.getList(GroupList.SelectedItem.ToString(), DisciplineList.SelectedItem.ToString());

            for(int i = 0; i < list.Count; i++)
            {

                ObjSurveyRes_Layout1 obj = list[i];

                Utils.fillRow(Table, new Control[] {

                    Utils.buildLabel(obj.date.Replace("0:00:00", string.Empty)),
                    Utils.buildLabel(obj.result)

                }, i + 1);

            }

            Tuple<string, string> columns = ObjSurveyRes_Layout1.getColumns(GroupList.SelectedItem.ToString(), DisciplineList.SelectedItem.ToString());

            string[] plus = prepareArray(columns.Item1);
            string[] minus = prepareArray(columns.Item2);

            for (int i = 0; i < plus.Length; i++) { if(!string.IsNullOrEmpty(plus[i])) listBox1.Items.Add(plus[i]); }
            for (int i = 0; i < minus.Length; i++) { if (!string.IsNullOrEmpty(minus[i])) listBox2.Items.Add(minus[i]); }

            count1.Text = $"Количество положительных мнений {listBox1.Items.Count}";
            count2.Text = $"Количество положительных мнений {listBox2.Items.Count}";

            Table.ResumeLayout();

        }

        private string[] prepareArray(string str)
        {

            string result = str.Replace("[", string.Empty).Replace("]", string.Empty).Replace("\",\"", "_").Replace("\"", string.Empty);

            return result.Split(new char[] { '_' });

        }

        private void DisciplineList_SelectedIndexChanged(object sender, EventArgs e)
        {

            buildTable();

        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {

            buildTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            count1.Text = $"Количество положительных мнений {listBox1.Items.Count}";

            if (string.IsNullOrWhiteSpace(textBox1.Text)) { return; }

            if (DisciplineList.SelectedIndex == -1 || GroupList.SelectedIndex == -1) { return; }

            string txt = textBox1.Text;

            listBox1.Items.Add(txt);

            count1.Text = $"Количество положительных мнений {listBox1.Items.Count}";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            count2.Text = $"Количество положительных мнений {listBox2.Items.Count}";

            if (string.IsNullOrWhiteSpace(textBox2.Text)) { return; }
            if (DisciplineList.SelectedIndex == -1 || GroupList.SelectedIndex == -1) { return; }

            string txt = textBox2.Text;

            listBox2.Items.Add(txt);

            count2.Text = $"Количество положительных мнений {listBox2.Items.Count}";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (DisciplineList.SelectedIndex == -1 || GroupList.SelectedIndex == -1) { return; }

            string plus = JsonConvert.SerializeObject(listBox1.Items);
            string minus = JsonConvert.SerializeObject(listBox2.Items);

            ObjSurveyRes_Layout1 obj = new ObjSurveyRes_Layout1() {

                group = GroupList.SelectedItem.ToString(),
                discipline = DisciplineList.SelectedItem.ToString(),
                plus = JsonConvert.SerializeObject(plus),
                minus = JsonConvert.SerializeObject(minus)

            };

            if (ObjSurveyRes_Layout1.isExists(obj)) { ObjSurveyRes_Layout1.update(obj); }
            else { ObjSurveyRes_Layout1.insert(obj); }

            MessageBox.Show("Успешно сохранено");

            this.Close();

        }

    }

}
