using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{
    public partial class AdminTeachersList : Form
    {

        public AdminTeachersList()
        {

            InitializeComponent();

            buildList();

        }

        private void buildList()
        {

            Table.SuspendLayout();

            Utils.initTable(Table, new string[] { "Преподаватель", "Логин", " ", " " });

            string query = $@"

                select isu.name, isu.login, isu.id from is_user isu

                where role_id = 1

            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 0;

            while (reader.Read())
            {

                string n = reader["name"].ToString();
                string l = reader["login"].ToString();
                string id = reader["id"].ToString();

                Label name = Utils.buildLabel(l, row.ToString());
                Label login = Utils.buildLabel(l, row.ToString());

                Button edit = Utils.buildButton("Редактировать", $"ButtonEdit_{id}");
                Button remove = Utils.buildButton("Удалить", $"ButtonDelete_{id}");

                edit.Click += Edit_Click;
                remove.Click += Delete_Click;

                Utils.fillRow(Table, new Control[] { name, login, edit, remove }, row + 1);

                row++;

            }

            conn.Close();

            Table.ResumeLayout();

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonEdit_", string.Empty));

            _edit_AdminTeachersList dialog = new _edit_AdminTeachersList(id);

            dialog.ShowDialog();

            buildList();

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonDelete_", string.Empty));

            DBUtils.removeTeacherById(id);

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

            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(name))
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            DBUtils.addUser(name, login, pass, Role.Teacher);

            buildList();

        }

    }

}
