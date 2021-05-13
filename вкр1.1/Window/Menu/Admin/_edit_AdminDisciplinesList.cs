using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{
    public partial class _edit_AdminDisciplinesList : Form
    {
        public _edit_AdminDisciplinesList()
        {
            InitializeComponent();
        }
    
        public _edit_AdminDisciplinesList(int disc_id)
        {

            InitializeComponent();


            this.disc_id = disc_id;

            string query = $@"

                select isd.id as id, isd.name as discipline from is_discipline isd

                where isd.id = {this.disc_id}

            ";

            Utils.bind(Disc_name, "discipline", query);

        }

        private int disc_id { get; set; }

        private void Create_Click(object sender, EventArgs e)
        {

            string name = Disc_name.Text;

            if (DBUtils.disciplineIsExists(name, this.disc_id))
            {

                MessageBox.Show("Дисциплина с таким наименованием и типом уже существует");

                return;

            }

            if (string.IsNullOrWhiteSpace(name))
            {

                MessageBox.Show("Проверьте правильность данных");

                return;

            }

            string query = $@"UPDATE is_discipline SET

                            name = '{name}'

                            WHERE id = '{this.disc_id}'

                            ";

            DBUtils.execQuery(query);

            this.Close();

        }

    }

}
