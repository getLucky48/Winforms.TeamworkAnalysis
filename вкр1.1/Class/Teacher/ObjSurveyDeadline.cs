using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WinFormInfSys.Class.Teacher
{
    public class ObjSurveyDeadline
    {

        public ObjSurveyDeadline() { }

        public string name { get; set; }
        public string deadline { get; set; }
        public string group { get; set; }
        public string discipline { get; set; }

        public static void insert(ObjSurveyDeadline obj)
        {

            string query = $@"

                insert into is_survey_deadline(name, deadline, group_id, discipline_id)

                values(

                '{obj.name}',
                {obj.deadline},
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

                deadline = {obj.deadline}

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
