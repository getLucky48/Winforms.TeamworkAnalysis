using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{
    public partial class _edit_AdminTeachersList : Form
    {
        public _edit_AdminTeachersList()
        {
            InitializeComponent();
        }
    
        public _edit_AdminTeachersList(int user_id)
        {

            InitializeComponent();

            this.user_id = user_id;

            string select = $"select login, name from is_user where id = '{user_id}'";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(select, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Login.Text = reader["login"].ToString();
                Fio.Text = reader["name"].ToString();

                break;

            }

            conn.Close();

        }

        private int user_id { get; set; }

        private void Create_Click(object sender, EventArgs e)
        {

            string login = Login.Text;
            string pass = Password.Text;
            string name = Fio.Text;

            if (DBUtils.userIsExists(login, user_id))
            {

                MessageBox.Show("Пользователь с таким логином уже существует");

                return;

            }

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(name))
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            string passHash = DBUtils.getHash(pass);

            string query = $"UPDATE is_user SET login = '{login}', name = '{name}', password = '{passHash}' WHERE id = '{user_id}'";

            DBUtils.execQuery(query);

            this.Close();

        }

    }

}
