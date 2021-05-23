using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;
using WinFormInfSys.Class;
using WinFormInfSys.Class.Teacher;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{
    public partial class _edit_TeacherProjectsEdit : Form
    {
        public _edit_TeacherProjectsEdit()
        {

            InitializeComponent();

        }

        public _edit_TeacherProjectsEdit(int projId, Tuple<Role, int> role)
        {

            InitializeComponent();

            this.role = role;
            this.projId = projId;

            Utils.bind(ProjName, "name", $"select * from is_project where id = {this.projId}");
            Utils.bind(Description, "descr", $"select * from is_project where id = {this.projId}");

        }

        private Tuple<Role, int> role { get; set; }

        private int projId { get; set; }

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

            if(string.IsNullOrWhiteSpace(ProjName.Text))
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            string name = ProjName.Text;
            string descr = Description.Text;

            DateTime date = Calendar.Value;
            bool ignore = IgnoreCalendar.Checked;
            string preparedDate = $"CAST('{date:yyyyMMdd}' as date)";

            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            DateTime date3 = dateTimePicker3.Value;
            DateTime date4 = dateTimePicker4.Value;
            DateTime date5 = dateTimePicker5.Value;
            DateTime date6 = dateTimePicker6.Value;

            bool ignore1 = checkBox1.Checked;
            bool ignore2 = checkBox2.Checked;
            bool ignore3 = checkBox3.Checked;
            bool ignore4 = checkBox4.Checked;
            bool ignore5 = checkBox5.Checked;
            bool ignore6 = checkBox6.Checked;

            string preparedDate1 = $"CAST('{date1:yyyyMMdd}' as date)";
            string preparedDate2 = $"CAST('{date2:yyyyMMdd}' as date)";
            string preparedDate3 = $"CAST('{date3:yyyyMMdd}' as date)";
            string preparedDate4 = $"CAST('{date4:yyyyMMdd}' as date)";
            string preparedDate5 = $"CAST('{date5:yyyyMMdd}' as date)";
            string preparedDate6 = $"CAST('{date6:yyyyMMdd}' as date)";

            Guid guid = Guid.NewGuid();

            ObjProjectsEdit obj = new ObjProjectsEdit()
            {

                id = this.projId,
                name = name,
                descr = descr,
                deadline = ignore ? "null" : preparedDate,
                deadline1 = ignore1 ? "null" : preparedDate1,
                deadline2 = ignore2 ? "null" : preparedDate2,
                deadline3 = ignore3 ? "null" : preparedDate3,
                deadline4 = ignore4 ? "null" : preparedDate4,
                deadline5 = ignore5 ? "null" : preparedDate5,
                deadline6 = ignore6 ? "null" : preparedDate6,
                token = guid.ToString()

            };

            ObjProjectsEdit.update(obj);
                        
            uploadFiles(guid);

            MessageBox.Show("Успешно отредактировано!");

            this.Close();

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
