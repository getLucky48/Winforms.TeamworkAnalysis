using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{
    public partial class AdminGroupsList : Form
    {

        public AdminGroupsList()
        {

            InitializeComponent();

            Utils.bind(FacultyList, "is_faculty", "name");
            Utils.bind(CourseList, "is_course", "name");

            buildList();

        }

        private void buildList()
        {

            Table.SuspendLayout();

            Utils.initTable(Table, new string[] { "Факультет", "Название", "Курс", " ", " " });

            string query = $@"

                select 

                isg.id,
                isg.name as groupname,
                isc.name as course,
                isf.name as faculty

                from is_group isg

                join is_course isc on isc.id = isg.course_id
                join is_faculty isf on isf.id = isg.faculty_id

            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 0;

            while (reader.Read())
            {

                string id = reader["id"].ToString();
                string f = reader["faculty"].ToString();
                string g = reader["groupname"].ToString();
                string c = reader["course"].ToString();

                Label faculty = Utils.buildLabel(f, row.ToString());
                Label groupname = Utils.buildLabel(g, row.ToString());
                Label course = Utils.buildLabel(c, row.ToString());

                Button edit = Utils.buildButton("Редактировать", $"ButtonEdit_{id}");
                Button remove = Utils.buildButton("Удалить", $"ButtonDelete_{id}");

                edit.Click += Edit_Click;
                remove.Click += Delete_Click;

                Utils.fillRow(Table, new Control[] { faculty, groupname, course, edit, remove }, row + 1);

                row++;

            }

            conn.Close();

            Table.ResumeLayout();

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonEdit_", string.Empty));

            _edit_AdminGroupsList dialog = new _edit_AdminGroupsList(id);

            dialog.ShowDialog();

            buildList();

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonDelete_", string.Empty));

            string query = $@"

                           
                            update is_user SET group_id = null where group_id = {id};
                            delete from is_group where id = {id};

                            ";

            DBUtils.execQuery(query);

            buildList();

        }

        private void addGroup(string name, string faculty, string course)
        {
                       
            string query = $@"insert into is_group(name, faculty_id, course_id) 

                            values(
                                '{name}',
                                (select id from is_faculty where name = '{faculty}' limit 1),
                                (select id from is_course where name = '{course}' limit 1)
                            )

                            ";

            DBUtils.execQuery(query);

        }

        private void Create_Click(object sender, EventArgs e)
        {

            string name = GroupName.Text;



            if (DBUtils.groupIsExists(name))
            {

                MessageBox.Show("Группа с таким названием уже существует");

                return;

            }

            if (string.IsNullOrWhiteSpace(name) || FacultyList.SelectedIndex == -1 || CourseList.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            addGroup(name, FacultyList.SelectedItem.ToString(), CourseList.SelectedItem.ToString());

            buildList();

        }

    }

}
