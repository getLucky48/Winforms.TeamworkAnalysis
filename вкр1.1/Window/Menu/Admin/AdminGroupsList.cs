using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Admin;

namespace WinFormInfSys.Window
{
    public partial class AdminGroupsList : Form
    {

        public AdminGroupsList()
        {

            InitializeComponent();

            Utils.bind(FacultyList, "is_faculty", "name");
            Utils.bind(CourseList, "is_course", "name");

            buildList();

        }

        private void buildList()
        {

            Table.SuspendLayout();

            Utils.initTable(Table, new string[] { "Факультет", "Название", "Курс", "Год поступления", " ", " " });

            List<ObjGroupsList> list = ObjGroupsList.getList();

            for(int i = 0; i < list.Count; i++)
            {

                ObjGroupsList obj = list[i];

                Button edit = Utils.buildButton("Редактировать", $"ButtonEdit_{obj.id}");
                Button remove = Utils.buildButton("Удалить", $"ButtonDelete_{obj.id}");

                edit.Click += Edit_Click;
                remove.Click += Delete_Click;

                Utils.fillRow(Table, new Control[] {

                    Utils.buildLabel(obj.faculty),
                    Utils.buildLabel(obj.name),
                    Utils.buildLabel(obj.course),
                    Utils.buildLabel(obj.dt),
                    edit,
                    remove


                }, i + 1);

            }

            Table.ResumeLayout();

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonEdit_", string.Empty));

            _edit_AdminGroupsList dialog = new _edit_AdminGroupsList(id);

            dialog.ShowDialog();

            buildList();

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int id = int.Parse(((Button)sender).Name.Replace("ButtonDelete_", string.Empty));

            ObjGroupsList.delete(id);

            buildList();

        }

        private void Create_Click(object sender, EventArgs e)
        {

            string name = GroupName.Text;
            string year = Year.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(year) || FacultyList.SelectedIndex == -1 || CourseList.SelectedIndex == -1)
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            if (ObjGroupsList.isExists(name))
            {

                MessageBox.Show("Группа с таким названием уже существует");

                return;

            }

            ObjGroupsList obj = new ObjGroupsList()
            {

                name = name,
                dt = year,
                faculty = FacultyList.SelectedItem.ToString(),
                course = CourseList.SelectedItem.ToString()

            };

            ObjGroupsList.insert(obj);

            buildList();

        }

    }

}
