using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Class
{
    class DBUtils
    {

        private static string host = "remotemysql.com";
        private static string database = "nwst3qKymu";
        private static string userid = "nwst3qKymu";
        private static string password = "1x8imOpVLH";

        public static MySqlConnection getConnection()
        {

            string connString = "Server=" + host + ";Database=" + database + ";User Id=" + userid + ";password=" + password;

            return new MySqlConnection(connString);

        }

        public static bool userIsExists(string login, int id = -1)
        {

            string query = $@"select * from is_user

                            where login = '{login}'

                            and id != '{id}'

                            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                conn.Close();

                return true;

            }

            conn.Close();

            return false;

        }

        public static bool groupIsExists(string name, int id = -1)
        {

            string query = $@"select * from is_group

                            where name = '{name}'

                            and id != '{id}'

                            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                conn.Close();

                return true;

            }

            conn.Close();

            return false;

        }

        public static bool disciplineIsExists(string name, int id = -1)
        {

            string query = $@"select * from is_discipline where

                            name = '{name}' and

                            id != '{id}'

                            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                conn.Close();

                return true;

            }

            conn.Close();

            return false;

        }

        public static string getHash(string arg)
        {

            MD5 md5 = MD5.Create();

            string hash = Convert.ToBase64String(md5.ComputeHash(Encoding.UTF8.GetBytes(arg)));

            return hash;

        }

        public static void execQuery(string query)
        {

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.ExecuteNonQuery();

            connection.Close();

        }

        public static void addUser(string name, string login, string password, Role role)
        {

            int roleId = -1;
            if (role == Role.Student) { roleId = 2; }
            else { roleId = 1; }

            string passHash = DBUtils.getHash(password);

            string query = $@"insert into is_user(login, password, name, role_id) 

                            values('{login}', '{passHash}', '{name}', '{roleId}')

                            ";

            DBUtils.execQuery(query);

        }

        public static void addUser(string name, string login, string password, string group, Role role)
        {
            int roleId = -1;
            if (role == Role.Student) { roleId = 2; }
            else { roleId = 1; }

            string passHash = DBUtils.getHash(password);

            string query = $@"

                            insert into is_user(login, password, name, role_id, group_id)
                            values('{login}', '{passHash}', '{name}', '{roleId}', (select id from is_group where name = '{group}' limit 1));

                            ";

            DBUtils.execQuery(query);

        }

        public static void addDiscipline(string name)
        {

            string query = $@"

                            insert into is_discipline(name)

                            values('{name}');

                            ";

            DBUtils.execQuery(query);

        }

        public static void removeTeacherById(int id)
        {

            string query = $@"

                update is_project SET teacher_id = null where teacher_id = {id};
                delete from is_user where id = {id};

            ";

            DBUtils.execQuery(query);

        }

        public static void removeStudentById(int id)
        {

            string query = $@"

                    delete from is_project where student_id = {id};
                    delete from is_user where id = {id};

                ";

            DBUtils.execQuery(query);

        }

    }

}
