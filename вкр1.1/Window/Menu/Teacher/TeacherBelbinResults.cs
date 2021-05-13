using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{
    public partial class TeacherBelbinResults : Form
    {
        public TeacherBelbinResults()
        {

            InitializeComponent();

            Utils.bind(GroupList, "is_group", "name");

            completed = new List<Label>();
            uncompleted = new List<Label>();

        }

        private List<Label> completed { get; set; }
        private List<Label> uncompleted { get; set; }

        private void refreshLists()
        {

            for (int i = 0; i < completed.Count; i++)
            {

                Label l = completed[i];
                l.Parent = Complete;
                l.Location = new Point(0, i * 25);

            }

            for (int i = 0; i < uncompleted.Count; i++)
            {

                Label l = uncompleted[i];
                l.Parent = Uncomplete;
                l.Location = new Point(0, i * 25);

            }

        }

        private Label buildLabel(int parentWidth, string text)
        {

            Label res = new Label();
            res.Width = parentWidth - res.Width - 10 - 20;
            res.Text = text;

            return res;

        }

        private void formLists(string groupName)
        {

            clearLists();

            string query = $@"

                        select 

                        isu.name,
                        isu.id,
                        istr.rolebybelbin as role

                        from is_user isu 

                        left join is_testresult istr on istr.user_Id = isu.id

                        where isu.group_id = (select id from is_group where name = '{groupName}')

                        order by isu.name asc

            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Label l = buildLabel((int)(Complete.Width * 0.85), reader["name"].ToString());

                if (string.IsNullOrEmpty(reader["role"].ToString())) { uncompleted.Add(l);  }
                else {

                    l.Text += $" [{reader["role"]}]";

                    completed.Add(l);
                
                }

            }

            conn.Close();

        }

        private void clearLists()
        {

            Complete.Controls.Clear();
            Uncomplete.Controls.Clear();

            completed = new List<Label>();
            uncompleted = new List<Label>();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            formLists(GroupList.SelectedItem.ToString());
            refreshLists();

        }
    }
}
