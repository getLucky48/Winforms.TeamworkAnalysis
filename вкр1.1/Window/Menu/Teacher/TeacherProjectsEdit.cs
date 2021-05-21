using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Teacher;
using WinFormInfSys.Window;
using static WinFormInfSys.Auth;

namespace WinFormInfSys
{

    public partial class TeacherProjectsEdit : Form
    {
        public TeacherProjectsEdit()
        {
            InitializeComponent();
        }

        public TeacherProjectsEdit(Tuple<Role, int> role)
        {

            InitializeComponent();

            this.role = role;

            buildTable();

        }

        private Tuple<Role, int> role { get; set; }

        private void buildTable()
        {

            Table.SuspendLayout();

            Table.Controls.Clear();

            List<ObjProjectsEdit> list = ObjProjectsEdit.getList(this.role.Item2);

            Utils.fillRow(Table, new Control[] {
                new Label(){ Text = "Предмет", AutoSize = true },
                new Label(){ Text = "Задание", AutoSize = true},
                new Label(){ Text = "Описание", AutoSize = true},
                new Label(){ Text = "Срок сдачи", AutoSize = true},
                new Label(){ Text = "Этап 1\nсрок сдачи", AutoSize = true},
                new Label(){ Text = "Этап 2\nсрок сдачи", AutoSize = true},
                new Label(){ Text = "Этап 3\nсрок сдачи", AutoSize = true},
                new Label(){ Text = "Этап 4\nсрок сдачи", AutoSize = true},
                new Label(){ Text = "Этап 5\nсрок сдачи", AutoSize = true},
                new Label(){ Text = "Этап 6\nсрок сдачи", AutoSize = true},
                new Label(){ Text = " " },
                new Label(){ Text = " " }
            }, 0); ;

            for(int i = 0; i < list.Count; i++)
            {

                ObjProjectsEdit obj = list[i];

                Button edit = Utils.buildButton("Редактировать", $"EditProjById_{obj.id}");
                edit.Width = 100;
                edit.Click += Edit_Click;

                Button delete = Utils.buildButton("Удалить", $"DeleteProjById_{obj.id}");
                delete.Width = 100;
                delete.Click += Delete_Click;

                Utils.fillRow(
                    Table,
                    new Control[] {

                        Utils.buildLabel(obj.discipline),
                        Utils.buildLabel(obj.name),
                        Utils.buildLabel(obj.descr),
                        Utils.buildLabel(obj.deadline),
                        Utils.buildLabel(obj.deadline1),
                        Utils.buildLabel(obj.deadline2),
                        Utils.buildLabel(obj.deadline3),
                        Utils.buildLabel(obj.deadline4),
                        Utils.buildLabel(obj.deadline5),
                        Utils.buildLabel(obj.deadline6),
                        edit,
                        delete

                    },
                    i + 1
                    );

            }

            Table.ResumeLayout();

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            Button b = sender as Button;

            int projId = int.Parse(b.Name.Replace("DeleteProjById_", string.Empty));

            ObjProjectsEdit.delete(projId);

            buildTable();

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            Button b = sender as Button;

            int projId = int.Parse(b.Name.Replace("EditProjById_", string.Empty));

            Utils.switchWindow(this, new _edit_TeacherProjectsEdit(projId, this.role));

            buildTable();

        }

    }

}
