using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{
    public partial class Layout3 : Form
    {
        public Layout3()
        {

            InitializeComponent();

        }

        public Layout3(Tuple<Role, int> role, string title)
        {

            InitializeComponent();
            this.Text = title;
            this.role = role;

        }
        private Tuple<Role, int> role { get; set; }

        private void submit_Click(object sender, EventArgs e)
        {

            submit.Enabled = false;

            string name = this.Text;
            string txt = Survey.Text;

            if (string.IsNullOrEmpty(txt))
            {

                MessageBox.Show("Проверьте правильность данных");

                submit.Enabled = true;

                return;

            }

            string query = $@"

                insert into is_survey(name, result, date, group_id) values
                (
                '{name}',
                '{txt}',
                CURRENT_TIMESTAMP,
                (select group_id from is_user where id = {this.role.Item2})
                )

            ";

            DBUtils.execQuery(query);

            MessageBox.Show("Отправлено");

            this.Close();

        }

    }

}
