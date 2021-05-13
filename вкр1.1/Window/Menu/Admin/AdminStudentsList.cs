using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{
    public partial class AdminStudentsList : Form
    {

        public AdminStudentsList()
        {

            InitializeComponent();

            Utils.bind(GroupList, "is_group", "name");

            buildList();

        }

        private void buildList()
        {

            Table.SuspendLayout();

            Utils.initTable(Table, new string[] { "ФИО", "Факультет", "Группа", "Курс", "Логин", " ", " " });

            string query = $@"

                select isu.name, isu.login, isu.id, isg.name as groupname, isf.name as faculty, isc.name as course from is_user isu

                left join is_group isg on isg.id = isu.group_id
                left join is_faculty isf on isf.id = isg.faculty_id
                left join is_course isc on isc.id = isg.course_id

                where role_id = 2

            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 0;

            while (reader.Read())
            {

                string n = reader["name"].ToString();
                string f = reader["faculty"].ToString();
                string g = reader["groupname"].ToString();
                string c = reader["course"].ToString();
                string l = reader["login"].ToString();
                string id = reader["id"].ToString();
                
                Label name = Utils.buildLabel(n, row.ToString());
                Label faculty = Utils.buildLabel(f, row.ToString());
                Label groupname = Utils.buildLabel(g, row.ToString());
                Label course = Utils.buildLabel(c, row.ToString());
                Label login = Utils.buildLabel(l, row.ToString());

                Button edit = Utils.buildButton("Редактировать", $"ButtonEdit_{id}");
                Button remove = Utils.buildButton("Удалить", $"ButtonDelete_{id}");

                edit.Click += Edit_Click;
                remove.Click += Delete_Click;

                Utils.fillRow(Table, new Control[] { name, faculty, groupname, course, login, edit, remove }, row + 1);

                row++;

            }

            conn.Close();

            Table.ResumeLayout();

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonEdit_", string.Empty));

            _edit_AdminStudentsList dialog = new _edit_AdminStudentsList(id);

            dialog.ShowDialog();

            buildList();

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonDelete_", string.Empty));

            DialogResult dialogResult = MessageBox.Show("При удалении данных о студенте также будут удалены все его проекты. Продолжить?", "Подтверждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) { return; }

            DBUtils.removeStudentById(id);

            buildList();

        }

        private void Create_Click(object sender, EventArgs e)
        {

            string login = Login.Text;
            string pass = Password.Text;
            string name = Fio.Text;

            if (DBUtils.userIsExists(login))
            {

                MessageBox.Show("Пользователь с таким логином уже существует");

                return;

            }

            if (string.IsNullOrWhiteSpace(login) 
                || string.IsNullOrWhiteSpace(pass)
                || string.IsNullOrWhiteSpace(name)
                || GroupList.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            DBUtils.addUser(name, login, pass, GroupList.SelectedItem.ToString(), Role.Student);

            buildList();

        }

    }

}