using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WinFormInfSys.Class;

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

            this.user_id = group_id;

            string query = $"select * from is_group where id = '{group_id}'";

            Utils.bind(FacultyList, "is_faculty", "name");
            Utils.selectItem(FacultyList, "is_group", "faculty_id", "is_faculty", "id", "name", this.user_id);

            Utils.bind(CourseList, "is_course", "name");
            Utils.selectItem(CourseList, "is_group", "course_id", "is_course", "id", "name", this.user_id);

            Utils.bind(GroupName, "name", query);

        }

        private int user_id { get; set; }

        private void Create_Click(object sender, EventArgs e)
        {

            string name = GroupName.Text;

            if (string.IsNullOrWhiteSpace(name) || FacultyList.SelectedIndex == -1 || CourseList.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            string query = $@"
                            UPDATE is_group SET 

                            name = '{name}', 
                            course_id = (select id from is_course where name = '{CourseList.SelectedItem}' limit 1),
                            faculty_id = (select id from is_faculty where name = '{FacultyList.SelectedItem}' limit 1)

                            WHERE id = '{user_id}'

                            ";

            DBUtils.execQuery(query);

            this.Close();

        }

    }

}
