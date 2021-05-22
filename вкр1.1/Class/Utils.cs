using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormInfSys.Class
{
    class Utils
    {

        public static void switchWindow(Form parent, Form child)
        {

            parent.Hide();
            child.ShowDialog();
            parent.Show();

        }

        public static void setColumns(TableLayoutPanel table, string[] columns)
        {

            table.SuspendLayout();

            table.ColumnCount = columns.Length;

            for (int i = 0; i < columns.Length; i++)
            {

                table.Controls.Add(new Label() { Text = columns[i], AutoSize = true }, i, 0);


            }

            table.ResumeLayout();

        }

        public static Label buildLabel(string text, string data = "")
        {

            Label res = new Label();
            res.Text = text;
            res.Name = $"LabelNum{data}";
            res.AutoSize = true;


            return res;

        }
        public static Label buildLabel(string text, Color color)
        {

            Label res = new Label();
            res.Text = text;
            res.Name = $"LabelNum";
            res.AutoSize = false;
            res.BackColor = color;
            res.TextAlign = ContentAlignment.MiddleCenter;
            res.Margin = new Padding(0, 0, 0, 0);

            return res;

        }

        public static Button buildButton(string text, string data)
        {

            Button res = new Button();
            res.Text = text;
            res.AutoSize = true;
            res.Name = data;

            return res;

        }

        public static void initTable(TableLayoutPanel table, string[] columns)
        {

            table.SuspendLayout();

            table.Controls.Clear();

            Utils.setColumns(table, columns);

            table.ResumeLayout();

        }

        public static void bind(ComboBox comboBox, string bindClass, string bindProperty, bool distinct = false, string customWhere = "")
        {

            string query = $"select {(distinct ? "distinct" : "") } {bindProperty} from {bindClass} ";

            if (!string.IsNullOrEmpty(customWhere)) { query += customWhere; }

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                comboBox.Items.Add(reader[bindProperty]);

            }

            connection.Close();

        }
        public static void bind(TextBox textBox, string bindProperty, string query)
        {

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                textBox.Text = reader[bindProperty].ToString();

                break;

            }

            connection.Close();

        }
        public static void bind(Label label, string bindProperty, string query)
        {

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                label.Text = reader[bindProperty].ToString();

                break;

            }

            connection.Close();

        }
        public static void bind(RichTextBox richTextBox, string bindProperty, string query)
        {

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                richTextBox.Text = reader[bindProperty].ToString();

                break;

            }

            connection.Close();

        }

        public static void selectItem(ComboBox comboBox, string bindProperty, MySqlDataReader reader)
        {

            string target = reader[bindProperty].ToString();

            int indxGroup = comboBox.Items.IndexOf(target);

            comboBox.SelectedIndex = indxGroup;

        }

        public static void selectItem(ComboBox comboBox, string srcClass, string srcProperty, string distClass, string distProperty, string getProperty, int srcId)
        {

            string query = $@"

                select dist.{getProperty} from {srcClass} src

                join {distClass} dist on src.{srcProperty} = dist.{distProperty}

                where src.id = '{srcId}'

                limit 1

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                string target = reader[0].ToString();

                int indx = comboBox.Items.IndexOf(target);

                comboBox.SelectedIndex = indx;

                break;

            }

            connection.Close();

        }

        public static void fillRow(TableLayoutPanel table, Control[] controlls, int row)
        {

            table.SuspendLayout();

            for (int i = 0; i < controlls.Length; i++)
            {

                table.Controls.Add(controlls[i], i, row);

            }

            table.ResumeLayout();

        }

    }

}
