using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys
{

    //todo: open proj
    public partial class StudentProjects : Form
    {
        public StudentProjects()
        {
            InitializeComponent();
        }

        public StudentProjects(Tuple<Role, int> role)
        {

            InitializeComponent();

            buildTable(role.Item2);

        }

        private void buildTable(int userId)
        {

            Table.SuspendLayout();

            Utils.initTable(Table, new string[] {
                "Предмет",
                "Преподаватель",
                "Задание",
                "Срок сдачи",
                "Этап 1\nпостановка задачи",
                "Этап 2\nтестовые данные",
                "Этап 3\nструктура и алгоритмы",
                "Этап 4\nинтерфейс",
                "Этап 5\nотладка",
                "Этап 6\nзащита",
                "Оценка"
            });

            string query = $@"

                select 

                isp.descr as descr, 
                isp.deadline as deadline,
                iste.name as teacher,
                isd.name as discipline,
                isd.id as discipline_id,
                isp.fl_completed as complete,
                isp.name,
                isp.step1,
                isp.step2,
                isp.step3,
                isp.step4,
                isp.step5,
                isp.step6,
                isp.score

                from is_user isu

                join is_project isp on isp.student_Id = isu.id
                join is_discipline isd on isd.id = isp.discipline_id
                left join is_user iste on iste.id = isp.teacher_id

                where isu.id = {userId}

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
                    score                
                }, row);

                row++;

            }

            conn.Close();

            Table.ResumeLayout();

        }


    }

}
