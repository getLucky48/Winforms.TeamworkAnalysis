using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Teacher;
using System.Linq;

namespace WinFormInfSys.Window
{
    //todo: покраска строк
    
    public partial class TeacherBelbinResults : Form
    {
        public TeacherBelbinResults()
        {

            InitializeComponent();

            Utils.bind(GroupList, "is_group", "name");

        }

        private void formLists(string groupName)
        {

            Table.Controls.Clear();

            List<ObjBelbinResults> list = ObjBelbinResults.getList(groupName).OrderBy(t => t.roles == null).ToList();

            for (int i = 0; i < list.Count; i++)
            {

                ObjBelbinResults obj = list[i];

                string name = obj.name;

                string role1 = string.Empty;
                string role2 = string.Empty;
                string role3 = string.Empty;
                string role4 = string.Empty;
                string role5 = string.Empty;
                string role6 = string.Empty;
                string role7 = string.Empty;
                string role8 = string.Empty;

                if(obj.roles != null)
                {

                    Dictionary<string, int> roles = obj.roles;

                    int sum = roles.Sum(t => t.Value);

                    role1 = $"{Math.Round(double.Parse(roles["Реализатор"].ToString()) / sum, 4) * 100}%";
                    role2 = $"{Math.Round(double.Parse(roles["Исполнитель"].ToString()) / sum, 4) * 100}%";
                    role3 = $"{Math.Round(double.Parse(roles["Координатор"].ToString()) / sum, 4) * 100}%";
                    role4 = $"{Math.Round(double.Parse(roles["Исследователь"].ToString()) / sum, 4) * 100}%";
                    role5 = $"{Math.Round(double.Parse(roles["Творец"].ToString()) / sum, 4) * 100}%";
                    role6 = $"{Math.Round(double.Parse(roles["Генератор идей"].ToString()) / sum, 4) * 100}%";
                    role7 = $"{Math.Round(double.Parse(roles["Коллективист"].ToString()) / sum, 4) * 100}%";
                    role8 = $"{Math.Round(double.Parse(roles["Оценщик"].ToString()) / sum, 4) * 100}%";

                }

                Utils.fillRow(

                    Table,
                    new Control[]
                    {

                        Utils.buildLabel(name),
                        Utils.buildLabel(role1),
                        Utils.buildLabel(role2),
                        Utils.buildLabel(role3),
                        Utils.buildLabel(role4),
                        Utils.buildLabel(role5),
                        Utils.buildLabel(role6),
                        Utils.buildLabel(role7),
                        Utils.buildLabel(role8)

                    },
                    i

                );

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            formLists(GroupList.SelectedItem.ToString());

        }
    }
}
