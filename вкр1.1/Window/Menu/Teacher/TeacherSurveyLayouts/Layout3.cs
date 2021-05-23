using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Teacher;

namespace WinFormInfSys.Window.Menu.Teacher.TeacherSurveyLayouts
{
    public partial class Layout3 : Form
    {
        public Layout3()
        {
            InitializeComponent(); 

            Utils.bind(DisciplineList, "is_discipline", "name");
            Utils.bind(GroupList, "is_group", "name");

            this.currObj = new ObjSurveyRes_Layout3();

            textBox2.KeyUp += TextBox2_KeyUp;

        }

        private void TextBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if(SubGroupList.SelectedIndex == -1) { return; }

            string sub = SubGroupList.SelectedItem.ToString();
            this.currObj.subGroups[sub] = new Tuple<List<string>, string>(this.currObj.subGroups[sub].Item1, textBox2.Text);

        }

        private ObjSurveyRes_Layout3 currObj { get; set; }

        private string[] prepareArray(string str)
        {

            string result = str.Replace("[", string.Empty).Replace("]", string.Empty).Replace("\",\"", "_").Replace("\"", string.Empty);

            return result.Split(new char[] { '_' });

        }

        private void buildTable()
        {

            if (DisciplineList.SelectedIndex == -1 || GroupList.SelectedIndex == -1) { return; }

            Table.SuspendLayout();

            Table.Controls.Clear();

            string group = GroupList.SelectedItem.ToString();
            string discipline = DisciplineList.SelectedItem.ToString();

            this.currObj = new ObjSurveyRes_Layout3();

            if (ObjSurveyRes_Layout3.isExists(new ObjSurveyRes_Layout3() { group = group, discipline = discipline }))
            {

                string data = ObjSurveyRes_Layout3.getData(group, discipline);

                if (!string.IsNullOrEmpty(data)) {

                    this.currObj = JsonConvert.DeserializeObject<ObjSurveyRes_Layout3>(data);

                    foreach(var t in this.currObj.subGroups) { SubGroupList.Items.Add(t.Key); }

                }

            }

            List<ObjSurveyRes_Layout3> list = ObjSurveyRes_Layout3.getList(GroupList.SelectedItem.ToString(), DisciplineList.SelectedItem.ToString());

            for (int i = 0; i < list.Count; i++)
            {

                ObjSurveyRes_Layout3 obj = list[i];

                string[] args = prepareArray(obj.result);

                Utils.fillRow(Table, new Control[] {

                    Utils.buildLabel(obj.date.Replace("0:00:00", string.Empty)),
                    Utils.buildLabel(args[0]),
                    Utils.buildLabel(args[1]),
                    Utils.buildLabel(args[2]),
                    Utils.buildLabel(args[3])

                }, i);

            }

            Table.ResumeLayout();

        }

        private void DisciplineList_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            buildTable();

        }

        private void GroupList_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            buildTable();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(SubGroup.Text)) { return; }

            string sub = SubGroup.Text;

            if (SubGroupList.Items.Contains(sub))
            {

                MessageBox.Show("Подгруппа уже существует");

                return;

            }

            if(SubGroupList.Items.Count == 10)
            {

                MessageBox.Show("Достигнуто максимальное количество подгрупп (10)");

                return;

            }

            SubGroupList.Items.Add(sub);
            this.currObj.subGroups.Add(sub, new Tuple<List<string>, string>(new List<string>(), string.Empty));

            SubGroup.Text = "";

        }

        private void SubGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sub = SubGroupList.SelectedItem.ToString();

            Data.Items.Clear();
            textBox2.Clear();

            textBox2.Text = this.currObj.subGroups[sub].Item2;
            
            for(int i = 0; i < this.currObj.subGroups[sub].Item1.Count; i++)
            {

                Data.Items.Add(this.currObj.subGroups[sub].Item1[i]);

            }

        }

        private void button2_Click(object sender, System.EventArgs e)
        {

            if(SubGroupList.SelectedIndex == -1)
            {

                MessageBox.Show("Не выбрана подгруппа");

                return;

            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {

                MessageBox.Show("Проверьте правильность ввода");

                return;

            }

            string sub = SubGroupList.SelectedItem.ToString();

            string t = textBox1.Text;

            this.currObj.subGroups[sub].Item1.Add(t);

            Data.Items.Add(t);

            textBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string sub = SubGroupList.SelectedItem.ToString();

            this.currObj.subGroups[sub] = new Tuple<List<string>, string>(this.currObj.subGroups[sub].Item1, textBox2.Text);
            this.currObj.group = GroupList.SelectedItem.ToString();
            this.currObj.discipline = DisciplineList.SelectedItem.ToString();

            if (ObjSurveyRes_Layout3.isExists(this.currObj)) { ObjSurveyRes_Layout3.update(this.currObj); }
            else { ObjSurveyRes_Layout3.insert(this.currObj); }

            MessageBox.Show("Сохранено");

            buildTable();

        }

    }

}
