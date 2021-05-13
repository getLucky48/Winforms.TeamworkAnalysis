using System;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{
    public partial class StudentSurveys : Form
    {
        public StudentSurveys()
        {

            InitializeComponent();

        }
        public StudentSurveys(Tuple<Role, int> role)
        {
            
            InitializeComponent();

            this.role = role;

        }

        private Tuple<Role, int> role { get; set; }

        private void first_Click(object sender, EventArgs e) { Utils.switchWindow(this, new Layout1(this.role, "Мои ожидания от командной работы")); }

        private void second_Click(object sender, EventArgs e) { Utils.switchWindow(this, new Layout2(this.role, "Анкета для оценки качества взаимодействия членов команды в процессе разработки программного продукта")); }

        private void third_Click(object sender, EventArgs e) { Utils.switchWindow(this, new Layout2(this.role, "Анкета для оценки качества взаимодействия членов команды в завершении разработки программного продукта")); }

        private void fourth_Click(object sender, EventArgs e) { Utils.switchWindow(this, new Layout3(this.role, "Я в команде: сильные и слабые стороны")); }

    }

}
