using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{
    public partial class TeacherTaskAdd : Form
    {
        public TeacherTaskAdd()
        {

            InitializeComponent();

        }

        public TeacherTaskAdd(Tuple<Role, int> role)
        {

            InitializeComponent();

            this.role = role;

            Utils.bind(DisciplineList, "is_discipline", "name", true);

        }

        private Tuple<Role, int> role { get; set; }

        private void uploadFiles(Guid token)
        {

            int len = openFileDialog1.FileNames.Length;

            for (int i = 0; i < len; i++)
            {

                string path = openFileDialog1.FileNames[i];

                if (!File.Exists(path)) { continue; }

                FileStream fs = new FileStream(path, FileMode.Open);
                BufferedStream bf = new BufferedStream(fs);
                byte[] buffer = new byte[bf.Length];
                bf.Read(buffer, 0, buffer.Length);

                byte[] buffer_new = buffer;

                MySqlConnection connection = DBUtils.getConnection();
                connection.Open();
                MySqlCommand command = new MySqlCommand("", connection);
                command.CommandText = "insert into is_attachedfile(name, file, token) values(@name, @file, @token);";

                command.Parameters.AddWithValue("@name", openFileDialog1.SafeFileNames[i]);
                command.Parameters.AddWithValue("@file", buffer_new);
                command.Parameters.AddWithValue("@token", token.ToString());

                command.ExecuteNonQuery();

                connection.Close();

                bf.Close();
                fs.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(DisciplineList.SelectedIndex == -1 || string.IsNullOrWhiteSpace(ProjName.Text))
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            string disc = DisciplineList.SelectedItem.ToString();
            string name = ProjName.Text;
            string descr = Description.Text;
            DateTime date = Calendar.Value;
            bool ignore = IgnoreCalendar.Checked;

            string preparedDate = $"CAST('{date.ToString("yyyyMMdd")}' as date)";

            Guid guid = Guid.NewGuid();

            string cQuery = $@"

                                insert into is_project(discipline_id, teacher_id, deadline, descr, fl_unique, token, name)
                                values(
                                    (select id from is_discipline where name = '{disc}' limit 1),
                                    '{this.role.Item2}',
                                    { (ignore ? "null" : preparedDate) },
                                    '{descr}',
                                    true,
                                    '{guid}',
                                    '{name}'
                                )

                              ";

            DBUtils.execQuery(cQuery);

            uploadFiles(guid);

            MessageBox.Show("Успешно добавлено!");

        }

        private void refreshUploadFiles()
        {

            string txt = string.Empty;

            int len = openFileDialog1.SafeFileNames.Length;

            for (int i = 0; i < len; i++)
            {

                string t = openFileDialog1.SafeFileNames[i];

                txt += t;

                if(i < len - 1) { txt += ", "; }

            }

            AttachFilesLabel.Text = txt;

        }

        private void AttachFile_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK) { return; }

            refreshUploadFiles();

        }

    }

}
