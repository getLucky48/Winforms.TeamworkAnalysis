using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormInfSys.Class;

namespace WinFormInfSys.Window
{

    public partial class TeacherOpenProject : Form
    {
        public TeacherOpenProject()
        {
            InitializeComponent();
        }
        public TeacherOpenProject(int projId)
        {

            InitializeComponent();

            this.projId = projId;
            this.currentStep = 0;

            setTitle();
            setFiles();

            buildStep();


            if(this.currentStep <= 6)
            {
                string query = $@"

                update is_solution 

                set status_id = 3

                where id = (select step{this.currentStep} from is_project where id = {this.projId}) and status_id != 1 and status_id != 2 and status_id != 3

                ";

                DBUtils.execQuery(query);

                query = $@"

                select * from is_solution 

                where id = (select step{this.currentStep} from is_project where id = {this.projId})

                ";

                MySqlConnection connection = DBUtils.getConnection();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Solution.Text = reader["solution"].ToString();

                    break;

                }

                connection.Close();

                query = $@"

                select * from is_attachedfile where token in (select token from is_solution 

                where id = (select step{this.currentStep} from is_project where id = {this.projId}))

                ";

                connection.Open();

                cmd = new MySqlCommand(query, connection);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    Button b = Utils.buildButton(reader["name"].ToString(), $"SaveFile_{reader["id"]}");
                    b.Click += downloadFile;

                    UserFiles.Controls.Add(b);

                }

                connection.Close();

            }

            buildLeaderSection();

        }

        private void downloadFile(object sender, EventArgs e)
        {

            Button b = sender as Button;

            saveFileDialog1.DefaultExt = b.Text;

            DialogResult dialogResult = saveFileDialog1.ShowDialog();

            if (dialogResult != DialogResult.OK) { return; }

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

        private int projId { get; set; }
        private int currentStep { get; set; }
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

        private void B_Click(object sender, EventArgs e)
        {

            Button b = sender as Button;

            saveFileDialog1.DefaultExt = b.Text;

            DialogResult dialogResult = saveFileDialog1.ShowDialog();

            if (dialogResult != DialogResult.OK) { return; }

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

        private void buildStep()
        {

            int[] stepsId = getStepsId();

            if(stepsId.Length < 6) { return; }

            colorSteps(stepsId);

            if(stepsId.Length > 6) { return; }

            int indx = 1;

            for(int i = 0; i < stepsId.Length; i++)
            {

                if(stepsId[i] == 1)
                {

                    indx = i + 2;

                }

            }

            this.currentStep = indx;

            if(indx > 6) { return; }

            StepTitle.Text = $"Этап {indx}: {(this.Controls.Find($"L{indx}", true).FirstOrDefault() as Label).Text}";
            (this.Controls.Find($"S{indx}", true).FirstOrDefault() as Label).BackColor = Color.Yellow;

            if (stepsId[this.currentStep - 1] == 1)
            {

                button2.Enabled = false;
                Solution.Text = "Решение было принято";
                Solution.ReadOnly = true;
                button1.Enabled = false;

            }
            else if(stepsId[this.currentStep - 1] == 2){

                button2.Enabled = false;
                Solution.Text = "Решение было отклонено";
                Solution.ReadOnly = true;
                button1.Enabled = false;

            }
            else if(stepsId[this.currentStep - 1] == -1)
            {

                button2.Enabled = false;
                Solution.Text = "Решений нет";
                Solution.ReadOnly = true;
                button1.Enabled = false;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
 
            string query = $@"

                update is_solution 

                set status_id = 2, descr = '{descr.Text}'

                where id = (select step{this.currentStep} from is_project where id = {this.projId})

                " ;

           
            DBUtils.execQuery(query);

            string log = $@"

                insert into is_alert(user_id, alert, date)

                values (
                (select student_id from is_project where id = {this.projId} limit 1),

                concat(
                'Изменился статус задания по дисциплине: ',
                (select name from is_discipline where id = (select discipline_id from is_project where id = {this.projId})) ,
                ' ',
                (select name from is_project where id = {this.projId} limit 1)
                ),

                CURRENT_TIMESTAMP
                )";

            DBUtils.execQuery(log);

            MessageBox.Show("Ответ отправлен!");

            this.Close();

        }
        private void buildLeaderSection()
        {

            string query = $@"

                select isp.*, iss.checkarray from is_team 

                join is_project isp on isp.student_Id = user_id
                join is_solution iss on iss.id = isp.step{this.currentStep}

                where user_id = 
                    (select user_id from is_team 

                    where num = (
                            select num 
                            from is_team 
                            where user_id = (select student_Id from is_project where id = {this.projId})
                    ) and leader = 1)

                ";

            MySqlConnection connection = DBUtils.getConnection();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            string array = string.Empty;

            while (reader.Read())
            {

                array = reader["checkarray"].ToString();
                break;
            }

            connection.Close();

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
            
            if (array.Contains("none") || string.IsNullOrEmpty(array)) { return; }

            string[] values = array.Split(new char[] { ' ' });

            for(int i = 0; i < values.Length; i++)
            {
                if (string.IsNullOrEmpty(values[i])) { continue; }

                int indx = int.Parse(values[i]);
                check.SetItemChecked(indx, true);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string query = $@"

                update is_solution 

                set status_id = 1, descr = '{descr.Text}'

                where id = (select step{this.currentStep} from is_project where id = {this.projId})

                ";


            DBUtils.execQuery(query);

            string log = $@"

                insert into is_alert(user_id, alert, date)

                values (
                (select student_id from is_project where id = {this.projId} limit 1),

                concat(
                'Изменился статус задания по дисциплине: ',
                (select name from is_discipline where id = (select discipline_id from is_project where id = {this.projId})) ,
                ' ',
                (select name from is_project where id = {this.projId} limit 1)
                ),

                CURRENT_TIMESTAMP
                )";

            DBUtils.execQuery(log);

            MessageBox.Show("Ответ отправлен!");

            this.Close();

        }
    }

}
