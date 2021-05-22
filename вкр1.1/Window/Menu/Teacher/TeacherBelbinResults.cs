using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Teacher;
using System.Linq;
using System.Drawing;

namespace WinFormInfSys.Window
{
    
    public partial class TeacherBelbinResults : Form
    {
        public TeacherBelbinResults()
        {

            InitializeComponent();

            Utils.bind(GroupList, "is_group", "name");

        }

        private Color getColor(IOrderedEnumerable<KeyValuePair<string, int>> sorted, string role)
        {

            if (sorted.ElementAt(0).Key == role) { return Color.LightGreen; }
            if (sorted.ElementAt(1).Key == role) { return Color.LightGreen; }
            if (sorted.ElementAt(2).Key == role) { return Color.LightGreen; }

            return Color.Transparent;

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

                    var sorted = from t in roles orderby t.Value descending select t;

                    Utils.fillRow(

                        Table,
                        new Control[]
                        {

                                            Utils.buildLabel(name),
                                            Utils.buildLabel(role1, getColor(sorted, "Реализатор")),
                                            Utils.buildLabel(role2, getColor(sorted, "Исполнитель")),
                                            Utils.buildLabel(role3, getColor(sorted, "Координатор")),
                                            Utils.buildLabel(role4, getColor(sorted, "Исследователь")),
                                            Utils.buildLabel(role5, getColor(sorted, "Творец")),
                                            Utils.buildLabel(role6, getColor(sorted, "Генератор идей")),
                                            Utils.buildLabel(role7, getColor(sorted, "Коллективист")),
                                            Utils.buildLabel(role8, getColor(sorted, "Оценщик"))

                        },
                        i

                    );

                    continue;

                }


                Utils.fillRow(

                    Table,
                    new Control[]
                    {

                        Utils.buildLabel(name),
                        Utils.buildLabel(role1, Color.Tomato),
                        Utils.buildLabel(role2, Color.Tomato),
                        Utils.buildLabel(role3, Color.Tomato),
                        Utils.buildLabel(role4, Color.Tomato),
                        Utils.buildLabel(role5, Color.Tomato),
                        Utils.buildLabel(role6, Color.Tomato),
                        Utils.buildLabel(role7, Color.Tomato),
                        Utils.buildLabel(role8, Color.Tomato)

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
