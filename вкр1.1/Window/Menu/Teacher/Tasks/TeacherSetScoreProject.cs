using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window.Menu.Teacher
{
    public partial class TeacherSetScoreProject : Form
    {
        public TeacherSetScoreProject()
        {
            InitializeComponent();
        }

        public TeacherSetScoreProject(int userId)
        {

            InitializeComponent();
            
            this.userId = userId;

            Utils.bind(Disciplines, "is_discipline", "name");
            Utils.bind(Groups, "is_group", "name");

        }

        private int userId { get; set; }

        private void buildTable()
        {

            if(Groups.SelectedIndex == -1 || Disciplines.SelectedIndex == -1) { return; }
            if(Projects.SelectedIndex == -1) { return; }

            Table.SuspendLayout();

            Table.Controls.Clear();

            string group = Groups.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();
            string project = Projects.SelectedItem.ToString();

            string query = $@"

                select 

                isu.name,
                isp.score

                from is_project isp

                join is_user isu on isu.id = isp.student_Id
                join is_group isg on isg.id = isu.group_id

                where isp.teacher_id = {this.userId}
                and isp.score is not null
                and isg.id = (select id from is_group where name = '{group}')
                and isp.discipline_id = (select id from is_discipline where name = '{discipline}')
                and isp.name = '{project}'

                order by isu.name

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 0;

            while (reader.Read())
            {

                Utils.fillRow(Table, new Control[] {

                    Utils.buildLabel(reader["name"].ToString()),
                    Utils.buildLabel(reader["score"].ToString())

                }, row);

                row++;

            }

            connection.Close();

            Table.ResumeLayout();

        }

        private void Disciplines_SelectedIndexChanged(object sender, EventArgs e)
        {

            Projects.Items.Clear();

            if(Disciplines.SelectedIndex == -1) { return; }

            string discipline = Disciplines.SelectedItem.ToString();

            Utils.bind(Projects, "is_project", "name", true, $"isp where isp.teacher_id = {this.userId} and isp.fl_unique = 1 and discipline_id = (select id from is_discipline where name = '{discipline}')");

            buildTable();
        }

        private void Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildTable();
        }

        private void Projects_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildTable();
        }

    }

}
