using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Admin;

namespace WinFormInfSys.Window
{
    public partial class _edit_AdminGroupsList : Form
    {
        public _edit_AdminGroupsList()
        {
            InitializeComponent();
        }
    
        public _edit_AdminGroupsList(int group_id)
        {

            InitializeComponent();

            this.group_id = group_id;

            string query = $"select * from is_group where id = '{group_id}'";

            Utils.bind(FacultyList, "is_faculty", "name");
            Utils.selectItem(FacultyList, "is_group", "faculty_id", "is_faculty", "id", "name", this.group_id);

            Utils.bind(CourseList, "is_course", "name");
            Utils.selectItem(CourseList, "is_group", "course_id", "is_course", "id", "name", this.group_id);

            Utils.bind(GroupName, "name", query);
            Utils.bind(Year, "dt", query);

        }

        private int group_id { get; set; }

        private void Create_Click(object sender, EventArgs e)
        {

            string name = GroupName.Text;
            string year = Year.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(year) || FacultyList.SelectedIndex == -1 || CourseList.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            ObjGroupsList obj = new ObjGroupsList()
            {

                id = this.group_id.ToString(),
                name = name,
                dt = year,
                faculty = FacultyList.SelectedItem.ToString(),
                course = CourseList.SelectedItem.ToString()

            };

            ObjGroupsList.update(obj);

            this.Close();

        }

    }

}
