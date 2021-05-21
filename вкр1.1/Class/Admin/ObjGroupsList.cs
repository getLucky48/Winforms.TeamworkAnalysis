using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WinFormInfSys.Class.Admin
{
    public class ObjGroupsList
    {

        public ObjGroupsList() { }

        public string id { get; set; }
        public string name { get; set; }
        public string course { get; set; }
        public string dt { get; set; }
        public string faculty { get; set; }

        public static List<ObjGroupsList> getList()
        {

            List<ObjGroupsList> result = new List<ObjGroupsList>();

            string query = $@"

                select 

                isg.id,
                isg.name as groupname,
                isc.name as course,
                isf.name as faculty,
                isg.dt as dt

                from is_group isg

                join is_course isc on isc.id = isg.course_id
                join is_faculty isf on isf.id = isg.faculty_id

            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                ObjGroupsList obj = new ObjGroupsList() {

                    id = reader["id"].ToString(),
                    faculty = reader["faculty"].ToString(),
                    name = reader["groupname"].ToString(),
                    course = reader["course"].ToString(),
                    dt = reader["dt"].ToString()

                };

                result.Add(obj);

            }

            conn.Close();

            return result;

        }

        public static void insert(ObjGroupsList obj)
        {

            string query = $@"insert into is_group(name, faculty_id, course_id, dt) 

                            values(
                                '{obj.name}',
                                (select id from is_faculty where name = '{obj.faculty}' limit 1),
                                (select id from is_course where name = '{obj.course}' limit 1),
                                '{obj.dt}'
                            )

                            ";

            DBUtils.execQuery(query);

        }

        public static void update(ObjGroupsList obj)
        {

            string query = $@"

                            UPDATE is_group SET 

                            name = '{obj.name}', 
                            course_id = (select id from is_course where name = '{obj.course}' limit 1),
                            faculty_id = (select id from is_faculty where name = '{obj.faculty}' limit 1),
                            dt = {obj.dt}

                            WHERE id = '{obj.id}'

            ";

            DBUtils.execQuery(query);

        }

        public static void delete(int groupId)
        {

            string query = $@"
                           
                update is_user SET group_id = null where group_id = {groupId};
                delete from is_group where id = {groupId};

            ";

            DBUtils.execQuery(query);

        }

        public static bool isExists(string name, int id = -1)
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

    }

}
