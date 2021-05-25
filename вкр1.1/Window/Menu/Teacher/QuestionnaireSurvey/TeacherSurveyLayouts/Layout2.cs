using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window.Menu.Teacher.TeacherSurveyLayouts
{
    public partial class Layout2 : Form
    {

        public Layout2(bool isFirst)
        {

            InitializeComponent();

            this.isFirst = isFirst;

            if (this.isFirst) { this.Text = "Анкета для оценки качества взаимодействия членов команды в процессе разработки программного продукта"; }
            else { this.Text = "Анкета для оценки качества взаимодействия членов команды в завершении разработки программного продукта"; }

            Utils.bind(DisciplineList, "is_discipline", "name");
            Utils.bind(GroupList, "is_group", "name");

            Chart1.ChartAreas[0].AxisX.CustomLabels.Add(0.0f, 100.0f, "%");


        }

        private bool isFirst { get; set; }

        private void build()
        {

            if (GroupList.SelectedIndex == -1) { return; }
            if (DisciplineList.SelectedIndex == -1) { return; }

            Chart1.Series.Clear();

            string discipline = DisciplineList.SelectedItem.ToString();
            string group = GroupList.SelectedItem.ToString();

            string query = $@"

                select * from is_survey 

                where name = '{this.Text}'
                and discipline_id = (select id from is_discipline where name = '{discipline}')
                and group_id = (select id from is_group where name = '{group}')

            ";

            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int column = 0;

            List<double> values = new List<double>();

            while (reader.Read())
            {

                string result = reader["result"].ToString();
                string[] arr = result.Replace(" ", string.Empty).Split(new char[] { ',' });

                int sum = arr.Sum(t => int.Parse(t));
                double val = (sum * 100) / 6;

                values.Add(val);

                dictionary.Add(column, new List<int>());
                for(int i = 0; i < arr.Length; i++) { dictionary[column].Add(int.Parse(arr[i])); }

                column++;

            }

            Dictionary<double, int> dict = new Dictionary<double, int>();

            for(int i = 0; i < values.Count; i++)
            {
                double d = Math.Round(values[i] / 1400.0f, 4) * 100;

                if (dict.ContainsKey(d)) { 
                    dict[d]++;
                }
                else { dict.Add(d, 1); }

            }

            string space = " ";
            foreach(var target in dict)
            {

                double value = (double)target.Value / (double)values.Count;
                string str = $"{Math.Round(value, 4) * 100}%" + space;

                Chart1.Series.Add(str);
                Chart1.Series[str].Points.Add(target.Value);

                space += " ";

            }

            connection.Close();

            for (int i = 0; i < 14; i++)
            {

                Chart c = Container.Controls.Find($"Chart{i + 2}", true).FirstOrDefault() as Chart;
                c.Series.Clear();
                c.ChartAreas[0].AxisX.CustomLabels.Add(0.0f, 100.0f, "%");

            }

            for (int i = 0; i < 14; i++)
            {

                Chart c = Container.Controls.Find($"Chart{i + 2}", true).FirstOrDefault() as Chart;

                //c.Series.Add($"Вопрос {i + 1}");

                space = " ";
                foreach (var target in dictionary)
                {

                    int sum = dictionary.Sum(t => t.Value[i]);

                    double value = (double)target.Value[i] / sum;
                    string str = $"{Math.Round(value, 4) * 100}%" + space;

                    c.Series.Add(str);
                    c.Series[str].Points.Add(target.Value[i]);

                    space += " ";

                }

                //foreach (var t in dictionary)
                //{

                //    double target = t.Value[i];

                //    c.Series[$"Вопрос {i + 1}"].Points.Add(target * 100.0f / 6.0f);

                //}

            }

        }

        private void DisciplineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            build();
        }

        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            build();
        }

    }

}
