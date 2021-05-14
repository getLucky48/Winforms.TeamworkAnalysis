using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys
{
    //todo: open proj
    public partial class TeacherProjects : Form
    {
        public TeacherProjects()
        {
            InitializeComponent();
        }

        public TeacherProjects(Tuple<Role, int> role)
        {

            InitializeComponent();

            this.role = role;

            Utils.bind(CurrentDiscipline, "is_discipline", "name");

        }

        private Tuple<Role, int> role { get; set; }

        private enum GroupingRule
        {


            Bottom,
            Middle,
            Top,
            Completed

        }

        private void CurrentDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {

            Table.SuspendLayout();

            Utils.initTable(Table, new string[] {
                "Проект",
                "Группа",
                "Номер \nбригады",
                "Студент",
                "Этап 1\nпостановка задачи",
                "Этап 2\nтестовые данные",
                "Этап 3\nструктура и алгоритмы",
                "Этап 4\nинтерфейс",
                "Этап 5\nотладка",
                "Этап 6\nзащита",
                "Оценка"
            });

            string discipline = CurrentDiscipline.SelectedItem.ToString();

            string query = $@"

                select
                
                isp.*,
                isg.name as groupname,
                ist.num as teamnum,
                isu.name as student
                
                from is_project isp 

				join is_user isu on isu.id = isp.student_Id
                join is_group isg on isg.id = isu.group_id
               	join is_team ist on ist.user_id = isp.student_Id

                where 
                isp.discipline_id = (select id from is_discipline where name = '{discipline}' limit 1)
                and 
                isp.fl_unique = 0
                and
                isp.teacher_id = {this.role.Item2}

                order by groupname, teamnum

            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 1;

            while (reader.Read())
            {

                string g = reader["groupname"].ToString();
                string t = reader["teamnum"].ToString();
                string p = reader["name"].ToString();
                string u = reader["student"].ToString();
                string s1 = reader["step1"].ToString();
                string s2 = reader["step2"].ToString();
                string s3 = reader["step3"].ToString();
                string s4 = reader["step4"].ToString();
                string s5 = reader["step5"].ToString();
                string s6 = reader["step6"].ToString();
                string s = reader["score"].ToString();

                Label group = Utils.buildLabel(g, row.ToString());
                Label team = Utils.buildLabel(t, row.ToString());
                Label proj = Utils.buildLabel(p, row.ToString());
                Label student = Utils.buildLabel(u, row.ToString());
                Label step1 = Utils.buildLabel(s1, Guid.NewGuid().ToString());
                Label step2 = Utils.buildLabel(s2, Guid.NewGuid().ToString());
                Label step3 = Utils.buildLabel(s3, Guid.NewGuid().ToString());
                Label step4 = Utils.buildLabel(s4, Guid.NewGuid().ToString());
                Label step5 = Utils.buildLabel(s5, Guid.NewGuid().ToString());
                Label step6 = Utils.buildLabel(s6, Guid.NewGuid().ToString());
                Label score = Utils.buildLabel(s, Guid.NewGuid().ToString());

                Utils.fillRow(Table, new Control[] {
                    proj,
                    group,
                    team,
                    student,
                    step1,
                    step2,
                    step3,
                    step4,
                    step5,
                    step6,
                    score
                }, row);

                row++;

            }

            connection.Close();

            Table.ResumeLayout();

        }

    }

}
