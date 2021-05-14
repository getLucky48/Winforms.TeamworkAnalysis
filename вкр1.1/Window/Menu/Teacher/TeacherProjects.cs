using MySql.Data.MySqlClient;
using System;
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
            Utils.bind(CurrentGroup, "is_group", "name");

            Utils.fillRow(Table, new Control[] {
                new Label(){Text = "Название", AutoSize = true },
                new Label(){Text = "Номер \nбригады", AutoSize = true},
                new Label(){Text = "Студент", AutoSize = true},
                new Label(){Text = "Этап 1\nпостановка задачи" , AutoSize = true},
                new Label(){Text = "Этап 2\nтестовые данные", AutoSize = true},
                new Label(){Text = "Этап 3\nструктура и алгоритмы", AutoSize = true},
                new Label(){Text = "Этап 4\nинтерфейс", AutoSize = true},
                new Label(){Text = "Этап 5\nотладка", AutoSize = true},
                new Label(){Text = "Этап 6\nзащита", AutoSize = true},
                new Label(){Text = "Оценка", AutoSize = true}
            }, 0);
        }

        private Tuple<Role, int> role { get; set; }

        private void fillTable()
        {

            Table.SuspendLayout();

            Table.Controls.Clear();
            Utils.fillRow(Table, new Control[] {
                new Label(){Text = "Название", AutoSize = true },
                new Label(){Text = "Номер \nбригады", AutoSize = true},
                new Label(){Text = "Студент", AutoSize = true},
                new Label(){Text = "Этап 1\nпостановка задачи" , AutoSize = true},
                new Label(){Text = "Этап 2\nтестовые данные", AutoSize = true},
                new Label(){Text = "Этап 3\nструктура и алгоритмы", AutoSize = true},
                new Label(){Text = "Этап 4\nинтерфейс", AutoSize = true},
                new Label(){Text = "Этап 5\nотладка", AutoSize = true},
                new Label(){Text = "Этап 6\nзащита", AutoSize = true},
                new Label(){Text = "Оценка (работа)", AutoSize = true},
                new Label(){Text = "Оценка (дисциплина)", AutoSize = true}
            }, 0);

            if (CurrentDiscipline.SelectedIndex == -1 || CurrentGroup.SelectedIndex == -1) { Table.ResumeLayout(); return; }

            string discipline = CurrentDiscipline.SelectedItem.ToString();
            string gr = CurrentGroup.SelectedItem.ToString();


            string query = $@"

                select
                
                isp.*,
                isg.name as groupname,
                ist.num as teamnum,
                isu.name as student,
                iss.score as disciplinescore
                
                from is_project isp 

				join is_user isu on isu.id = isp.student_Id
                join is_group isg on isg.id = (select id from is_group where name = '{gr}' limit 1)
               	join is_team ist on ist.user_id = isp.student_Id
                left join is_score iss on iss.student_id = isu.id

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
                string ds = reader["disciplinescore"].ToString();

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
                Label disciplinescore = Utils.buildLabel(ds, Guid.NewGuid().ToString());

                Utils.fillRow(Table, new Control[] {
                    proj,
                    team,
                    student,
                    step1,
                    step2,
                    step3,
                    step4,
                    step5,
                    step6,
                    score,
                    disciplinescore
                }, row);

                row++;

            }

            connection.Close();

            Table.ResumeLayout();

        }

        private void CurrentDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {

            fillTable();

        }

        private void CurrentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            fillTable();

        }

    }

}
