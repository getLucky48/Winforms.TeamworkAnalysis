using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys
{
    public partial class Auth : Form
    {

        public Auth()
        {

            InitializeComponent();
            
        }

        private Tuple<Role, int> verifOfAuth(string login, string pass)
        {

            string passHash = DBUtils.getHash(pass);

            string query = $@"

                    select 

                    isr.id as role_id,
                    isu.id as user_id

                    from is_user isu 

                    join is_role isr on isr.id = isu.role_id 

                    where login = '{login}' and password = '{passHash}'

                    ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            Role role = Role.NonAuthorized;

            int user_id = -1;

            while (reader.Read())
            {

                string id = reader["role_id"].ToString();

                user_id = Int32.Parse(reader["user_id"].ToString());

                if (id.Equals("1")) { role = Role.Teacher; }
                else if (id.Equals("2")) { role = Role.Student; }
                else { role = Role.NonAuthorized; }

                break;

            }

            conn.Close();

            return new Tuple<Role, int>(role, user_id);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BtnAuth.Enabled = false;

            string login = Login.Text;
            string pass = Password.Text;

            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(pass))
            {

                MessageBox.Show("Проверьте правильность данных");

                BtnAuth.Enabled = true;

                return;

            }

            Tuple<Role, int> roleByAuth = verifOfAuth(login, pass);

            if (roleByAuth.Item1 == Role.NonAuthorized)
            {

                MessageBox.Show("Неправильный логин или пароль");

                BtnAuth.Enabled = true;

                return;

            }

            BtnAuth.Enabled = true;

            this.Hide();
            Menu menu = new Menu(roleByAuth);
            menu.ShowDialog();
            try { this.Show(); }
            catch (ObjectDisposedException) { };

        }

        public enum Role
        {

            Teacher,
            Student,
            NonAuthorized

        }

    }

}
