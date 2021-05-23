using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{
    public partial class Layout2 : Form
    {
        public Layout2()
        {

            InitializeComponent();

        }

        public Layout2(Tuple<Role, int> role, string title)
        {

            InitializeComponent();
            this.Text = title;
            this.role = role;
            Utils.bind(comboBox1, "is_discipline", "name");

        }
        private Tuple<Role, int> role { get; set; }

        private int getSelectedInGroup(Panel panel)
        {

            int indx = -1;

            int curr = 0;

            for(int i = 0; i < panel.Controls.Count; i++)
            {

                try
                {

                    RadioButton temp = (RadioButton)panel.Controls[i];

                    if (temp.Checked) { indx = curr; break; }

                    curr++;

                }
                catch (InvalidCastException) { }

            }

            return indx;

        }

        private void submit_Click(object sender, EventArgs e)
        {

            if(comboBox1.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            submit.Enabled = false;

            string name = this.Text;

            string discipline = comboBox1.SelectedItem.ToString();

            int value1 = 6 - getSelectedInGroup(question1);
            int value2 = 6 - getSelectedInGroup(question2);
            int value3 = 6 - getSelectedInGroup(question3);
            int value4 = 6 - getSelectedInGroup(question4);
            int value5 = 6 - getSelectedInGroup(question5);
            int value6 = 6 - getSelectedInGroup(question6);
            int value7 = 6 - getSelectedInGroup(question7);
            int value8 = 6 - getSelectedInGroup(question8);
            int value9 = 6 - getSelectedInGroup(question9);
            int value10 = 6 - getSelectedInGroup(question10);
            int value11 = 6 - getSelectedInGroup(question11);
            int value12 = 6 - getSelectedInGroup(question12);
            int value13 = 6 - getSelectedInGroup(question13);
            int value14 = 6 - getSelectedInGroup(question14);

            string values = $"{value1},{value2},{value3},{value4},{value5},{value6},{value7},{value8},{value9},{value10},{value11},{value12},{value13},{value14}";

            string query = $@"

                insert into is_survey(name, result, date, fl_array, group_id, discipline_id) values
                (
                '{name}',
                '{values}',
                CURRENT_TIMESTAMP,
                1,
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

            Utils.bind(Deadline, "deadline", $@"select * from is_survey_deadline 

                where 
                group_id = (select group_id from is_user where id = {role.Item2}) 
                and discipline_id = (select id from is_discipline where name = '{comboBox1.SelectedItem}')
                and name = '{this.Text}'

            ");

            if (string.IsNullOrEmpty(Deadline.Text)) { Deadline.Text = "Срок сдачи не установлен"; }
            else { Deadline.Text = Deadline.Text.Replace("0:00:00", string.Empty); }

        }
    }

}
