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

        }

        private void renderSection(TableLayoutPanel table, string group, string name)
        {

            table.SuspendLayout();

            Utils.initTable(table, new string[] { "Дата", "Результат" });

            string query = $"select * from is_survey where group_id = (select id from is_group where name = '{group}' limit 1) and name = '{name}'";

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

        private void Groups_SelectedIndexChanged(object sender, EventArgs e)
        {

            string group = Groups.SelectedItem.ToString();

            renderSection(Table1, group, "Мои ожидания от командной работы");
            renderSection(Table2, group, "Анкета для оценки качества взаимодействия членов команды в процессе разработки программного продукта");
            renderSection(Table3, group, "Анкета для оценки качества взаимодействия членов команды в завершении разработки программного продукта");
            renderSection(Table4, group, "Я в команде: сильные и слабые стороны");


        }

    }

}
