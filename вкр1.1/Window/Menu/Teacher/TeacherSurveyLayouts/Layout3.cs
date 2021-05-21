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

            List<ObjSurveyRes_Layout3> list = ObjSurveyRes_Layout3.getList(GroupList.SelectedItem.ToString(), DisciplineList.SelectedItem.ToString());

            for (int i = 0; i < list.Count; i++)
            {

                ObjSurveyRes_Layout3 obj = list[i];

                string[] args = prepareArray(obj.result);

                Utils.fillRow(Table, new Control[] {

                    Utils.buildLabel(obj.date),
                    Utils.buildLabel(args[0]),
                    Utils.buildLabel(args[1]),
                    Utils.buildLabel(args[2]),
                    Utils.buildLabel(args[3])

                }, i);

            }



            //Tuple<string, string> columns = ObjSurveyRes_Layout1.getColumns(GroupList.SelectedItem.ToString(), DisciplineList.SelectedItem.ToString());

            //string[] plus = prepareArray(columns.Item1);
            //string[] minus = prepareArray(columns.Item2);

            //for (int i = 0; i < plus.Length; i++) { listBox1.Items.Add(plus[i]); }
            //for (int i = 0; i < minus.Length; i++) { listBox2.Items.Add(minus[i]); }

            //count1.Text = $"Количество положительных откликов {listBox1.Items.Count}";
            //count2.Text = $"Количество положительных откликов {listBox2.Items.Count}";

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
            this.currObj.subGroups.Add(sub, new List<string>());

            //todo

        }

    }

}
