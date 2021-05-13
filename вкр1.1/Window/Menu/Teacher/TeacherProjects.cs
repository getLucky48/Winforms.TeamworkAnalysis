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

//todo: ALL

/*
 * 
 * 
 * 
        select * from is_project isp

        join is_discipline isd on isd.id = isp.discipline_id

        where isp.teacher_id = 2
 * 
 * 
 * 
 * 
 */


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

            buildTable(role.Item2);

        }

        private class Project
        {

            public string teacher { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string descr { get; set; }
            public DateTime date { get; set; }
            public int disciplineId { get; set; }
            public bool isCompleted { get; set; }

        };

        private class ClustProject
        {

            public ClustProject()
            {

                teacher = string.Empty;
                name = string.Empty;
                container = new List<Project>();

            }

            public string teacher { get; set; }
            public string name { get; set; }
            public List<Project> container { get; set; }

        }

        private Label buildLabel(int titleWidth, string text)
        {

            Label res = new Label();
            res.Width = titleWidth;
            res.Parent = this;
            res.Text = text;
            res.Height = 50;
            res.AutoSize = false;
            res.BorderStyle = BorderStyle.FixedSingle;
            
            return res;

        }
        
        private Button buildButton(int titleWidth, string text, int id)
        {

            Button res = new Button();
            //res.Click += Button_Click;
            res.Text = text;
            res.Parent = this;
            res.Width = titleWidth;
            res.AutoSize = false;
            res.Click += Res_Click;
            res.Name = $"ButtonOpenProj_{id}";
            
            return res;

        }

        private List<ClustProject> prepareList(List<Project> list)
        {

            List<ClustProject> res = new List<ClustProject>();

            for(int i = 0; i < list.Count; i++)
            {

                int count = (from t in res where t.name.Equals(list[i].name) select t).Count();

                if (count == 0)
                {

                    ClustProject proj = new ClustProject();
                    proj.name = list[i].name;
                    proj.teacher = list[i].teacher;

                    res.Add(proj);

                }

                int index = res.IndexOf(res.Single(t => t.name.Equals(list[i].name)));

                res[index].container.Add(list[i]);

            }

            return res;

        }

        private void fillRowEmpty(int countOfRows)
        {

            for (int i = 0; i < countOfRows; i++)
            {

                Label l = new Label();

                l = buildLabel(LblSectionF.Width, " ");
                l.Location = new Point(LblSectionF.Location.X, LblSectionF.Location.Y + LblSectionF.Height + i * l.Height);
                l.BackColor = LblSectionF.BackColor;

                l = buildLabel(LblSectionS.Width, " ");
                l.Location = new Point(LblSectionS.Location.X, LblSectionS.Location.Y + LblSectionS.Height + i * l.Height);
                l.BackColor = LblSectionS.BackColor;

                l = buildLabel(LblSectionT.Width, " ");
                l.Location = new Point(LblSectionT.Location.X, LblSectionT.Location.Y + LblSectionT.Height + i * l.Height);
                l.BackColor = LblSectionT.BackColor;

                l = buildLabel(LblSectionC.Width, " ");
                l.Location = new Point(LblSectionC.Location.X, LblSectionC.Location.Y + LblSectionC.Height + i * l.Height);
                l.BackColor = LblSectionC.BackColor;

            }

        }

        private void fillRowNames(string name, string teacher, int index)
        {

            Label l = new Label();

            l = buildLabel(LblDiscipline.Width, name);
            l.Location = new Point(LblDiscipline.Location.X, LblDiscipline.Location.Y + LblDiscipline.Height + index * l.Height);

            l = buildLabel(LblTeacher.Width, teacher);
            l.Location = new Point(LblTeacher.Location.X, LblTeacher.Location.Y + LblTeacher.Height + index * l.Height);

        }

        private List<Project> formData(int userId)
        {

            string query = $@"

                select 

                isp.descr as descr, 
                isp.deadline as deadline,
                iste.name as teacher,
                isd.name as discipline,
                isd.id as discipline_id,
                isp.fl_completed as complete

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

            List<Project> listOfProj = new List<Project>();

            while (reader.Read())
            {

                string t = reader["teacher"].ToString();
                if (string.IsNullOrEmpty(t)) { t = "*Преподаватель не указан*"; }

                Project d = new Project()
                {

                    name = reader["discipline"].ToString(),
                    descr = reader["descr"].ToString(),
                    date = (DateTime)reader["deadline"],
                    teacher = t,
                    disciplineId = int.Parse(reader["discipline_id"].ToString()),
                    isCompleted = bool.Parse(reader["complete"].ToString())

                };

                listOfProj.Add(d);

            }

            conn.Close();

            return listOfProj;

        }

        private List<Project> filterProjectsByRule(List<Project> list, GroupingRule rule)
        {

            List<Project> result = new List<Project>();

            if(rule == GroupingRule.Completed)
            {

                result = (from t in list where t.isCompleted select t).ToList();

            }
            else if(rule == GroupingRule.Bottom)
            {

                result = (from t in list where (t.date - DateTime.Now).Days < 14 select t).ToList();

            }
            else if(rule == GroupingRule.Middle)
            {

                result = (from t in list where (t.date - DateTime.Now).Days >= 14 && (t.date - DateTime.Now).Days <= 28 select t).ToList();

            }
            else if(rule == GroupingRule.Top)
            {

                result = (from t in list where (t.date - DateTime.Now).Days > 28 select t).ToList();

            }

            return result;

        }
        
        private Label getParent(GroupingRule rule)
        {

            if (rule == GroupingRule.Top) { return LblSectionT; }
            else if (rule == GroupingRule.Middle) { return LblSectionS; }
            else if (rule == GroupingRule.Bottom) { return LblSectionF; }
            else { return LblSectionC; }

        }

        //private void fillCellInRow(List<Project> list, Label parent, int row)
        //{

        //    for(int i = 0; i < list.Count; i++)
        //    {

        //        Button b = buildButton(parent.Width, list[i].type + "\n" + list[i].descr, list[i].disciplineId);
        //        b.Height = 35;
        //        b.Width = 35;
        //        b.Location = new Point(parent.Location.X + i * b.Width + 5, parent.Location.Y + parent.Height + row * 50  + 5);
        //        b.BringToFront();

        //    }

        //}

        private void buildTable(int userId)
        {

            //List<Project> listOfProj = formData(userId);

            //List<ClustProject> prepared = prepareList(listOfProj);

            //fillRowEmpty(prepared.Count);

            //for (int i = 0; i < prepared.Count; i++)
            //{

                //fillRowNames(prepared[i].name, prepared[i].teacher, i);

                //List<Project> sectionF = filterProjectsByRule(prepared[i].container, GroupingRule.Bottom);
                //List<Project> sectionS = filterProjectsByRule(prepared[i].container, GroupingRule.Middle);
                //List<Project> sectionT = filterProjectsByRule(prepared[i].container, GroupingRule.Top);
                //List<Project> sectionC = filterProjectsByRule(prepared[i].container, GroupingRule.Completed);

                //fillCellInRow(sectionF, getParent(GroupingRule.Bottom), i);
                //fillCellInRow(sectionS, getParent(GroupingRule.Middle), i);
                //fillCellInRow(sectionT, getParent(GroupingRule.Top), i);
                //fillCellInRow(sectionC, getParent(GroupingRule.Completed), i);

            //}






        }

        private void Res_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonOpenProj_", string.Empty));

            string query = $"select * from is_discipline where id = {id}";

            MySqlConnection conn = DBUtils.getConnection();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                //todo: open step
                break;

            }

            conn.Close();

        }

        private enum GroupingRule
        {


            Bottom,
            Middle,
            Top,
            Completed

        }

    }

}
