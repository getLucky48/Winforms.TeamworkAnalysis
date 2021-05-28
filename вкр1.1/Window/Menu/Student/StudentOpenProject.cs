using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys.Window
{

    public partial class StudentOpenProject : Form
    {
        public StudentOpenProject()
        {
            InitializeComponent();
        }
        public StudentOpenProject(int projId, Tuple<Role, int> role)
        {

            InitializeComponent();

            this.projId = projId;
            this.currentStep = 0;
            this.role = role;

            build(this.currentStep + 1);

            S1.Click += S1_Click;
            S2.Click += S2_Click;
            S3.Click += S3_Click;
            S4.Click += S4_Click;
            S5.Click += S5_Click;
            S6.Click += S6_Click;

            int[] stepsId = getStepsId();

            colorSteps(stepsId);


            return;

            setTitle();
            setFiles();

            buildStep();

            isLeader = getLeader();

            if (isLeader) { buildLeaderSection(); }

            if (this.currentStep <= 6)
            {

                string query = $@"

                select * from is_solution 

                where id = (select step{this.currentStep} from is_project where id = {this.projId})

                ";

                MySqlConnection connection = DBUtils.getConnection();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int statusId = int.Parse(reader["status_id"].ToString());

                    if(statusId == 2)
                    {

                        ChangedStatus.Text = $"Преподаватель отклонил ваше решение: {reader["descr"]}";

                    }

                    break;

                }

                connection.Close();

            }

        }

        private Tuple<Role, int> role { get; set; }
        private int projId { get; set; }
        private int currentStep { get; set; }
        private bool isLeader { get; set; }
        
        private void build(int step)
        {

            LeaderContainer.Controls.Clear();
            UserFiles.Controls.Clear();

            setTitle();
            setFiles();

            if (this.currentStep == step)
            {

                button1.Enabled = true;
                button2.Enabled = true;

            }
            else
            {

                button1.Enabled = false;
                button2.Enabled = false;

            }

            buildStep(step == this.currentStep ? -1 : step);

        }

        private void S6_Click(object sender, EventArgs e) { build(6); }

        private void S5_Click(object sender, EventArgs e) { build(5); }

        private void S4_Click(object sender, EventArgs e) { build(4); }

        private void S3_Click(object sender, EventArgs e) { build(3); }

        private void S2_Click(object sender, EventArgs e) { build(2); }

        private void S1_Click(object sender, EventArgs e) { build(1); }

        private void setTitle()
        {

            string query = $@"

                select 

                *

                from is_project isp

                where isp.id = {this.projId}

            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Description.Text = reader["name"].ToString() + ": " + reader["descr"].ToString();

                break;

            }

            connection.Close();

        }

        private int[] getStepsId()
        {

            int[] result = new int[] { };

            string query = $@"

                select 

                iss1.status_id as step1, 
                iss2.status_id as step2, 
                iss3.status_id as step3, 
                iss4.status_id as step4, 
                iss5.status_id as step5, 
                iss6.status_id as step6

                from is_project isp

                left join is_solution iss1 on iss1.id = isp.step1
                left join is_solution iss2 on iss2.id = isp.step2
                left join is_solution iss3 on iss3.id = isp.step3
                left join is_solution iss4 on iss4.id = isp.step4
                left join is_solution iss5 on iss5.id = isp.step5
                left join is_solution iss6 on iss6.id = isp.step6

                where isp.id = {this.projId}

            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                string step1 = reader["step1"].ToString();
                string step2 = reader["step2"].ToString();
                string step3 = reader["step3"].ToString();
                string step4 = reader["step4"].ToString();
                string step5 = reader["step5"].ToString();
                string step6 = reader["step6"].ToString();

                if (string.IsNullOrEmpty(step1)) { step1 = "-1"; }
                if (string.IsNullOrEmpty(step2)) { step2 = "-1"; }
                if (string.IsNullOrEmpty(step3)) { step3 = "-1"; }
                if (string.IsNullOrEmpty(step4)) { step4 = "-1"; }
                if (string.IsNullOrEmpty(step5)) { step5 = "-1"; }
                if (string.IsNullOrEmpty(step6)) { step6 = "-1"; }

                result = new int[] {
                    int.Parse(step1),
                    int.Parse(step2),
                    int.Parse(step3),
                    int.Parse(step4),
                    int.Parse(step5),
                    int.Parse(step6)
                };

                break;

            }

            connection.Close();

            return result;

        }

        private void colorSteps(int[] stepsId)
        {

            for (int i = 0; i < stepsId.Length; i++)
            {

                if (stepsId[i] == -1)
                {

                    Label l = this.Controls.Find($"S{i + 1}", true).FirstOrDefault() as Label;
                    l.BackColor = Color.Red;

                }
                else if (stepsId[i] == 1)
                {

                    Label l = this.Controls.Find($"S{i + 1}", true).FirstOrDefault() as Label;
                    l.BackColor = Color.Green;

                }
                else if (stepsId[i] == 2)
                {

                    Label l = this.Controls.Find($"S{i + 1}", true).FirstOrDefault() as Label;
                    l.BackColor = Color.Red;

                }
                else
                {

                    Label l = this.Controls.Find($"S{i + 1}", true).FirstOrDefault() as Label;
                    l.BackColor = Color.Yellow;

                }

            }

        }

        private void setFiles()
        {

            FileContainer.Controls.Clear();

            string query = $@"


                select isa.* from is_project isp

                left join is_attachedfile isa on isa.token = isp.token

                where isp.Id = {this.projId}


            ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                Button b = Utils.buildButton(reader["name"].ToString(), $"SaveFile_{reader["id"]}");
                b.Click += B_Click;

                FileContainer.Controls.Add(b);

            }

            connection.Close();


        }

        private bool getLeader()
        {

            string query = $"select leader from is_team where user_id = {this.role.Item2}";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            bool res = false;

            while (reader.Read())
            {

                if (reader["leader"].ToString().Equals("1")) { res = true; }

                break;

            }

            connection.Close();

            return res;

        }

        private void B_Click(object sender, EventArgs e)
        {

            Button b = sender as Button;

            saveFileDialog1.DefaultExt = b.Text;

            DialogResult dialogResult = saveFileDialog1.ShowDialog();

            if(dialogResult != DialogResult.OK) { return; }

            string fileName = saveFileDialog1.FileName;
            string fileId = b.Name.Replace("SaveFile_", string.Empty);

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            string command = $"select * from is_attachedfile where id = {fileId}";

            MySqlCommand cmd = new MySqlCommand(command, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                byte[] fileByte = (byte[])reader["file"];
                File.WriteAllBytes(fileName, fileByte);

                break;

            }

            connection.Close();

        }


        private void buildLeaderSection()
        {

            CheckedListBox check = new CheckedListBox();
            check.Name = "ListOfChecks";
            check.Size = new Size(new Point((int)(LeaderContainer.Width), 200));
            if (this.currentStep == 1)
            {

                check.Items.Add("Определить все термины и понятия с учетом предметной области");
                check.Items.Add("Проанализировать исходные данные на достаточность (исключение лишних данных и дополнение недостающих)");
                check.Items.Add("Определить выходные данные и формы их представления");
                check.Items.Add("Сформулировать альтернативы решения задачи");
                check.Items.Add("Обеспечить однозначность понимания постановки задачи пользователем и программистом");

            }
            else if (this.currentStep == 2)
            {

                check.Items.Add("Программный продукт должен отвергать любые данные, которые он не в состоянии обрабатывать правильно");
                check.Items.Add("В каждом следующем тесте необходимо использовать класс данных, отличный от предыдущего");
                check.Items.Add("следует испытать программный продукт в нормальных, экстремальных и исключительных условиях");
                check.Items.Add("Вычислить эталонные результаты нужно обязательно до, а не после получения машинных результатов");
                check.Items.Add("Очередной тестовый прогон должен контролировать нечто такое, что еще не было проверено на предыдущих прогонах");
                check.Items.Add("Первый тест должен быть максимально прост, чтобы проверить, работает ли программа в принципе");
                check.Items.Add("Арифметические операции в тестах должны предельно упрощаться для уменьшения объема вычислений");
                check.Items.Add("Тестирование должно быть целенаправленным и систематизированным, так как случайный выбор исходных данных приводит к трудностям");
                check.Items.Add("Усложнение тестовых данных должно происходить постепенно");


            }
            else if (this.currentStep == 3)
            {

                check.Items.Add("Выбрать представление данных, соответствующее задаче");
                check.Items.Add("Использовать в качестве параметров переменные, а не константы");
                check.Items.Add("создавать универсальные алгоритмы");
                check.Items.Add("Короткие модули предпочтительнее длинных модулей");
                check.Items.Add("Прежде чем программировать, записать алгоритм в псевдокодах или в форме блок-схемы");
                check.Items.Add("Планировать возможные изменения в алгоритме");
                check.Items.Add("Если алгоритм неправильный, не имеет значения, какова его эффективность");
                check.Items.Add("Определять требования к эффективности алгоритма на стадии проектирования");


            }
            else if (this.currentStep == 4)
            {

                check.Items.Add("Разрабатывать интерфейс пользователя до начала процесса кодирования");
                check.Items.Add("Выводить вместе с результатами работы программы исходные данные, при которых они получены");
                check.Items.Add("Комментировать результаты и исходные данные в терминах предметной области");
                check.Items.Add("указывать единицы измерения выводимых величин");
                check.Items.Add("Учитывать интересы разных групп пользователей, обеспечивая возможность настройки пользователем программы «под себя»");
                check.Items.Add("Выводить диагностические сообщения при ошибочных действиях пользователя");
                check.Items.Add("прежде чем начать программировать, необходимо разработать алгоритмы и структуры данных");
                check.Items.Add("Нередко при неоправданном усложнении программы или опасности наличия в ней ошибок продуктивно начать программирование сначала");
                check.Items.Add("рационально инициализировать переменные во время компиляции");
                check.Items.Add("Не следует использовать смешанные типы данных");
                check.Items.Add("Использовать для индексации наиболее предпочтительный тип данных");
                check.Items.Add("Оптимизировать сначала внутренние циклы");


            }
            else if (this.currentStep == 5)
            {

                check.Items.Add("Исключать синтаксические ошибки, приводящие к множественным распространенным ошибкам");
                check.Items.Add("Заранее продумывать и включать операторы вывода значений промежуточных результатов");
                check.Items.Add("Документировать обнаруженные ошибки");
                check.Items.Add("Начинать тестирование как можно раньше");
                check.Items.Add("Провести ручную проверку");
                check.Items.Add("Проверить правильность построения программного продукта на его простом варианте");
                check.Items.Add("Применять тестирование по методу сверху вниз");
                check.Items.Add("Использовать тестовые данные для проверки каждой ветви алгоритма");
                check.Items.Add("Повторять тестирование после каждого случая внесения изменений в программу");
                check.Items.Add("Набор данных должен обеспечивать выполнение каждого оператора, по крайней мере, один раз");
                check.Items.Add("Тестовые наборы данных в узлах ветвления с более чем одним условием должны обеспечивать принятие каждым условием значения «истина» или «ложь» хотя бы по одному разу");
                check.Items.Add("Тестовые наборы данных в узлах ветвления с более чем одним условием должны обеспечивать перебор всех возможных сочетаний значений условий в одном узле ветвления");

            }
            else if (this.currentStep == 6)
            {

                check.Items.Add("Наличие вводных комментариев");
                check.Items.Add("Отсутствуют глобальные переменные, структуры данных");
                check.Items.Add("Мнемоничные имена переменных, структур данных, функций");
                check.Items.Add("Операторы описания в начале модуля");
                check.Items.Add("Прокомментированы основные переменные, структуры данных");
                check.Items.Add("Однотипные объекты описаны в одном операторе");
                check.Items.Add("Переменные в операторах описания упорядочены по алфавиту");
                check.Items.Add("Отсутствуют целочисленные константы в определении размерности массивов");
                check.Items.Add("Прокомментированы основные этапы обработки данных");
                check.Items.Add("Каждый оператор (последовательность, которая заканчивается точкой с запятой) находится в отдельной строке");
                check.Items.Add("Каждая фигурная скобка находится в отдельной строке");
                check.Items.Add("Для выявления структуры программы использованы отступы (табуляция)");
                check.Items.Add("При описании структурных типов данных использованы отступы (табуляция)");
                check.Items.Add("Знаки бинарных операций отделены от операндов пробелами слева и справа");
                check.Items.Add("Отсутствие оператора безусловного перехода goto");
                check.Items.Add("Основные этапы обработки данных отделены друг от друга пустыми строками");
                check.Items.Add("Один оператор не заключается в фигурные скобки");
                check.Items.Add("Имена переменных, структур данных, функций содержат не более 12-15 символов");

            }

            LeaderContainer.Controls.Add(check);

            if(this.currentStep > 6) { return; }

            string query = $@"

                select iss.* from is_project 

                left join is_solution iss on iss.id = step{this.currentStep}

                where student_Id in (
                    select
                    user_id
                    from is_team where num = (
                        select num 
                        from is_team 
                        where user_id = (select student_Id from is_project where id = {this.projId})
                    )
                )

            ";

            //form other solutions

        }

        

        private void buildStep(int step = -1)
        {

            int[] stepsId = getStepsId();

            if(stepsId.Length < 6) { return; }
            if(stepsId.Length > 6)
            {
                MessageBox.Show("Вы успешно сдали эту работу");
                return;
            }


            //colorSteps(stepsId);

            int indx = 1;

            for(int i = 0; i < stepsId.Length; i++)
            {

                if(stepsId[i] == 1)
                {

                    indx = i + 2;

                }

            }

            if (step != -1) { indx = step; }

            this.currentStep = indx;

            if(indx > 6) { return; }

            StepTitle.Text = $"Этап {indx}: {(this.Controls.Find($"L{indx}", true).FirstOrDefault() as Label).Text}";
            if (step == -1) (this.Controls.Find($"S{indx}", true).FirstOrDefault() as Label).BackColor = Color.Yellow;

            if (stepsId[this.currentStep - 1] == 4)
            {

                button2.Enabled = false;
                Solution.Text = "Решение отправлено, ожидайте ответа преподавателя";
                Solution.ReadOnly = true;
                button1.Enabled = false;

            }
            else if(stepsId[this.currentStep - 1] == 3){

                button2.Enabled = false;
                Solution.Text = "Решение отправлено и просмотрено, ожидайте ответа преподавателя";
                Solution.ReadOnly = true;
                button1.Enabled = false;

            }


        }
        private void uploadFiles(Guid token)
        {

            int len = openFileDialog1.FileNames.Length;

            for (int i = 0; i < len; i++)
            {

                string path = openFileDialog1.FileNames[i];

                if (!File.Exists(path)) { continue; }

                FileStream fs = new FileStream(path, FileMode.Open);
                BufferedStream bf = new BufferedStream(fs);
                byte[] buffer = new byte[bf.Length];
                bf.Read(buffer, 0, buffer.Length);

                byte[] buffer_new = buffer;

                MySqlConnection connection = DBUtils.getConnection();
                connection.Open();
                MySqlCommand command = new MySqlCommand("", connection);
                command.CommandText = "insert into is_attachedfile(name, file, token) values(@name, @file, @token);";

                command.Parameters.AddWithValue("@name", openFileDialog1.SafeFileNames[i]);
                command.Parameters.AddWithValue("@file", buffer_new);
                command.Parameters.AddWithValue("@token", token.ToString());

                command.ExecuteNonQuery();

                connection.Close();

                bf.Close();
                fs.Close();

            }

        }
        private void refreshUploadFiles()
        {

            string txt = string.Empty;

            int len = openFileDialog1.SafeFileNames.Length;

            for (int i = 0; i < len; i++)
            {

                string t = openFileDialog1.SafeFileNames[i];

                txt += t;

                if (i < len - 1) { txt += ", "; }

            }

            UserFiles.Text = txt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();

            if (result != DialogResult.OK) { return; }

            refreshUploadFiles();

        }

        private string getArrayResult()
        {

            if (!this.isLeader) { return string.Empty; }

            string result = string.Empty;

            CheckedListBox checkedList = this.Controls.Find("ListOfChecks", true).First() as CheckedListBox;

            var arr = checkedList.CheckedIndices;

            for (int i = 0; i < arr.Count; i++) { result += $"{arr[i]} "; }

            return result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
 
            Guid guid = Guid.NewGuid();

            string arr = getArrayResult();

            string cQuery = $@"

                        insert into is_solution(status_id, token, solution, checkarray)
                        values(
                        4,
                        '{guid}',
                        '{Solution.Text}',
                        '{(this.isLeader ? arr : "none")}'
                        )


             ";

            DBUtils.execQuery(cQuery);

            uploadFiles(guid);

            ComboBox temp = new ComboBox();
            Utils.bind(temp, "is_solution", "id", true, $"where token = '{guid}'");

            string id = temp.Items[0].ToString();

            string upQuery = $"update is_project set step{this.currentStep} = {id} where id = {this.projId}";

            DBUtils.execQuery(upQuery);

            //string log = $@"

            //    insert into is_alert(user_id, alert, date)

            //    values (
            //    (select teacher_id from is_project where id = {this.projId} limit 1),

            //    concat((select name from is_user where id = {this.role.Item2}),
            //    ' отправил задание по дисциплине ',
            //    (select name from is_discipline where id = (select discipline_id from is_project where id = {this.projId})) , 
            //    ' ' ,
            //    (select name from is_project where id = {this.projId} limit 1)),
                
            //    CURRENT_TIMESTAMP
            //    )";

            //DBUtils.execQuery(log);

            MessageBox.Show("Успешно добавлено!");

            this.Close();

        }

    }

}
