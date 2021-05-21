using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace WinFormInfSys.Class.Teacher
{
    public class ObjSurveyRes_Layout1
    {

        public ObjSurveyRes_Layout1() { }

        public string group { get; set; }
        public string discipline { get; set; }
        public string result { get; set; }
        public string plus { get; set; }
        public string minus { get; set; }
        public string date { get; set; }

        public static Tuple<string, string> getColumns(string group, string discipline)
        {

            string query = $@"

                select plus, minus from is_survey_team_layout1               

                where              
                discipline_id = (select id from is_discipline where name = '{discipline}') 
                and group_id = (select id from is_group where name = '{group}')

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            string plus = string.Empty;
            string minus = string.Empty;

            while (reader.Read())
            {

                plus = reader["plus"].ToString();
                minus = reader["minus"].ToString();
                
                break;

            }

            connection.Close();

            return new Tuple<string, string>(plus, minus);

        }

        public static List<ObjSurveyRes_Layout1> getList(string group, string discipline)
        {

            List<ObjSurveyRes_Layout1> result = new List<ObjSurveyRes_Layout1>();

            string query = $@"

                select result, date from is_survey 

                where name = 'Мои ожидания от командной работы'                 
                and discipline_id = (select id from is_discipline where name = '{discipline}') 
                and group_id = (select id from is_group where name = '{group}')

            ";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                ObjSurveyRes_Layout1 obj = new ObjSurveyRes_Layout1()
                {

                    result = reader["result"].ToString(),
                    date = reader["date"].ToString()

                };

                result.Add(obj);

            }

            connection.Close();

            return result;

        }

        public static void insert(ObjSurveyRes_Layout1 obj)
        {

            string query = $@"

                insert into is_survey_team_layout1(plus, minus, group_id, discipline_id) 

                values
                (

                '{obj.plus}',
                '{obj.minus}',
                (select id from is_group where name = '{obj.group}'),
                (select id from is_discipline where name = '{obj.discipline}')

                )

            ";

            DBUtils.execQuery(query);

        }

        public static void update(ObjSurveyRes_Layout1 obj)
        {
            
            string query = $@"

                update is_survey_team_layout1

                set

                plus = '{obj.plus}',
                minus = '{obj.minus}'


                where group_id = (select id from is_group where name = '{obj.group}')
                and discipline_id = (select id from is_discipline where name = '{obj.discipline}')

            ";

            DBUtils.execQuery(query);

        }

        public static bool isExists(ObjSurveyRes_Layout1 obj)
        {

            string query = $@"

                select * from is_survey_team_layout1 

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
