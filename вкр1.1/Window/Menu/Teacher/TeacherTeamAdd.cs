using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{
    //todo: выбор лидера
    //todo: рекомендации

    public partial class TeacherTeamAdd : Form
    {

        public TeacherTeamAdd()
        {

            InitializeComponent();

            this.currentNum = -1;

        }

        public TeacherTeamAdd(Tuple<Role, int> role)
        {
            InitializeComponent();

            this.currentNum = -1;

            Utils.bind(GroupList, "is_group", "name");
            Utils.bind(DisciplinesList, "is_discipline", "name");

        }

        private int currentNum { get; set; }

        private void buildLists()
        {

            Table.SuspendLayout();

            StudentsCount.Text = " ";

            this.currentNum = -1;

            Utils.initTable(Table, new string[] { "ФИО", "Роль", "Бригада"});

            AllStudents.Items.Clear();
            NewTeam.Items.Clear();
           
            string groupName = GroupList.SelectedItem.ToString();

            string query = $@"

                select 

                isu.id as id,
                isu.name as name,
                istr.rolebybelbin as role,
                (select num from is_team where user_id = isu.id limit 1) as num
      
                from is_user isu

                join is_group isg on isg.id = isu.group_id
                left join is_testresult istr on istr.user_Id = isu.id
    

                where isg.name = '{groupName}'

                order by num, name, role

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 0;
            while (reader.Read())
            {

                string name = reader["name"].ToString();
                string roleByBelbin = reader["role"].ToString();
                string num = reader["num"].ToString();

                if (string.IsNullOrEmpty(roleByBelbin)) { roleByBelbin = "*Тест не пройден*"; }

                if (!string.IsNullOrEmpty(num))
                {

                    Label lblName = Utils.buildLabel(name, row.ToString());
                    Label lblRole = Utils.buildLabel(roleByBelbin, row.ToString());
                    Label lblNum = Utils.buildLabel(num, row.ToString());

                    int tNum = -1;
                    int.TryParse(num, out tNum);

                    if(tNum > this.currentNum) { this.currentNum = tNum; }

                    Utils.fillRow(Table, new Control[] { lblName, lblRole, lblNum }, row + 1);

                    row++;

                    continue;

                }

                AllStudents.Items.Add($"{reader["id"]} | {name}, {roleByBelbin}");

            }

            connection.Close();

            Table.ResumeLayout();

            StudentsCount.Text = $"Число нераспределенных студентов: {AllStudents.Items.Count}";

        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {

            buildLists();

        }

        private void ToRight_Click(object sender, EventArgs e)
        {

            object sel = AllStudents.SelectedItem;

            if(sel == null) { return; }

            AllStudents.Items.Remove(sel);
            NewTeam.Items.Add(sel);

            StudentsCount.Text = $"Число нераспределенных студентов: {AllStudents.Items.Count}";

        }

        private void ToLeft_Click(object sender, EventArgs e)
        {

            object sel = NewTeam.SelectedItem;

            if (sel == null) { return; }

            NewTeam.Items.Remove(sel);
            AllStudents.Items.Add(sel);

            StudentsCount.Text = $"Число нераспределенных студентов: {AllStudents.Items.Count}";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DisciplinesList.SelectedIndex == -1 || GroupList.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }




            string select = $@"

                    select
                    * 
                    from is_project isp



                    where isp.discipline_id = 15 and isp.fl_unique = 1

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(select, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            string insert = string.Empty;

            Guid guid = Guid.NewGuid();

            while (reader.Read())
            {

                insert += $@"

                    insert into is_project( 
                        
                        discipline_id,
                        teacher_id,
                        student_id,
                        deadline,
                        descr,
                        fl_completed,
                        token,
                        name

                    )

                    values(

                        '{reader["discipline_id"]}',
                        '{reader["teacher_id"]}',
                        '@studentId',
                        { (string.IsNullOrEmpty(reader["deadline"].ToString()) ? "null" : $"CAST('{(DateTime)reader["deadline"]:yyyyMMdd}' as date)" ) }
                        ,
                        '{reader["descr"]}',
                        0,
                        '{reader["token"]}',
                        '{reader["name"]}'
    
                    );

                    insert into is_team(designation, num, leader, user_id, project_id)
                    values('{guid}', '{(this.currentNum > 0 ? this.currentNum + 1 : 1)}', 0, '@studentId', '{reader["id"]}');


                ";

            }

            connection.Close();

            string query = string.Empty;

            for(int i = 0; i < NewTeam.Items.Count; i++)
            {

                int indx = NewTeam.Items[i].ToString().IndexOf('|');
                int userId = int.Parse(NewTeam.Items[i].ToString().Substring(0, indx));

                query += insert.Replace("@studentId", userId.ToString());

            }

            if (string.IsNullOrEmpty(query)) { return; }

            DBUtils.execQuery(query);

            buildLists();

        }

    }

}
