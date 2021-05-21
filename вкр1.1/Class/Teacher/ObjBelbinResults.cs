using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormInfSys.Class.Teacher
{
    public class ObjBelbinResults
    {

        public ObjBelbinResults() { }

        public string name { get; set; }

        public Dictionary<string, int> roles = new Dictionary<string, int>() {
                { "Координатор", 0 },
                { "Творец", 0 },
                { "Генератор идей", 0 },
                { "Оценщик", 0 },
                { "Исполнитель", 0 },
                { "Исследователь", 0 },
                { "Коллективист", 0 },
                { "Реализатор", 0 }
            };

        public static List<ObjBelbinResults> getList(string group)
        {

            List<ObjBelbinResults> result = new List<ObjBelbinResults>();

            string query = $@"

                        select 

                        isu.name,
                        isu.id,
                        istr.result as role

                        from is_user isu 

                        left join is_testresult istr on istr.user_Id = isu.id

                        where isu.group_id = (select id from is_group where name = '{group}')

                        order by isu.name asc

            ";

            MySqlConnection conn = DBUtils.getConnection();

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                ObjBelbinResults target = new ObjBelbinResults()
                {

                    name = reader["name"].ToString(),
                    roles = JsonConvert.DeserializeObject<Dictionary<string, int>>(reader["role"].ToString())

                };

                result.Add(target);

            }

            conn.Close();

            return result;

        }

    }

}
