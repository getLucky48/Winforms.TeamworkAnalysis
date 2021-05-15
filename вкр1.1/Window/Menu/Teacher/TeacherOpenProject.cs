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

namespace WinFormInfSys.Window
{

    //todo: check is leader

    public partial class TeacherOpenProject : Form
    {
        public TeacherOpenProject()
        {
            InitializeComponent();
        }
        public TeacherOpenProject(int projId)
        {

            InitializeComponent();

            this.projId = projId;
            this.currentStep = 0;

            setTitle();
            setFiles();

            buildStep();

            string query = $@"

                update is_solution 

                set status_id = 3

                where id = (select step{this.currentStep} from is_project where id = {this.projId})

                ";

            DBUtils.execQuery(query);

        }

        private int projId { get; set; }
        private int currentStep { get; set; }
        private void setTitle()
        {

            string query = $@"

                select 

                *

                from is_project isp

                where isp.id = {this.projId}

            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Description.Text = reader["name"].ToString() + ": " + reader["descr"].ToString();

                break;

            }

            connection.Close();

        }

        private int[] getStepsId()
        {

            int[] result = new int[] { };

            string query = $@"

                select 

                iss1.status_id as step1, 
                iss2.status_id as step2, 
                iss3.status_id as step3, 
                iss4.status_id as step4, 
                iss5.status_id as step5, 
                iss6.status_id as step6

                from is_project isp

                left join is_solution iss1 on iss1.id = isp.step1
                left join is_solution iss2 on iss2.id = isp.step2
                left join is_solution iss3 on iss3.id = isp.step3
                left join is_solution iss4 on iss4.id = isp.step4
                left join is_solution iss5 on iss5.id = isp.step5
                left join is_solution iss6 on iss6.id = isp.step6

                where isp.id = {this.projId}

            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                string step1 = reader["step1"].ToString();
                string step2 = reader["step2"].ToString();
                string step3 = reader["step3"].ToString();
                string step4 = reader["step4"].ToString();
                string step5 = reader["step5"].ToString();
                string step6 = reader["step6"].ToString();

                if (string.IsNullOrEmpty(step1)) { step1 = "-1"; }
                if (string.IsNullOrEmpty(step2)) { step2 = "-1"; }
                if (string.IsNullOrEmpty(step3)) { step3 = "-1"; }
                if (string.IsNullOrEmpty(step4)) { step4 = "-1"; }
                if (string.IsNullOrEmpty(step5)) { step5 = "-1"; }
                if (string.IsNullOrEmpty(step6)) { step6 = "-1"; }

                result = new int[] {
                    int.Parse(step1),
                    int.Parse(step2),
                    int.Parse(step3),
                    int.Parse(step4),
                    int.Parse(step5),
                    int.Parse(step6)
                };

                break;

            }

            connection.Close();

            return result;

        }

        private void colorSteps(int[] stepsId)
        {

            for (int i = 0; i < stepsId.Length; i++)
            {

                if (stepsId[i] == -1)
                {

                    Label l = this.Controls.Find($"S{i + 1}", true).FirstOrDefault() as Label;
                    l.BackColor = Color.Red;

                }
                else if (stepsId[i] == 1)
                {

                    Label l = this.Controls.Find($"S{i + 1}", true).FirstOrDefault() as Label;
                    l.BackColor = Color.Green;

                }
                else if (stepsId[i] == 2)
                {

                    Label l = this.Controls.Find($"S{i + 1}", true).FirstOrDefault() as Label;
                    l.BackColor = Color.Red;

                }
                else
                {

                    Label l = this.Controls.Find($"S{i + 1}", true).FirstOrDefault() as Label;
                    l.BackColor = Color.Yellow;

                }

            }

        }

        private void setFiles()
        {

            string query = $@"


                select isa.* from is_project isp

                left join is_attachedfile isa on isa.token = isp.token

                where isp.Id = {this.projId}


            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Button b = Utils.buildButton(reader["name"].ToString(), $"SaveFile_{reader["id"]}");
                b.Click += B_Click;

                FileContainer.Controls.Add(b);

                break;

            }

            connection.Close();


        }

        private void B_Click(object sender, EventArgs e)
        {

            //todo: download

        }

        private void buildStep()
        {

            int[] stepsId = getStepsId();

            if(stepsId.Length < 6) { return; }

            colorSteps(stepsId);

            int indx = 1;

            for(int i = 0; i < stepsId.Length; i++)
            {

                if(stepsId[i] == 1)
                {

                    indx = i + 2;

                }

            }

            this.currentStep = indx;

            StepTitle.Text = $"Этап {indx}: {(this.Controls.Find($"L{indx}", true).FirstOrDefault() as Label).Text}";
            (this.Controls.Find($"S{indx}", true).FirstOrDefault() as Label).BackColor = Color.Yellow;

            if (stepsId[this.currentStep - 1] == 1)
            {

                button2.Enabled = false;
                Solution.Text = "Решение было принято";
                Solution.ReadOnly = true;
                button1.Enabled = false;

            }
            else if(stepsId[this.currentStep - 1] == 2){

                button2.Enabled = false;
                Solution.Text = "Решение было отклонено";
                Solution.ReadOnly = true;
                button1.Enabled = false;

            }


        }
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
        private void refreshUploadFiles()
        {

            string txt = string.Empty;

            int len = openFileDialog1.SafeFileNames.Length;

            for (int i = 0; i < len; i++)
            {

                string t = openFileDialog1.SafeFileNames[i];

                txt += t;

                if (i < len - 1) { txt += ", "; }

            }

            UserFiles.Text = txt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK) { return; }

            refreshUploadFiles();

        }

        private void button2_Click(object sender, EventArgs e)
        {
 
            string query = $@"

                update is_solution 

                set status_id = 2, descr = '{descr.Text}'

                where id = (select step{this.currentStep} from is_project where id = {this.projId})

                " ;

           
            DBUtils.execQuery(query);

            MessageBox.Show("Ответ отправлен!");

            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string query = $@"

                update is_solution 

                set status_id = 1, descr = '{descr.Text}'

                where id = (select step{this.currentStep} from is_project where id = {this.projId})

                ";


            DBUtils.execQuery(query);

            MessageBox.Show("Ответ отправлен!");

            this.Close();

        }
    }

}
