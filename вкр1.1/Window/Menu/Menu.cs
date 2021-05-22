using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Window;
using WinFormInfSys.Window.Menu.Teacher;
using static WinFormInfSys.Auth;

namespace WinFormInfSys
{
    public partial class Menu : Form
    {

        public Menu()
        {

            InitializeComponent();

        }

        public Menu(Tuple<Role, int> role)
        {

            InitializeComponent();

            this.role = role;

            if (role.Item1 == Role.Teacher)
            {

                teacherPage.Enabled = true;
                adminPage.Enabled = true;
                this.Controls.RemoveByKey("Alerts");
                this.Controls.RemoveByKey("label1");

            }
            else if(role.Item1 == Role.Student)
            {

                studentPage.Enabled = true;
                alertUser();

            }


            infoUser();

        }

        private Tuple<Role, int> role;

        private void infoUser()
        {

            string query = $"select * from is_user where id = {this.role.Item2}";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            string userName = string.Empty;

            while (reader.Read())
            {

                userName = reader["name"].ToString();

                break;

            }

            connection.Close();

            UserInfo.Text = $"Вы авторизованы как {userName}";

        }

        private void alertUser()
        {
             
            string query = $"select * from is_alert where user_id = {this.role.Item2} order by date desc";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Alerts.Items.Add($"{reader["date"]} {reader["alert"]}");

            }

            connection.Close();



        }
        private void сменитьПользователяToolStripMenuItem_Click_1(object sender, EventArgs e)       { this.Close(); }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)                       { Application.Exit(); }
        private void тестБелбинаToolStripMenuItem_Click(object sender, EventArgs e)                 { Utils.switchWindow(this, new StudentBelbin(role)); }
        private void таблицаПроектовToolStripMenuItem_Click(object sender, EventArgs e)             { Utils.switchWindow(this, new StudentProjects(role)); }
        private void опросыToolStripMenuItem_Click(object sender, EventArgs e)                      { Utils.switchWindow(this, new StudentSurveys(role)); }
        private void добавитьЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)             { Utils.switchWindow(this, new TeacherTaskAdd(role)); }
        private void таблицаПроектовToolStripMenuItem1_Click(object sender, EventArgs e)            { Utils.switchWindow(this, new TeacherProjects(role)); }
        private void результатыТестаToolStripMenuItem_Click_1(object sender, EventArgs e)           { Utils.switchWindow(this, new TeacherBelbinResults()); }
        private void создатьБригадыToolStripMenuItem_Click_1(object sender, EventArgs e)            { Utils.switchWindow(this, new TeacherTeamAdd(role)); }
        private void графикиУспеваемостиToolStripMenuItem_Click(object sender, EventArgs e)         { Utils.switchWindow(this, new TeacherPerfomance()); }
        private void результатыОпросовToolStripMenuItem_Click(object sender, EventArgs e)           { Utils.switchWindow(this, new TeacherSurveyResults()); }
        private void списокПреподавателейToolStripMenuItem_Click(object sender, EventArgs e)        { Utils.switchWindow(this, new AdminTeachersList()); }
        private void списокГруппToolStripMenuItem_Click(object sender, EventArgs e)                 { Utils.switchWindow(this, new AdminGroupsList()); }
        private void списокСтудентовToolStripMenuItem_Click(object sender, EventArgs e)             { Utils.switchWindow(this, new AdminStudentsList()); }
        private void списокДисциплинToolStripMenuItem_Click(object sender, EventArgs e)             { Utils.switchWindow(this, new AdminDisciplinesList()); }
        private void оценкипроектыToolStripMenuItem_Click(object sender, EventArgs e)               { /*todo*/ }
        private void оценкидисциплинаToolStripMenuItem_Click(object sender, EventArgs e)            { Utils.switchWindow(this, new TeacherSetScoreDiscipline(role.Item2)); }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)                     { Utils.switchWindow(this, new About()); }
        private void списокЗаданийToolStripMenuItem_Click(object sender, EventArgs e)               { Utils.switchWindow(this, new TeacherProjectsEdit(role)); }
        private void установитьСрокиПрохожденияТестовToolStripMenuItem_Click(object sender, EventArgs e) { Utils.switchWindow(this, new TeacherSurveyDeadline()); }
    }

}
