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
    public partial class TeacherSurveyResults : Form
    {
    
        public TeacherSurveyResults()
        {

            InitializeComponent();

            Utils.bind(Groups, "is_group", "name");
            Utils.bind(Disciplines, "is_discipline", "name");

        }

        private void renderSection(TableLayoutPanel table, string group, string discipline, string name)
        {

            table.SuspendLayout();

            Utils.initTable(table, new string[] { "Дата", "Результат" });

            string query = $"select * from is_survey where group_id = (select id from is_group where name = '{group}' limit 1) and name = '{name}' and discipline_id = (select id from is_discipline where name = '{discipline}')";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 1;

            while (reader.Read())
            {

                Utils.fillRow(table, new Control[] { 
                    Utils.buildLabel(reader["date"].ToString(), row.ToString()),
                    Utils.buildLabel(reader["result"].ToString(), row.ToString())
                }, row);

                row++;

            }

            connection.Close();

            table.ResumeLayout();

        }

        private void handler()
        {

            if (Groups.SelectedIndex == -1 || Disciplines.SelectedIndex == -1) { return; }

            string group = Groups.SelectedItem.ToString();
            string discipline = Disciplines.SelectedItem.ToString();

            renderSection(Table1, group, discipline, "Мои ожидания от командной работы");
            renderSection(Table2, group, discipline, "Анкета для оценки качества взаимодействия членов команды в процессе разработки программного продукта");
            renderSection(Table3, group, discipline, "Анкета для оценки качества взаимодействия членов команды в завершении разработки программного продукта");
            renderSection(Table4, group, discipline, "Я в команде: сильные и слабые стороны");

        }

        private void Groups_SelectedIndexChanged(object sender, EventArgs e)
        {

            handler();

        }

        private void Disciplines_SelectedIndexChanged(object sender, EventArgs e)
        {

            handler();

        }

    }

}
