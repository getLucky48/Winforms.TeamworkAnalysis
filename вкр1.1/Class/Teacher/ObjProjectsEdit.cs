using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WinFormInfSys.Class.Teacher
{
    public class ObjProjectsEdit
    {

        public ObjProjectsEdit() { }

        public int id { get; set; }
        public string name { get; set; }
        public string discipline { get; set; }
        public string descr { get; set; }
        public string deadline { get; set; }
        public string deadline1 { get; set; }
        public string deadline2 { get; set; }
        public string deadline3 { get; set; }
        public string deadline4 { get; set; }
        public string deadline5 { get; set; }
        public string deadline6 { get; set; }
        public string token { get; set; }

        public static List<ObjProjectsEdit> getList(int userId)
        {

            List<ObjProjectsEdit> result = new List<ObjProjectsEdit>();

            string query = $@"

                select 
                
                isp.id as id,
                isp.descr as descr, 
                isp.deadline as deadline,
                isd.name as discipline,
                isp.name,
                isp.deadline1, 
                isp.deadline2, 
                isp.deadline3, 
                isp.deadline4, 
                isp.deadline5, 
                isp.deadline6

                from is_user isu

                join is_project isp on isp.teacher_id = isu.id
                join is_discipline isd on isd.id = isp.discipline_id               


                where isu.id = {userId} and fl_unique = 1

            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                ObjProjectsEdit obj = new ObjProjectsEdit()
                {

                    id = int.Parse(reader["id"].ToString()),
                    name = reader["name"].ToString(),
                    discipline = reader["discipline"].ToString(),
                    descr = reader["descr"].ToString(),
                    deadline = reader["deadline"].ToString(),
                    deadline1 = reader["deadline1"].ToString(),
                    deadline2 = reader["deadline2"].ToString(),
                    deadline3 = reader["deadline3"].ToString(),
                    deadline4 = reader["deadline4"].ToString(),
                    deadline5 = reader["deadline5"].ToString(),
                    deadline6 = reader["deadline6"].ToString()

                };

                result.Add(obj);

            }

            conn.Close();

            return result;

        }

        public static void update(ObjProjectsEdit obj)
        {

            string query = $@"

                set @token = (select token from is_project where id = {obj.id});     

                update is_project 

                set 

                name = '{obj.name}',
                token = '{obj.token}',
                descr = '{obj.descr}',
                deadline = {obj.deadline},
                deadline1 = {obj.deadline1},
                deadline2 = {obj.deadline2},
                deadline3 = {obj.deadline3},
                deadline4 = {obj.deadline4},
                deadline5 = {obj.deadline5},
                deadline6 = {obj.deadline6}

                where token = @token

            ";

            DBUtils.execQuery(query);

        }

        public static void delete(int projId)
        {

            string query = $@"

                delete from is_team where project_id = {projId};

                set @token = (select token from is_project where id = {projId});     

                delete from is_project where token = @token


            ";

            DBUtils.execQuery(query);

        }

    }

}
