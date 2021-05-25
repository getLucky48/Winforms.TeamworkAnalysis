using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WinFormInfSys.Class.Teacher
{
    public class ObjBelbinDeadline
    {

        public ObjBelbinDeadline() { }

        public string dt_begin { get; set; }
        public string dt_end { get; set; }
        public string group { get; set; }
        public string discipline { get; set; }

        public static void insert(ObjBelbinDeadline obj)
        {

            string query = $@"

                insert into is_test_deadline(dt_begin, dt_end, group_id, discipline_id)

                values(

                {obj.dt_begin},
                {obj.dt_end},
                (select id from is_group where name = '{obj.group}'),
                (select id from is_discipline where name = '{obj.discipline}')

                )

            ";

            DBUtils.execQuery(query);

        }
        public static void update(ObjBelbinDeadline obj)
        {

            string query = $@"

                update is_test_deadline set

                dt_begin = {obj.dt_begin}, dt_end = {obj.dt_end}

                where group_id = (select id from is_group where name = '{obj.group}')
                and discipline_id = (select id from is_discipline where name = '{obj.discipline}')

            ";

            DBUtils.execQuery(query);

        }
        public static bool isExists(ObjBelbinDeadline obj)
        {

            string query = $@"

                select * from is_test_deadline

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
