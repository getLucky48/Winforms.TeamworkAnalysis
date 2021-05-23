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

        }

        private bool isFirst { get; set; }
        public static T Clone<T>(T controlToClone) where T : Control
        {
            T instance = Activator.CreateInstance<T>();

            Type control = controlToClone.GetType();
            PropertyInfo[] info = control.GetProperties();
            object p = control.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, controlToClone, null);
            foreach (PropertyInfo pi in info)
            {
                if ((pi.CanWrite) && !(pi.Name == "WindowTarget") && !(pi.Name == "Capture"))
                {
                    pi.SetValue(instance, pi.GetValue(controlToClone, null), null);
                }
            }
            return instance;
        }

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

            while (reader.Read())
            {

                string result = reader["result"].ToString();
                string[] arr = result.Replace(" ", string.Empty).Split(new char[] { ',' });

                int sum = arr.Sum(t => int.Parse(t));

                double val = (sum * 100) / 6;

                Chart1.Series.Add($"Студент {column}");

                Chart1.Series[$"Студент {column}"].Points.Add(val);

                dictionary.Add(column, new List<int>());
                for(int i = 0; i < arr.Length; i++) { dictionary[column].Add(int.Parse(arr[i])); }

                column++;

            }

            connection.Close();

            for (int i = 0; i < 14; i++)
            {

                Chart c = Container.Controls.Find($"Chart{i + 2}", true).FirstOrDefault() as Chart;
                c.Series.Clear();

            }

            for (int i = 0; i < 14; i++)
            {

                Chart c = Container.Controls.Find($"Chart{i + 2}", true).FirstOrDefault() as Chart;

                c.Series.Add($"Вопрос {i + 1}");

                foreach (var t in dictionary)
                {

                    double target = t.Value[i];

                    c.Series[$"Вопрос {i + 1}"].Points.Add(target * 100.0f / 6.0f);

                }

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
