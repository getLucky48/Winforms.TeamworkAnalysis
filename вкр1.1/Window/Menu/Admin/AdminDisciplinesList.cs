using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{
    public partial class AdminDisciplinesList : Form
    {

        public AdminDisciplinesList()
        {

            InitializeComponent();

            buildList();

        }

        private void buildList()
        {

            Table.SuspendLayout();

            Utils.initTable(Table, new string[] { "Название", " ", " " });

            string query = $@"

                select isd.id as id, isd.name as discipline from is_discipline isd

                order by isd.name

            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            int row = 0;

            while (reader.Read())
            {

                string id = reader["id"].ToString();
                string d = reader["discipline"].ToString();

                Label discipline = Utils.buildLabel(d, row.ToString());
                discipline.AutoSize = true;

                Button edit = Utils.buildButton("Редактировать", $"ButtonEdit_{id}");
                Button remove = Utils.buildButton("Удалить", $"ButtonDelete_{id}");

                edit.Click += Edit_Click;
                remove.Click += Delete_Click;

                Utils.fillRow(Table, new Control[] { discipline, edit, remove }, row + 1);

                row++;

            }

            conn.Close();

            Table.ResumeLayout();

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonEdit_", string.Empty));

            _edit_AdminDisciplinesList dialog = new _edit_AdminDisciplinesList(id);

            dialog.ShowDialog();

            buildList();

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonDelete_", string.Empty));

            DialogResult dialogResult = MessageBox.Show("При удалении дисциплины также будут удалены все проекты, связанные с ней. Продолжить?", "Подтверждение", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.No) { return; }

            string query = $@"

                SET foreign_key_checks = 0;                                

                delete from is_project where discipline_id = '{id}';
                delete from is_discipline where id = '{id}';

                SET foreign_key_checks = 1;

            ";

            DBUtils.execQuery(query);

            buildList();

        }

        private void Create_Click(object sender, EventArgs e)
        {

            string name = Name_disc.Text;

            if (DBUtils.disciplineIsExists(name))
            {

                MessageBox.Show("Дисциплина с таким наименованием и типом уже существует");

                return;

            }

            if (string.IsNullOrWhiteSpace(name))
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            DBUtils.addDiscipline(name);

            buildList();

        }

    }

}
