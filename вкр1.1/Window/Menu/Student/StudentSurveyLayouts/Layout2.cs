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

        }
        private Tuple<Role, int> role { get; set; }

        private RadioButton getSelectedInGroup(Panel panel)
        {

            RadioButton rb = new RadioButton();

            for(int i = 0; i < panel.Controls.Count; i++)
            {

                RadioButton temp = (RadioButton)panel.Controls[i];

                if (temp.Checked) { rb = temp; break; }

            }

            return rb;

        }

        private void submit_Click(object sender, EventArgs e)
        {

            submit.Enabled = false;

            string name = this.Text;

            int value1 = question1.Controls.IndexOf(getSelectedInGroup(question1));
            int value2 = question2.Controls.IndexOf(getSelectedInGroup(question2));
            int value3 = question3.Controls.IndexOf(getSelectedInGroup(question3));
            int value4 = question4.Controls.IndexOf(getSelectedInGroup(question4));
            int value5 = question5.Controls.IndexOf(getSelectedInGroup(question5));
            int value6 = question6.Controls.IndexOf(getSelectedInGroup(question6));
            int value7 = question7.Controls.IndexOf(getSelectedInGroup(question7));
            int value8 = question8.Controls.IndexOf(getSelectedInGroup(question8));
            int value9 = question9.Controls.IndexOf(getSelectedInGroup(question9));
            int value10 = question10.Controls.IndexOf(getSelectedInGroup(question10));
            int value11 = question11.Controls.IndexOf(getSelectedInGroup(question11));
            int value12 = question12.Controls.IndexOf(getSelectedInGroup(question12));
            int value13 = question13.Controls.IndexOf(getSelectedInGroup(question13));
            int value14 = question14.Controls.IndexOf(getSelectedInGroup(question14));

            string values = $"{value1},{value2},{value3},{value4},{value5},{value6},{value7},{value8},{value9},{value10},{value11},{value12},{value13},{value14}";

            string query = $@"

                insert into is_survey(name, result, date, fl_array, group_id) values
                (
                '{name}',
                '{values}',
                CURRENT_TIMESTAMP,
                1,
                (select group_id from is_user where id = {this.role.Item2})
                )

            ";

            DBUtils.execQuery(query);

            MessageBox.Show("Отправлено");

            this.Close();

        }

    }

}
