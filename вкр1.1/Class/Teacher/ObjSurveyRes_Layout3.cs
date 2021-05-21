using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace WinFormInfSys.Class.Teacher
{
    public class ObjSurveyRes_Layout3
    {

        public ObjSurveyRes_Layout3() {

            this.subGroups = new Dictionary<string, List<string>>();

        }

        public string name { get; set; }
        public string groupId { get; set; }
        public string disciplneId { get; set; }
        public string result { get; set; }
        public string date { get; set; }
        public Dictionary<string, List<string>> subGroups { get; set; }

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

    }

}
