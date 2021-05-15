using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Window;
using static WinFormInfSys.Auth;

namespace WinFormInfSys
{

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
                new Label(){Text = "Оценка (работа)", AutoSize = true},
                new Label(){Text = "Оценка (дисциплина)", AutoSize = true},
                new Label(){Text = " "}
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
                new Label(){Text = "Оценка (дисциплина)", AutoSize = true},
                new Label(){Text = " "}
            }, 0);

            if (CurrentDiscipline.SelectedIndex == -1 || CurrentGroup.SelectedIndex == -1) { Table.ResumeLayout(); return; }

            string discipline = CurrentDiscipline.SelectedItem.ToString();
            string gr = CurrentGroup.SelectedItem.ToString();


            string query = $@"

                select
                
                isp.id,
                isp.name,
                isp.score,
                isg.name as groupname,
                ist.num as teamnum,
                isu.name as student,
                iss.score as disciplinescore,
                isstat1.name as step1, 
                isstat2.name as step2, 
                isstat3.name as step3, 
                isstat4.name as step4, 
                isstat5.name as step5, 
                isstat6.name as step6
                
                from is_project isp 

				join is_user isu on isu.id = isp.student_Id
                join is_group isg on isg.id = (select id from is_group where name = '{gr}' limit 1)
               	join is_team ist on ist.user_id = isp.student_Id
                left join is_score iss on iss.student_id = isu.id

                left join is_solution iss1 on iss1.id = isp.step1
                left join is_solution iss2 on iss2.id = isp.step2
                left join is_solution iss3 on iss3.id = isp.step3
                left join is_solution iss4 on iss4.id = isp.step4
                left join is_solution iss5 on iss5.id = isp.step5
                left join is_solution iss6 on iss6.id = isp.step6

				left join is_status isstat1 on isstat1.id = iss1.status_id
				left join is_status isstat2 on isstat2.id = iss2.status_id
				left join is_status isstat3 on isstat3.id = iss3.status_id
				left join is_status isstat4 on isstat4.id = iss4.status_id
				left join is_status isstat5 on isstat5.id = iss5.status_id
				left join is_status isstat6 on isstat6.id = iss6.status_id

                where 
                isp.discipline_id = (select id from is_discipline where name = '{discipline}' limit 1)
                and 
                isp.fl_unique = 0
                and
                isp.teacher_id = {this.role.Item2}
                and isg.id = isu.group_id

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
                Button open = Utils.buildButton("Открыть", $"OpenProjById_{reader["id"]}");
                open.Width = 100;
                open.Click += Open_Click;

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
                    disciplinescore,
                    open
                }, row);

                row++;

            }

            connection.Close();

            Table.ResumeLayout();

        }

        private void Open_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            int projId = int.Parse(b.Name.Replace("OpenProjById_", string.Empty));

            Utils.switchWindow(this, new TeacherOpenProject(projId));

            fillTable();

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
