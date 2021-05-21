using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WinFormInfSys.Class.Teacher
{
    public class ObjSurveyRes_Layout3
    {

        public ObjSurveyRes_Layout3() {

            this.subGroups = new Dictionary<string, Tuple<List<string>, string>>();

        }

        public string name { get; set; }
        public string group { get; set; }
        public string discipline { get; set; }
        public string result { get; set; }
        public string date { get; set; }

        public Dictionary<string, Tuple<List<string>, string>> subGroups { get; set; }

        public static List<ObjSurveyRes_Layout3> getList(string group, string discipline)
        {

            List<ObjSurveyRes_Layout3> result = new List<ObjSurveyRes_Layout3>();

            string query = $@"

                select result, date from is_survey 

                where name = 'Я в команде: сильные и слабые стороны'                 
                and discipline_id = (select id from is_discipline where name = '{discipline}') 
                and group_id = (select id from is_group where name = '{group}')

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                ObjSurveyRes_Layout3 obj = new ObjSurveyRes_Layout3()
                {

                    result = reader["result"].ToString(),
                    date = reader["date"].ToString()

                };

                result.Add(obj);

            }

            connection.Close();

            return result;

        }

        public static string getData(string group, string discipline)
        {

            string query = $@"

                select data from is_survey_team_layout3 

                where                
                discipline_id = (select id from is_discipline where name = '{discipline}') 
                and group_id = (select id from is_group where name = '{group}')

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                string obj = reader["data"].ToString();

                connection.Close();

                return obj;

            }

            connection.Close();

            return string.Empty;

        }

        public static void insert(ObjSurveyRes_Layout3 obj)
        {

            string query = $@"

                insert into is_survey_team_layout3(data, group_id, discipline_id) 

                values
                (

                '{JsonConvert.SerializeObject(obj)}',
                (select id from is_group where name = '{obj.group}'),
                (select id from is_discipline where name = '{obj.discipline}')

                )

            ";

            DBUtils.execQuery(query);

        }

        public static void update(ObjSurveyRes_Layout3 obj)
        {

            string query = $@"

                update is_survey_team_layout3

                set data = '{JsonConvert.SerializeObject(obj)}'

                where group_id = (select id from is_group where name = '{obj.group}')
                and discipline_id = (select id from is_discipline where name = '{obj.discipline}')

            ";

            DBUtils.execQuery(query);

        }

        public static bool isExists(ObjSurveyRes_Layout3 obj)
        {

            string query = $@"

                select * from is_survey_team_layout3 

                where group_id = (select id from is_group where name = '{obj.group}')
                and discipline_id = (select id from is_discipline where name = '{obj.discipline}')

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                connection.Close();

                return true;

            }

            connection.Close();

            return false;

        }

    }

}
