using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WinFormInfSys.Class.Teacher
{
    public class ObjSurveyDeadline
    {

        public ObjSurveyDeadline() { }

        public string name { get; set; }
        public string dt_begin { get; set; }
        public string dt_end { get; set; }
        public string group { get; set; }
        public string discipline { get; set; }

        public static void insert(ObjSurveyDeadline obj)
        {

            string query = $@"

                insert into is_survey_deadline(name, dt_begin, dt_end, group_id, discipline_id)

                values(

                '{obj.name}',
                {obj.dt_begin},
                {obj.dt_end},
                (select id from is_group where name = '{obj.group}'),
                (select id from is_discipline where name = '{obj.discipline}')

                )

            ";

            DBUtils.execQuery(query);

        }
        public static void update(ObjSurveyDeadline obj)
        {

            string query = $@"

                update is_survey_deadline set

                dt_begin = {obj.dt_begin},
                dt_end = {obj.dt_end}

                where group_id = (select id from is_group where name = '{obj.group}')
                and discipline_id = (select id from is_discipline where name = '{obj.discipline}')

            ";

            DBUtils.execQuery(query);

        }
        public static bool isExists(ObjSurveyDeadline obj)
        {

            string query = $@"

                select * from is_survey_deadline

                where group_id = (select id from is_group where name = '{obj.group}')
                and discipline_id = (select id from is_discipline where name = '{obj.discipline}')
                and name = '{obj.name}'

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
