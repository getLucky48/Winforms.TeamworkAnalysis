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

        }

        private void formLists(string groupName)
        {

            Complete.Items.Clear();
            Uncomplete.Items.Clear();

            string query = $@"

                        select 

                        isu.name,
                        isu.id,
                        concat(istr.rolebybelbin, ' ', istr.rolebybelbin_s, ' ', istr.rolebybelbin_t ) as role

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

                if (string.IsNullOrEmpty(reader["role"].ToString())) { Uncomplete.Items.Add(reader["name"].ToString());  }
                else { Complete.Items.Add($"{reader["name"]} [{reader["role"]}]"); }

            }

            conn.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            formLists(GroupList.SelectedItem.ToString());

        }
    }
}
