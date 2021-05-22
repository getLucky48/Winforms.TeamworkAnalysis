using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window.Menu.Teacher
{
    public partial class TeacherSetScoreDiscipline : Form
    {
        public TeacherSetScoreDiscipline()
        {

            InitializeComponent();
            Utils.bind(Disciplines, "is_discipline", "name");
            Utils.bind(Groups, "is_group", "name");

            Scores.Items.Add(2);
            Scores.Items.Add(3);
            Scores.Items.Add(4);
            Scores.Items.Add(5);

        }

        private void buildTable()
        {

            if(Groups.SelectedIndex == -1 || Disciplines.SelectedIndex == -1) { return; }

            Table.SuspendLayout();

            Table.Controls.Clear();

            Students.Items.Clear();


            string group = Groups.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();

            string query = $@"

                select * from is_user isu

                join is_score isc on isc.student_id = isu.id

                where isu.group_id = (select id from is_group where name = '{group}')
                and isc.discipline_id = (select id from is_discipline where name = '{discipline}')

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

            string customWhere = $@"

                isu where

                isu.id not in (select student_id from is_score 
                                where student_id = isu.id 
                                and discipline_id = (select id from is_discipline where name = '{discipline}'))


                and group_id = (select id from is_group where name = '{group}')

            ";

            Utils.bind(Students, "is_user", "name", true, customWhere);

            Table.ResumeLayout();

        }

        private void Disciplines_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildTable();
        }

        private void Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildTable();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Scores.SelectedIndex == -1) { return; }
            if (Groups.SelectedIndex == -1 || Disciplines.SelectedIndex == -1) { return; }
            if (Students.SelectedIndex == -1) { return; }

            string user = Students.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();

            string query = $@"

                insert into is_score(student_id, discipline_id, score) values(
                (select id from is_user where name = '{user}'),
                (select id from is_discipline where name = '{discipline}'),
                {Scores.SelectedItem}
                )

            ";

            DBUtils.execQuery(query);

            buildTable();

        }

    }

}
