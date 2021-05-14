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
    public partial class TeacherPerfomance : Form
    {
        public TeacherPerfomance()
        {

            InitializeComponent();

            Utils.bind(Groups, "is_group", "name");
            Utils.bind(Disciplines, "is_discipline", "name");

            Chart1.Series.Add("Не оценено");
            Chart1.Series.Add("2");
            Chart1.Series.Add("3");
            Chart1.Series.Add("4");
            Chart1.Series.Add("5");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string group = Groups.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();

            if(Groups.SelectedIndex == -1 || Disciplines.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            Chart1.Series.Clear();
            Chart1.Series.Add("Не оценено");
            Chart1.Series.Add("2");
            Chart1.Series.Add("3");
            Chart1.Series.Add("4");
            Chart1.Series.Add("5");

            string query = $@"

                select isp.* from is_project isp

                join is_user isu on isu.id = isp.student_Id

                where isp.fl_unique = 0 
                and isu.group_id = (select id from is_group where name = '{group}')
                and isp.discipline_id = (select id from is_discipline where name = '{discipline}')
                

            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<int> arr = new List<int>() { 0, 0, 0, 0, 0 };

            while (reader.Read())
            {

                string score = reader["score"].ToString();

                if (string.IsNullOrEmpty(score)) { score = "1"; }

                int indx = int.Parse(score);

                arr[indx - 1]++;

            }

            for(int i = 0; i < arr.Count; i++)
            {

                Chart1.Series[i].Points.Add(arr[i]);

            }

            connection.Close();

        }

    }

}
