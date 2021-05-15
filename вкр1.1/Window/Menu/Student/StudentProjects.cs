using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Window;
using static WinFormInfSys.Auth;

namespace WinFormInfSys
{

    public partial class StudentProjects : Form
    {
        public StudentProjects()
        {
            InitializeComponent();
        }

        public StudentProjects(Tuple<Role, int> role)
        {

            InitializeComponent();

            this.role = role;

            buildTable();

        }

        private Tuple<Role, int> role { get; set; }

        private void buildTable()
        {

            Table.SuspendLayout();

            Table.Controls.Clear();

            Utils.fillRow(Table, new Control[] {
                new Label(){ Text = "Предмет", AutoSize = true },
                new Label(){ Text = "Преподаватель", AutoSize = true},
                new Label(){ Text = "Задание", AutoSize = true},
                new Label(){ Text = "Срок сдачи", AutoSize = true},
                new Label(){ Text = "Этап 1\nпостановка задачи", AutoSize = true},
                new Label(){ Text = "Этап 2\nтестовые данные", AutoSize = true},
                new Label(){ Text = "Этап 3\nструктура и алгоритмы", AutoSize = true},
                new Label(){ Text = "Этап 4\nинтерфейс", AutoSize = true},
                new Label(){ Text = "Этап 5\nотладка", AutoSize = true},
                new Label(){ Text = "Этап 6\nзащита", AutoSize = true},
                new Label(){ Text = "Оценка", AutoSize = true },
                new Label(){ Text = " " }
            }, 0); ;

            string query = $@"

                select 
                
                isp.id as id,
                isp.descr as descr, 
                isp.deadline as deadline,
                iste.name as teacher,
                isd.name as discipline,
                isd.id as discipline_id,
                isp.fl_completed as complete,
                isp.name,
                isstat1.name as step1, 
                isstat2.name as step2, 
                isstat3.name as step3, 
                isstat4.name as step4, 
                isstat5.name as step5, 
                isstat6.name as step6,
                isp.score

                from is_user isu

                join is_project isp on isp.student_Id = isu.id
                join is_discipline isd on isd.id = isp.discipline_id
                left join is_user iste on iste.id = isp.teacher_id
                
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

                where isu.id = {this.role.Item2}

            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 1;

            while (reader.Read())
            {

                string d = reader["discipline"].ToString();
                string t = reader["teacher"].ToString();
                string n = reader["name"].ToString();
                string dl = reader["deadline"].ToString();
                string s1 = reader["step1"].ToString();
                string s2 = reader["step2"].ToString();
                string s3 = reader["step3"].ToString();
                string s4 = reader["step4"].ToString();
                string s5 = reader["step5"].ToString();
                string s6 = reader["step6"].ToString();
                string s = reader["score"].ToString();

                Label discipline = Utils.buildLabel(d, Guid.NewGuid().ToString());
                Label teacher = Utils.buildLabel(t, Guid.NewGuid().ToString());
                Label name = Utils.buildLabel(n, Guid.NewGuid().ToString());
                Label deadline = Utils.buildLabel(dl, Guid.NewGuid().ToString());
                Label step1 = Utils.buildLabel(s1, Guid.NewGuid().ToString());
                Label step2 = Utils.buildLabel(s2, Guid.NewGuid().ToString());
                Label step3 = Utils.buildLabel(s3, Guid.NewGuid().ToString());
                Label step4 = Utils.buildLabel(s4, Guid.NewGuid().ToString());
                Label step5 = Utils.buildLabel(s5, Guid.NewGuid().ToString());
                Label step6 = Utils.buildLabel(s6, Guid.NewGuid().ToString());
                Label score = Utils.buildLabel(s, Guid.NewGuid().ToString());
                Button open = Utils.buildButton("Открыть", $"OpenProjById_{reader["id"]}");
                open.Width = 100;
                open.Click += Open_Click;

                Utils.fillRow(Table, new Control[] {
                    discipline,
                    teacher,
                    name,
                    deadline,
                    step1,
                    step2,
                    step3,
                    step4,
                    step5,
                    step6,
                    score,
                    open
                }, row);

                row++;

            }

            conn.Close();

            Table.ResumeLayout();

        }

        private void Open_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            int projId = int.Parse(b.Name.Replace("OpenProjById_", string.Empty));

            Utils.switchWindow(this, new StudentOpenProject(projId));

            buildTable();

        }

    }

}
