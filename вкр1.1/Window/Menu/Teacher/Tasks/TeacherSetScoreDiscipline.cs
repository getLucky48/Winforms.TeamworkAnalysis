using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using Excel = Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace WinFormInfSys.Window.Menu.Teacher
{
    public partial class TeacherSetScoreDiscipline : Form
    {
        public TeacherSetScoreDiscipline()
        {

            InitializeComponent();
            Utils.bind(Disciplines, "is_discipline", "name");
            Utils.bind(Groups, "is_group", "name");
            Groups.Items.Add("Все");
            Groups.SelectedIndex = Groups.Items.Count - 1;

        }

        private int translateToTrad(int score)
        {

            if(score < 0) { return 0; }

            if (score < 50) { return 2; }
            if (score < 73) { return 3; }
            if (score < 87) { return 4; }
            if (score <= 100) { return 5; }

            return 0;

        }

        private string translateToECTS(int score)
        {

            if (score < 0) { return "none"; }

            if(score < 25) { return "F"; }
            if(score < 50) { return "FX"; }
            if(score < 60) { return "E"; }
            if(score < 63) { return "D-"; }
            if(score < 67) { return "D"; }
            if(score < 70) { return "D+"; }
            if(score < 73) { return "C-"; }
            if(score < 77) { return "C"; }
            if(score < 80) { return "C+"; }
            if(score < 83) { return "B-"; }
            if(score < 87) { return "B"; }
            if(score < 90) { return "B+"; }
            if(score < 93) { return "A-"; }
            if(score < 98) { return "A"; }
            if(score <= 100) { return "A+"; }

            return "none";

        }

        private void buildTable()
        {

            if(Groups.SelectedIndex == -1 || Disciplines.SelectedIndex == -1) { return; }

            Table.SuspendLayout();

            Utils.fillRow(Table, new Control[] {

                Utils.buildLabel("ФИО"),
                Utils.buildLabel("Оценка (традиционная)"),
                Utils.buildLabel("Оценка (ECTS)"),
                Utils.buildLabel("Баллы")

            }, 0);

            Table.Controls.Clear();

            Students.Items.Clear();


            string group = Groups.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();

            string query = $@"

                select * from is_user isu

                join is_score isc on isc.student_id = isu.id

                where { (group.Contains("Все") ? "" : $"isu.group_id = (select id from is_group where name = '{group}') and ") }
                
                isc.discipline_id = (select id from is_discipline where name = '{discipline}')

                order by isu.name

            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 1;

            while (reader.Read())
            {

                Utils.fillRow(Table, new Control[] {

                    Utils.buildLabel(reader["name"].ToString()),
                    Utils.buildLabel(translateToTrad(int.Parse(reader["score"].ToString())).ToString()),
                    Utils.buildLabel(translateToECTS(int.Parse(reader["score"].ToString()))),
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


                { (group.Contains("Все") ? "" : $"and group_id = (select id from is_group where name = '{group}') ") }         

                order by isu.name


            ";

            Utils.bind(Students, "is_user", "name", true, customWhere);

            Table.ResumeLayout();

            buildTableScoresProject();


        }

        private void buildTableScoresProject()
        {

            if (Groups.SelectedIndex == -1 || Disciplines.SelectedIndex == -1) { return; }

            ScoresProject.SuspendLayout();

            ScoresProject.Controls.Clear();

            string group = Groups.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();

            string query = $@"

                    select

                    isu.name as student,
                    isp.name as project,
                    isp.score as score

                    from is_project isp 

                    join is_user isu on isu.id = isp.student_Id


                    where isp.discipline_id = (select id from is_discipline where name = '{discipline}')
                    and isu.group_id = (select id from is_group where name = '{group}')

            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 0;

            while (reader.Read())
            {

                Utils.fillRow(ScoresProject, new Control[] {

                    Utils.buildLabel(reader["student"].ToString()),
                    Utils.buildLabel(reader["project"].ToString()),
                    Utils.buildLabel(reader["score"].ToString()),
                    Utils.buildLabel(translateToTrad(int.Parse(reader["score"].ToString())).ToString())


                }, row);

                row++;

            }


            connection.Close();

            ScoresProject.ResumeLayout();

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

            if (!int.TryParse(Scores.Text, out int temp)) { return; }
            if (Groups.SelectedIndex == -1 || Disciplines.SelectedIndex == -1) { return; }
            if (Students.SelectedIndex == -1) { return; }

            string user = Students.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();

            string query = $@"

                insert into is_score(student_id, discipline_id, score) values(
                (select id from is_user where name = '{user}'),
                (select id from is_discipline where name = '{discipline}'),
                {Scores.Text}
                )

            ";

            DBUtils.execQuery(query);

            buildTable();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            const string path = "table.xlsx";

            Application application = new Application
            {
                DisplayAlerts = false
            };

            Workbook workbook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, path));

            Worksheet worksheet = workbook.ActiveSheet as Worksheet;

            worksheet.Range["A1"].Value = "ФИО";
            worksheet.Range["B1"].Value = "Оценка (традиционная)";
            worksheet.Range["C1"].Value = "Оценка (ECTS)";
            worksheet.Range["D1"].Value = "Баллы";

            string group = Groups.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();

            string query = $@"

                select * from is_user isu

                join is_score isc on isc.student_id = isu.id

                where { (group.Contains("Все") ? "" : $"isu.group_id = (select id from is_group where name = '{group}') and ") }
                
                isc.discipline_id = (select id from is_discipline where name = '{discipline}')

                order by isu.name

            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 2;

            while (reader.Read())
            {

                worksheet.Cells[row, 1] = reader["name"].ToString();
                worksheet.Cells[row, 2] = translateToTrad(int.Parse(reader["score"].ToString())).ToString();
                worksheet.Cells[row, 3] = translateToECTS(int.Parse(reader["score"].ToString()));
                worksheet.Cells[row, 4] = int.Parse(reader["score"].ToString());

                row++;

            }

            connection.Close();

            MessageBox.Show("Успешно!");

            application.Visible = true;

        }

    }

}
