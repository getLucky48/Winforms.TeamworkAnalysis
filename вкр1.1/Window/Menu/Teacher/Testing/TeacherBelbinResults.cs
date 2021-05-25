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

        private int lastColored = -1;

        private Color getColor(int sec, int max, int section)
        {
            
            if(sec == max) {

                if (lastColored == section)
                {
                    return Color.LightGreen;
                }
                else if(lastColored == -1){

                    lastColored = section;
                    return Color.LightGreen;

                }

            }

            return Color.Transparent;

        }

        private void formLists(string groupName)
        {

            this.lastColored = -1;

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

                if (obj.roles != null)
                {

                    Dictionary<string, int> roles = obj.roles;

                    int sum = roles.Sum(t => t.Value);

                    role1 = $"{Math.Round(double.Parse(roles["Генератор идей"].ToString()) / sum, 4) * 100}%";
                    role2 = $"{Math.Round(double.Parse(roles["Коллективист"].ToString()) / sum, 4) * 100}%";
                    role3 = $"{Math.Round(double.Parse(roles["Оценщик"].ToString()) / sum, 4) * 100}%";
                    role4 = $"{Math.Round(double.Parse(roles["Реализатор"].ToString()) / sum, 4) * 100}%";
                    role5 = $"{Math.Round(double.Parse(roles["Исполнитель"].ToString()) / sum, 4) * 100}%";
                    role6 = $"{Math.Round(double.Parse(roles["Координатор"].ToString()) / sum, 4) * 100}%";
                    role7 = $"{Math.Round(double.Parse(roles["Исследователь"].ToString()) / sum, 4) * 100}%";
                    role8 = $"{Math.Round(double.Parse(roles["Творец"].ToString()) / sum, 4) * 100}%";

                    var sorted = from t in roles orderby t.Value descending select t;

                    int sec1 = roles["Генератор идей"] + roles["Коллективист"] + roles["Оценщик"];
                    int sec2 = roles["Реализатор"] + roles["Исполнитель"];
                    int sec3 = roles["Координатор"] + roles["Исследователь"] + roles["Творец"];

                    int max = (new int[] { sec1, sec2, sec3 }).Max();

                    Utils.fillRow(

                        Table,
                        new Control[]
                        {

                                            Utils.buildLabel(name),
                                            Utils.buildLabel(role1, getColor(sec1, max, 1)),
                                            Utils.buildLabel(role2, getColor(sec1, max, 1)),
                                            Utils.buildLabel(role3, getColor(sec1, max, 1)),
                                            Utils.buildLabel(role4, getColor(sec2, max, 2)),
                                            Utils.buildLabel(role5, getColor(sec2, max, 2)),
                                            Utils.buildLabel(role6, getColor(sec3, max, 3)),
                                            Utils.buildLabel(role7, getColor(sec3, max, 3)),
                                            Utils.buildLabel(role8, getColor(sec3, max, 3))

                        },
                        i

                    );

                    this.lastColored = -1;

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
