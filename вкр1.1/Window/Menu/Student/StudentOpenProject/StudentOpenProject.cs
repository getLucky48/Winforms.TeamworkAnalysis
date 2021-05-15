using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{

    //todo: check is leader

    public partial class StudentOpenProject : Form
    {
        public StudentOpenProject()
        {
            InitializeComponent();
        }
        public StudentOpenProject(int projId)
        {

            InitializeComponent();

            this.projId = projId;



        }

        private int projId { get; set; }

        private int[] getStepsId()
        {

            int[] result = new int[] { };

            string query = $@"

                select * from is_project isp 


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

        private void buildStep()
        {

            int[] stepsId = getStepsId();

            if(stepsId.Length < 6) { return; }



        }

    }

}
