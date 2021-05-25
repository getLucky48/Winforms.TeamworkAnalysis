using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormInfSys.Class;
using System.Linq;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{

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

            studAll = new List<Tuple<int, string, string>>();
            groupNew = new List<Tuple<int, string, string>>();

            Utils.fillRow(Table, new Control[] {
                new Label(){Text = "ФИО", AutoSize = true },
                new Label(){Text = "Роль", AutoSize = true },
                new Label(){Text = "Бригада", AutoSize = true },
                new Label(){Text = " ", AutoSize = true }
            }, 0);

        }

        private int currentNum { get; set; }

        private List<Tuple<int, string, string>> studAll { get; set; }
        private List<Tuple<int, string, string>> groupNew { get; set; }

        private List<Tuple<string, string, string, string>> _getFirst(List<Tuple<string, string, string, string>> list)
        {

            List<Tuple<string, string, string, string>> result = new List<Tuple<string, string, string, string>>();

            for(int i = 0; i < list.Count; i++)
            {

                if (list[i].Item2.Contains("Исследователь")) { result.Add(list[i]); }
                if (list[i].Item2.Contains("Координатор")) { result.Add(list[i]); }
                if (list[i].Item2.Contains("Творец")) { result.Add(list[i]); }

            }

            if (result.Count != 0) { return result; }

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].Item3.Contains("Исследователь")) { result.Add(list[i]); }
                if (list[i].Item3.Contains("Координатор")) { result.Add(list[i]); }
                if (list[i].Item3.Contains("Творец")) { result.Add(list[i]); }

            }

            if (result.Count != 0) { return result; }

            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].Item4.Contains("Исследователь")) { result.Add(list[i]); }
                if (list[i].Item4.Contains("Координатор")) { result.Add(list[i]); }
                if (list[i].Item4.Contains("Творец")) { result.Add(list[i]); }

            }

            return result;

        }

        private List<Tuple<string, string, string, string>> _getSecond(List<Tuple<string, string, string, string>> all, Tuple<string, string, string, string> leader)
        {

            List<Tuple<string, string, string, string>> result = new List<Tuple<string, string, string, string>>();

            for (int i = 0; i < all.Count; i++)
            {

                if (!leader.Item2.Contains(all[i].Item2)
                && !leader.Item3.Contains(all[i].Item3)
                && !leader.Item4.Contains(all[i].Item4)) { result.Add(all[i]); }

            }

            //if (result.Count != 0) { return result; }

            //for (int i = 0; i < all.Count; i++)
            //{

            //    if (!leader.Item2.Contains(all[i].Item2)
            //    && !leader.Item3.Contains(all[i].Item3)) { result.Add(all[i]); }

            //}

            //if (result.Count != 0) { return result; }
            //for (int i = 0; i < all.Count; i++)
            //{

            //    if (!leader.Item2.Contains(all[i].Item2)
            //    && !leader.Item4.Contains(all[i].Item4)) { result.Add(all[i]); }

            //}

            //if (result.Count != 0) { return result; }

            //for (int i = 0; i < all.Count; i++)
            //{

            //    if (!leader.Item3.Contains(all[i].Item3)
            //    && !leader.Item4.Contains(all[i].Item4)) { result.Add(all[i]); }

            //}

            //if (result.Count != 0) { return result; }


            return result;

        }

        private void buildRecommend()
        {

            Dictionary<string, int> roles = new Dictionary<string, int>() {
                { "Координатор", 0 },
                { "Творец", 0 },
                { "Генератор идей", 0 },
                { "Оценщик", 0 },
                { "Исполнитель", 0 },
                { "Исследователь", 0 },
                { "Коллективист", 0 },
                { "Реализатор", 0 }
            };

            string groupName = GroupList.SelectedItem.ToString();

            string query = $@"

                select 

                isu.id as id,
                isu.name as name,
                istr.result as roles,
                (select num from is_team where user_id = isu.id limit 1) as num,
                (select leader from is_team where user_id = isu.id limit 1) as leader
      
                from is_user isu

                join is_group isg on isg.id = isu.group_id
                left join is_testresult istr on istr.user_Id = isu.id
    

                where isg.name = '{groupName}'

                order by num, name, roles

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<Tuple<int, string, string>> students = new List<Tuple<int, string, string>>();

            int row = 0;
            while (reader.Read())
            {

                roles = JsonConvert.DeserializeObject<Dictionary<string, int>>(reader["roles"].ToString());

                string name = reader["name"].ToString();
                string num = reader["num"].ToString();
                string leader = reader["leader"].ToString();

                string roleByBelbin = string.Empty;

                if (roles == null || roles.Count == 0) { roleByBelbin = "*Тест не пройден*"; }
                else
                {

                    var sorted = from t in roles orderby t.Value descending select t;

                    roleByBelbin = $"{sorted.ElementAt(0).Key},{sorted.ElementAt(1).Key},{sorted.ElementAt(2).Key}";

                }

                students.Add(new Tuple<int, string, string>(int.Parse(reader["id"].ToString()), name, roleByBelbin));

            }

            connection.Close();



            Recommendation.Text = "";
            //name  role1   role2   role3
            List<Tuple<string, string, string, string>> list = new List<Tuple<string, string, string, string>>();
          
            for(int i = 0; i < students.Count; i++)
            {

                if(students[i].Item3.Contains("*Тест не пройден*")) { continue; }

                string name = students[i].Item2;
                string[] rols = students[i].Item3.Split(new char[] { ',' });

                list.Add(new Tuple<string, string, string, string>(name, rols[0], rols[1], rols[2]));

            }




            if(list.Count < 3) { return; }

            List<Tuple<string, string, string, string>> first = _getFirst(list);

            if(first.Count == 0) { return; }

            string res = "";
            for(int i = 0; i < first.Count; i++)
            {

                List<Tuple<string, string, string, string>> second = _getSecond(list, first[i]);

                for(int j = 0; j < second.Count; j++)
                {

                    List<Tuple<string, string, string, string>> third = _getSecond(list, second[j]);

                    for(int k = 0; k < third.Count; k++)
                    {

                        if(first[i].Item2 == third[k].Item2 && first[i].Item3 == third[k].Item3 && first[i].Item4 == third[k].Item4) { continue; }

                        res += $"{first[i].Item1} | {first[i].Item2} {first[i].Item3} {first[i].Item4} \n";
                        res += $"{second[j].Item1} | {second[j].Item2} {second[j].Item3} {second[j].Item4} \n";
                        res += $"{third[k].Item1} | {third[k].Item2} {third[k].Item3} {third[k].Item4} \n";

                        res += "\n\n";

                    }

                }

            }

            Recommendation.Text = res;

        }

        private void buildLists()
        {

            Table.SuspendLayout();

            StudentsCount.Text = " ";

            this.currentNum = -1;

            //Utils.initTable(Table, new string[] { "ФИО", "Роль", "Бригада", " " });

            Table.Controls.Clear();
            Utils.fillRow(Table, new Control[] {
                new Label(){Text = "ФИО", AutoSize = true },
                new Label(){Text = "Роль", AutoSize = true },
                new Label(){Text = "Бригада", AutoSize = true },
                new Label(){Text = " ", AutoSize = true }
            } , 0);

            studAll.Clear();
            groupNew.Clear();

            AllStudents.Items.Clear();
            NewTeam.Items.Clear();
            Leader.Items.Clear();

            Dictionary<string, int> roles = new Dictionary<string, int>() {
                { "Координатор", 0 },
                { "Творец", 0 },
                { "Генератор идей", 0 },
                { "Оценщик", 0 },
                { "Исполнитель", 0 },
                { "Исследователь", 0 },
                { "Коллективист", 0 },
                { "Реализатор", 0 }
            };

        
            string groupName = GroupList.SelectedItem.ToString();

            string query = $@"

                select 

                isu.id as id,
                isu.name as name,
                istr.result as roles,
                (select num from is_team where user_id = isu.id limit 1) as num,
                (select leader from is_team where user_id = isu.id limit 1) as leader
      
                from is_user isu

                join is_group isg on isg.id = isu.group_id
                left join is_testresult istr on istr.user_Id = isu.id
    

                where isg.name = '{groupName}'

                order by num, name, roles

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 0;
            while (reader.Read())
            {

                roles = JsonConvert.DeserializeObject<Dictionary<string, int>>(reader["roles"].ToString());

                string name = reader["name"].ToString();
                string num = reader["num"].ToString();
                string leader = reader["leader"].ToString();

                string roleByBelbin = string.Empty;

                if (roles == null || roles.Count == 0) { roleByBelbin = "*Тест не пройден*"; }
                else
                {

                    var sorted = from t in roles orderby t.Value descending select t;

                    roleByBelbin = $"{sorted.ElementAt(0).Key},{sorted.ElementAt(1).Key},{sorted.ElementAt(2).Key}";

                }


                if (string.IsNullOrEmpty(leader)) { leader = " "; }


                if (!string.IsNullOrEmpty(num))
                {

                    Label lblName = Utils.buildLabel(name, row.ToString());
                    Label lblRole = Utils.buildLabel(roleByBelbin, row.ToString());
                    Label lblNum = Utils.buildLabel(num, row.ToString());
                    Label lblLeader = Utils.buildLabel(leader.Equals("1") ? "Лидер" : " ", row.ToString());

                    int tNum = -1;
                    int.TryParse(num, out tNum);

                    if (tNum > this.currentNum) { this.currentNum = tNum; }

                    Utils.fillRow(Table, new Control[] { lblName, lblRole, lblNum, lblLeader }, row + 1);

                    row++;

                    continue;

                }

                studAll.Add(new Tuple<int, string, string>( int.Parse(reader["id"].ToString()), name, roleByBelbin) );

            }

            connection.Close();

            for(int i = 0; i < studAll.Count; i++)
            {

                AllStudents.Items.Add($"{studAll[i].Item2} {studAll[i].Item3}");

            }

            Table.ResumeLayout();

            StudentsCount.Text = $"Число нераспределенных студентов: {studAll.Count}";

            buildRecommend();

        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {

            buildLists();

        }

        private void ToRight_Click(object sender, EventArgs e)
        {

            object sel = AllStudents.SelectedItem;

            if (sel == null) { return; }

            int indx = AllStudents.Items.IndexOf(sel);

            Tuple<int, string, string> target = studAll[indx];
            studAll.RemoveAt(indx);
            groupNew.Add(target);

            AllStudents.Items.Remove(sel);
            NewTeam.Items.Add(sel);
            Leader.Items.Add(sel);

            StudentsCount.Text = $"Число нераспределенных студентов: {studAll.Count}";

        }

        private void ToLeft_Click(object sender, EventArgs e)
        {

            object sel = NewTeam.SelectedItem;

            if (sel == null) { return; }

            int indx = NewTeam.Items.IndexOf(sel);

            Tuple<int, string, string> target = groupNew[indx];
            groupNew.RemoveAt(indx);
            studAll.Add(target);

            NewTeam.Items.Remove(sel);
            AllStudents.Items.Add(sel);
            Leader.Items.Remove(sel);

            StudentsCount.Text = $"Число нераспределенных студентов: {studAll.Count}";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (DisciplinesList.SelectedIndex == -1 || GroupList.SelectedIndex == -1 || NewTeam.Items.Count < 1 || Leader.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            string select = $@"

                    select
                    * 
                    from is_project isp

                    where isp.discipline_id = (select id from is_discipline where name = '{DisciplinesList.SelectedItem}') and isp.fl_unique = 1

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
                        { (string.IsNullOrEmpty(reader["deadline"].ToString()) ? "null" : $"CAST('{(DateTime)reader["deadline"]:yyyyMMdd}' as date)") }
                        ,
                        '{reader["descr"]}',
                        0,
                        '{reader["token"]}',
                        '{reader["name"]}'
    
                    );

                    insert into is_team(designation, num, leader, user_id, project_id)
                    values('{guid}', '{(this.currentNum > 0 ? this.currentNum + 1 : 1)}', @isLeader, '@studentId', '{reader["id"]}');


                ";

            }

            connection.Close();

            string query = string.Empty;

            int leadIndx = Leader.SelectedIndex;

            for (int i = 0; i < groupNew.Count; i++)
            {

                int userId = groupNew[i].Item1;

                query += insert.Replace("@studentId", userId.ToString()).Replace("@isLeader", i == leadIndx ? "1" : "0");

            }

            if (string.IsNullOrEmpty(query)) {

                MessageBox.Show("Не удалось добавить команду: отсутствуют проекты");

                return;

            }

            DBUtils.execQuery(query);

            buildLists();

            buildRecommend();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<Tuple<string, string, string, string>> list = new List<Tuple<string, string, string, string>>();

            for (int i = 0; i < studAll.Count; i++)
            {

                if (studAll[i].Item3.Contains("*Тест не пройден*")) { continue; }

                string name = studAll[i].Item2;
                string[] roles = studAll[i].Item3.Split(new char[] { ',' });

                list.Add(new Tuple<string, string, string, string>(name, roles[0], roles[1], roles[2]));

            }

            if (list.Count < 3) {

                while (NewTeam.Items.Count != 0)
                {

                    NewTeam.SelectedIndex = 0;
                    ToLeft_Click(sender, e);

                }

                for (int i = 0; i < 3 && i < AllStudents.Items.Count; i++)
                {

                    AllStudents.SelectedIndex = 0;

                    ToRight_Click(sender, e);

                    if (i == 0)
                    {

                        Leader.SelectedIndex = 0;

                    }

                }

                buildRecommend();
                
                return;
            }

            List<Tuple<string, string, string, string>> first = _getFirst(list);

            if (first.Count == 0) {

                while (NewTeam.Items.Count != 0)
                {

                    NewTeam.SelectedIndex = 0;
                    ToLeft_Click(sender, e);

                }

                for (int i = 0; i < 3 && i < AllStudents.Items.Count; i++)
                {

                    AllStudents.SelectedIndex = 0;

                    ToRight_Click(sender, e);

                    if (i == 0)
                    {

                        Leader.SelectedIndex = 0;

                    }

                }

                buildRecommend();

                return;

            }

            bool isFormed = false;

            List<string> names = new List<string>();

            for (int i = 0; i < first.Count; i++)
            {

                if (isFormed) { break; }

                List<Tuple<string, string, string, string>> second = _getSecond(list, first[i]);

                for (int j = 0; j < second.Count; j++)
                {

                    if (isFormed) { break; }

                    List<Tuple<string, string, string, string>> third = _getSecond(list, second[j]);

                    for (int k = 0; k < third.Count; k++)
                    {

                        if (first[i].Item2 == third[k].Item2 && first[i].Item3 == third[k].Item3 && first[i].Item4 == third[k].Item4) { continue; }

                        names.Add(first[i].Item1);
                        names.Add(second[j].Item1);
                        names.Add(third[k].Item1);

                        isFormed = true;

                        break;

                    }

                }

            }
            

            while(NewTeam.Items.Count != 0)
            {

                NewTeam.SelectedIndex = 0;
                ToLeft_Click(sender, e);

            }

            if(names.Count == 3)
            {

                for (int i = 0; i < names.Count; i++)
                {

                    int indx = AllStudents.FindString(names[i]);

                    AllStudents.SelectedIndex = indx;

                    ToRight_Click(sender, e);

                    if (i == 0)
                    {

                        Leader.SelectedIndex = 0;

                    }

                }
            }

            buildRecommend();

        }

    }

}