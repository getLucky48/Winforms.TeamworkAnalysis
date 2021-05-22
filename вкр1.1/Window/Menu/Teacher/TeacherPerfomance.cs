using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{

    public partial class TeacherPerfomance : Form
    {
        public TeacherPerfomance()
        {

            InitializeComponent();

            comboBox1.Items.Add(2021);

            Utils.bind(Groups, "is_group", "name");
            Utils.bind(Groups2, "is_group", "name");
            Utils.bind(Disciplines, "is_discipline", "name");

            Chart1.Series.Add("Не оценено");
            Chart1.Series.Add("2");
            Chart1.Series.Add("3");
            Chart1.Series.Add("4");
            Chart1.Series.Add("5");

            Chart1.Series.Add("Не оценено ");
            Chart1.Series.Add("2 ");
            Chart1.Series.Add("3 ");
            Chart1.Series.Add("4 ");
            Chart1.Series.Add("5 ");
            //Chart1.Series.Add("Не оценено");
            //Chart1.Series.Add("2");
            //Chart1.Series.Add("3");
            //Chart1.Series.Add("4");
            //Chart1.Series.Add("5");

        }

        private void buildChart(ComboBox groupBox, bool first)
        {

            string group = groupBox.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();

            string query = $@"

                select 

                isu.*, 
                iss.discipline_id as disc_id,
                iss.score as disc_score 

                from is_user isu

                left join is_score iss on iss.student_id = isu.id
				
                where isu.group_id = (select id from is_group where name = '{group}') and iss.discipline_id = (select id from is_discipline where name = '{discipline}')
                
            ";

            int studCount = 0;
            ComboBox cb = new ComboBox();
            Utils.bind(cb, "is_user", "name", true, $"where group_id = (select id from is_group where name = '{group}')");
            studCount = cb.Items.Count;


            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<int> arr = new List<int>() { 0, 0, 0, 0, 0 };

            while (reader.Read())
            {

                string score = reader["disc_score"].ToString();

                if (string.IsNullOrEmpty(score)) { score = "1"; }

                int indx = int.Parse(score);

                arr[indx - 1]++;

                studCount--;

            }

            for (int i = 0; i < arr.Count; i++)
            {
                int indx = first ? i : i + 5;
                Chart1.Series[indx].Points.Add(arr[i]);

            }

            Chart1.Series[first ? 0 : 5].Points.Add(studCount);

            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (Groups.SelectedIndex == -1  || Groups2.SelectedIndex == -1 || Disciplines.SelectedIndex == -1 || comboBox1.SelectedIndex == -1) { return; }

            Chart1.Series.Clear();
            Chart1.Series.Add("Не оценено ");
            Chart1.Series.Add("2 ");
            Chart1.Series.Add("3 ");
            Chart1.Series.Add("4 ");
            Chart1.Series.Add("5 ");

            Chart1.Series.Add("Не оценено");
            Chart1.Series.Add("2");
            Chart1.Series.Add("3");
            Chart1.Series.Add("4");
            Chart1.Series.Add("5");

            buildChart(Groups, true);
            buildChart(Groups2, false);


        }

    }

}
