using Newtonsoft.Json;
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
            Utils.bind(comboBox1, "is_discipline", "name");

        }

        private Tuple<Role, int> role { get; set; }

        private void submit_Click(object sender, EventArgs e)
        {

            submit.Enabled = false;

            string name = this.Text;
            string txt = richTextBox0.Text;
            string txt1 = richTextBox1.Text;
            string txt2 = richTextBox2.Text;
            string txt3 = richTextBox3.Text;

            if (string.IsNullOrEmpty(txt) || comboBox1.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                submit.Enabled = true;

                return;

            }

            string discipline = comboBox1.SelectedItem.ToString();

            string query = $@"

                insert into is_survey(name, result, date, group_id, discipline_id) values
                (
                '{name}',
                '{ JsonConvert.SerializeObject(new string[] { txt, txt1, txt2, txt3 }) }',
                CURRENT_TIMESTAMP,
                (select group_id from is_user where id = {this.role.Item2}),
                (select id from is_discipline where name = '{discipline}')
                )

            ";

            DBUtils.execQuery(query);

            MessageBox.Show("Отправлено");

            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Utils.bind(Deadline, "concat(dt_begin, '-', dt_end)", $@"select * from is_survey_deadline 

                where 
                group_id = (select group_id from is_user where id = {role.Item2}) 
                and discipline_id = (select id from is_discipline where name = '{comboBox1.SelectedItem}')
                and name = '{this.Text}'

            ");

            if (Deadline.Text.Length < 5) { Deadline.Text = "Срок сдачи не установлен"; }
            else { Deadline.Text = Deadline.Text.Replace("0:00:00", string.Empty); }

        }
    }

}
