using System;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{
    public partial class _edit_AdminStudentsList : Form
    {
        public _edit_AdminStudentsList()
        {
            InitializeComponent();
        }
    
        public _edit_AdminStudentsList(int user_id)
        {

            InitializeComponent();

            this.user_id = user_id;

            string select = $"select login, name from is_user where id = '{user_id}'";

            Utils.bind(GroupList, "is_group", "name");
            Utils.selectItem(GroupList, "is_user", "group_id", "is_group", "id", "name", this.user_id);

            Utils.bind(Login, "login", select);
            Utils.bind(Fio, "name", select);

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

            string group = GroupList.SelectedItem.ToString();

            string query = $@"

                            UPDATE is_user SET 

                            login = '{login}', 
                            name = '{name}',
                            password = '{passHash}',
                            group_id = (select id from is_group where name = '{group}' limit 1)

                            WHERE id = '{user_id}'

                            ";

            DBUtils.execQuery(query);

            this.Close();

        }

    }

}
