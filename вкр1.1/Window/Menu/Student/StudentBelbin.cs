using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using WinFormInfSys.Class;
using static WinFormInfSys.Auth;

namespace WinFormInfSys
{

    public partial class StudentBelbin : Form
    {
        public StudentBelbin()
        {

            InitializeComponent();

            this.json = getJSON();

            this.currentPage = 0;
            
            this.currentSum = new Dictionary<string, int>() {
                { "Координатор", 0 },
                { "Творец", 0 },
                { "Генератор идей", 0 },
                { "Оценщик", 0 },
                { "Исполнитель", 0 },
                { "Исследователь", 0 },
                { "Коллективист", 0 },
                { "Реализатор", 0 }
            };

            buildUnits(this.currentPage);

        }

        public StudentBelbin(Tuple<Role, int> role)
        {

            InitializeComponent();

            this.json = getJSON();

            this.currentPage = 0;

            this.currentSum = new Dictionary<string, int>() {
                { "Координатор", 0 },
                { "Творец", 0 },
                { "Генератор идей", 0 },
                { "Оценщик", 0 },
                { "Исполнитель", 0 },
                { "Исследователь", 0 },
                { "Коллективист", 0 },
                { "Реализатор", 0 }
            };

            buildUnits(this.currentPage);

            this.role = role;

        }

        private Dictionary<string, string> rolesByBelbin = new Dictionary<string, string>()
        {

            { "Координатор",    @"Характеристика. Отличительной чертой Координаторов является способность заставлять других работать над распределенными целями. Зрелый, опытный и уверенный, Координатор охотно раздает поручения. В межличностных отношениях они быстро раскрывают индивидуальные наклонности и таланты и мудро их используют для достижения целей команды. Они не обязательно самые умные члены команды, это люди с большим кругозором и опытом, пользующиеся общим уважением команды.

Функциональность. Они хорошо себя проявляют, находясь во главе команды людей с различными навыками и характерами. Они лучше работают совместно с коллегами равными по рангу или позиции, чем с сотрудниками более низких уровней. Их девизом может быть ""консультация с контролем"". Они верят, что проблему можно решить мирным путем. В некоторых компаниях Координаторы могут вступать в конфликты из-за разности во взглядах с Творцами." },
            
            
            { "Творец",         @"Характеристика. Это люди с высоким уровнем мотивации, неисчерпаемой энергией и великой жаждой достижений. Обычно, это ярко выраженные экстраверты, обладающие сильной напористостью. Им нравится бросать вызов другим, их цель - победа. Им нравиться вести других и подталкивать к действиям. Если возникают препятствия, они быстро находят обходные пути. Своевольные и упрямые, уверенные и напористые, они имеют склонность эмоционально отвечать на любую форму разочарования или крушения планов. Целеустремленные, любящие поспорить. Но им часто не хватает простого человеческого понимания. Их роль самая конкурентная в команде.

Функционирование. Они, обычно, становятся хорошими руководителями благодаря тому, что умеют генерировать действия и успешно работать под давлением. Они умеют легко воодушевлять команду, и очень полезны в группах с разными взглядами, так как способны укротить страсти. Творцы способны парить над проблемами такого рода, продолжая лидировать, не считаясь с ними. Они могут легко провести необходимые изменения и не отказываются от нестандартных решений. Отвечая названию, они пытаются навязывать группе некоторые образцы или формы поведения и деятельности. Они являются самыми эффективными членами команды, способными гарантировать позитивные действия." },
            
            
            { "Генератор идей", @"Характеристика. Генераторы идей являются инноваторами и изобретателями, могут быть очень креативными. Они сеют зерно и идеи, из которых прорастают большинство разработок и проектов. Обычно они предпочитают работать самостоятельно, отделившись от других членов команды, используя свое воображение и часто следуя нетрадиционным путем. Имеют склонность быть интровертами и сильно реагируют как на критику, так и на похвалу. Часто их идеи имеют радикальный характер, и им не хватает практических усилий. Они независимы, умны и оригинальны, но могут быть слабыми в общении с людьми другого уровня или направления.

Функциональность. Основная функция Генераторов идей - создание новых предложений и решение сложных комплексных проблем. Они очень необходимы на начальных стадиях проектов или когда проект находится под угрозой срыва. Они обычно являются основателями компаний или организаторами новых производств. Тем не менее, большое количество Генераторов идей в одной компании может привести к контр-продуктивности, так как они имеют тенденцию проводить время, укрепляя свои собственные идеи и вступая друг с другом в конфликт." },
            
            
            { "Оценщик",        @"Характеристика. Это очень серьезные и предусмотрительные люди с врожденным иммунитетом против чрезмерного энтузиазма. Медлительны в принятии решения, предпочитают хорошо все обдумать. Они способны критически мыслить. Они умеют быть проницательными в суждениях, принимая во внимания все факторы. Эксперты редко ошибаются.

Функциональность. Эксперты наиболее подходят для анализа проблем и оценки идей и предложений. Они хорошо умеют взвешивать все ""за"" и ""против"" предложенных вариантов. По сравнению с другими, Эксперты кажутся черствыми, занудными и чрезмерно критичными. Некоторые удивляются, как им удается стать руководителями. Тем не менее, многие Эксперты занимают стратегические посты и преуспевают на должностях высшего ранга. Очень редко удача или срыв дела зависит от принятия спешных решений. Это идеальная ""сфера"" для Экспертов, людей, которые редко ошибаются и, в конце концов, выигрывают." },
            
            
            { "Исполнитель",    @"Характеристика. Обладают огромной способностью доводить дело до завершения и обращать внимание на детали. Они никогда не начинают то, что не могут довести до конца. Они мотивируются внутренним беспокойством, хотя часто внешне выглядят спокойными и невозмутимыми. Представители этого типа часто являются интровертами. Им обычно не требуется стимулирование из вне, или побуждения. Они не терпят случайностей. Не склонны к делегированию, предпочитают выполнять задания самостоятельно.

Функциональность. Являются незаменимыми в ситуациях, когда задания требуют сильной концентрированности и высокого уровня аккуратности. Они несут чувство срочности и неотложности в команду и хорошо проводят различные митинги. Хорошо справляются с управлением, благодаря своему стремлению к высшим стандартам, своей аккуратности, точности, вниманию к деталям и умению завершать начатое дело." },
            
            
            { "Исследователь",  @"Характеристика. Исследователи - часто энтузиасты и яркие экстраверты. Они умеют общаться с людьми в компании и за ее пределами. Они рождены для ведения переговоров, исследования новых возможностей и налаживания контактов. Хотя и не являясь генераторами оригинальных идей, они очень легко подхватывают идеи других и развивают их. Они очень легко распознают, что есть в наличии и что еще можно сделать. Их обычно очень тепло принимают в команде благодаря их открытой натуре. Они всегда открыты и любознательны, готовы найти возможности во всем новом. Но, если они не стимулируются другими, их энтузиазм быстро снижается.

Функциональность. Они очень хорошо реагируют и отвечают на новые идеи и разработки, могут найти ресурсы и вне группы. Они самые подходящие люди для установки внешних контактов и проведения последующих переговоров. Они умеют самостоятельно думать, получая информацию от других." },
            
            
            { "Коллективист",   @"Характеристика. Это люди, пользующиеся наибольшей поддержкой команды. Они очень вежливы, обходительны и общительны. Они умеют быть гибкими и адаптироваться к любой ситуации и разным людям. Дипломаты очень дипломатичны и восприимчивы. Они умеют слушать других и сопереживать, очень популярны в команде. В работе они полагаются на чувствительность, но могут столкнуться с трудностью при принятии решений в срочных и неотложных ситуациях.

Функциональность. Роль Дипломатов состоит в предотвращение межличностных проблем, появляющихся в команде, и поэтому это позволяет эффективно работать всем ее членам. Избегая трений, они будут идти длинной дорогой, ради того, чтобы обойти их стороной. Они не часто становятся руководителями, тем более, если их непосредственный начальник подчиняется Творцу. Это создает климат, в котором дипломатия и восприимчивость людей этого типа является настоящей находкой для команды, особенно при управленческом стиле, где конфликты могут возникать и должны искусственно пресекаться. Такие люди в качестве руководителя не представляют угрозу не для кого и поэтому всегда желанны для подчиненных. Дипломаты служат своего рода ""смазкой"" для команды, а люди в такой обстановке сотрудничают лучше." },
            
            
            { "Реализатор",     @"Характеристика. Реализаторам присущи практический здравый смысл и хорошее чувство самоконтроля и дисциплины. Они любят тяжелую работу и преодоление проблем в системном режиме. В большей степени Реализаторы являются типичными личностями, чья верность и интерес совпадают с ценностями Компании. Они менее сконцентрированы на преследовании собственных интересов. Тем не менее, им может не хватать спонтанности, и они могут проявлять жесткость и непреклонность.

Функциональность. Они очень полезны компании благодаря своей надежности и прилежанию. Они добиваются успеха, потому что очень работоспособны и могут четко определить то, что выполнимо и имеет отношение к делу. Говорят, что многие исполнители делают только ту работу, которую хотят делать и пренебрегают заданиями, которые находят неприятными. Реализаторы, наоборот, будут делать то, что необходимо делу. Хорошие Реализаторы часто продвигаются до высоких должностных позиций в управлении благодаря своим хорошим организаторским способностям и компетентности в решении всех важных вопросов." }

        };

        private Tuple<Role, int> role { get; set; }

        private JsonElement json { get; set; }

        private int currentPage { get; set; }

        private Dictionary<string, int> currentSum { get; set; }

        private List<MaskedTextBox> textBoxes { get; set; }

        private JsonElement getJSON()
        {

            MySqlConnection conn = DBUtils.getConnection();

            string query = $"select * from is_test";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            string result = string.Empty;

            while (reader.Read())
            {

                result = reader["content"].ToString();

                break;

            }

            conn.Close();

            JsonDocument jsonDoc = JsonDocument.Parse(result);

            JsonElement elem = jsonDoc.RootElement;

            return elem;

        }

        private MaskedTextBox buildTextBox(int parentWidth, int index)
        {
        
            MaskedTextBox res = new MaskedTextBox();
            res.Width = 35;
            res.Parent = Container;
            res.Name = $"TextBoxNum{index}";
            res.Text = "0";
            res.Location = new Point(parentWidth - res.Width - 10, index * 25);
            res.Mask = "00";
            res.PromptChar = ' ';

            return res;

        }

        private Label buildLabel(int parentWidth, int index, string text)
        {

            Label res = new Label();
            res.Width = parentWidth - res.Width - 10 - 20;
            res.Parent = Container;
            res.Text = text;
            res.Name = $"LabelNum{index}";
            res.Location = new Point(0, index * 25);

            return res;

        }

        private Button buildButton()
        {

            Button res = new Button();
            res.Click += Button_Click;
            res.Text = "Далее";
            res.Parent = Container;

            return res;

        }

        private bool buildUnits(int section = 0)
        {

            this.textBoxes = new List<MaskedTextBox>();

            int stepsLen = json.GetProperty("steps").GetArrayLength();

            if(section >= stepsLen) { return false; }

            JsonElement step = json.GetProperty("steps")[section];
            JsonElement title = step.GetProperty("title");
            JsonElement variants = step.GetProperty("variants");

            int len = variants.GetArrayLength();

            Title.Text = title.ToString();
            Steps.Text = $"Этап {section + 1} из {stepsLen}";

            for (int i = 0; i < len; i++)
            {

                MaskedTextBox tbox = buildTextBox(Container.Width, i);

                Label label = buildLabel(Container.Width, i, variants[i].ToString());

                this.textBoxes.Add(tbox);

            }

            Button button = buildButton();
            button.Location = new Point(0, Container.Controls.Find($"LabelNum{len - 1}", false).Last().Location.Y + 35);

            return true;

        }

        private bool calcRes(int section)
        {

            List<int> values = new List<int>();

            for(int i = 0; i < textBoxes.Count; i++)
            {

                int v = int.Parse(textBoxes[i].Text);

                values.Add(v);

            }

            if (section == 0)
            {

                if (values[0] > 0) { this.currentSum["Исследователь"] += 1; }
                if (values[1] > 0) { this.currentSum["Коллективист"] += 1; }
                if (values[2] > 0) { this.currentSum["Генератор идей"] += 1; }
                if (values[3] > 0) { this.currentSum["Координатор"] += 1; }
                if (values[4] > 0) { this.currentSum["Исполнитель"] += 1; }
                if (values[5] > 0) { this.currentSum["Творец"] += 1; }
                if (values[6] > 0) { this.currentSum["Реализатор"] += 1; }
                if (values[7] > 0) { this.currentSum["Оценщик"] += 1; }

            }
            else if (section == 1)
            {

                if (values[0] > 0) { this.currentSum["Реализатор"] += 1; }
                if (values[1] > 0) { this.currentSum["Координатор"] += 1; }
                if (values[2] > 0) { this.currentSum["Исследователь"] += 1; }
                if (values[3] > 0) { this.currentSum["Оценщик"] += 1; }
                if (values[4] > 0) { this.currentSum["Творец"] += 1; }
                if (values[5] > 0) { this.currentSum["Коллективист"] += 1; }
                if (values[6] > 0) { this.currentSum["Генератор идей"] += 1; }
                if (values[7] > 0) { this.currentSum["Исполнитель"] += 1; }

            }
            else if (section == 2)
            {
                if (values[0] > 0) { this.currentSum["Координатор"] += 1; }
                if (values[1] > 0) { this.currentSum["Исполнитель"] += 1; }
                if (values[2] > 0) { this.currentSum["Творец"] += 1; }
                if (values[3] > 0) { this.currentSum["Генератор идей"] += 1; }
                if (values[4] > 0) { this.currentSum["Коллективист"] += 1; }
                if (values[5] > 0) { this.currentSum["Исследователь"] += 1; }
                if (values[6] > 0) { this.currentSum["Оценщик"] += 1; }
                if (values[7] > 0) { this.currentSum["Реализатор"] += 1; }

            }
            else if (section == 3)
            {
                if (values[0] > 0) { this.currentSum["Коллективист"] += 1; }
                if (values[1] > 0) { this.currentSum["Творец"] += 1; }
                if (values[2] > 0) { this.currentSum["Оценщик"] += 1; }
                if (values[3] > 0) { this.currentSum["Реализатор"] += 1; }
                if (values[4] > 0) { this.currentSum["Генератор идей"] += 1; }
                if (values[5] > 0) { this.currentSum["Исполнитель"] += 1; }
                if (values[6] > 0) { this.currentSum["Исследователь"] += 1; }
                if (values[7] > 0) { this.currentSum["Координатор"] += 1; }

            }
            else if (section == 4)
            {

                if (values[0] > 0) { this.currentSum["Оценщик"] += 1; }
                if (values[1] > 0) { this.currentSum["Реализатор"] += 1; }
                if (values[2] > 0) { this.currentSum["Коллективист"] += 1; }
                if (values[3] > 0) { this.currentSum["Творец"] += 1; }
                if (values[4] > 0) { this.currentSum["Исследователь"] += 1; }
                if (values[5] > 0) { this.currentSum["Координатор"] += 1; }
                if (values[6] > 0) { this.currentSum["Исполнитель"] += 1; }
                if (values[7] > 0) { this.currentSum["Генератор идей"] += 1; }
            }
            else if (section == 5)
            {

                if (values[0] > 0) { this.currentSum["Генератор идей"] += 1; }
                if (values[1] > 0) { this.currentSum["Коллективист"] += 1; }
                if (values[2] > 0) { this.currentSum["Координатор"] += 1; }
                if (values[3] > 0) { this.currentSum["Исполнитель"] += 1; }
                if (values[4] > 0) { this.currentSum["Оценщик"] += 1; }
                if (values[5] > 0) { this.currentSum["Реализатор"] += 1; }
                if (values[6] > 0) { this.currentSum["Творец"] += 1; }
                if (values[7] > 0) { this.currentSum["Исследователь"] += 1; }

            }
            else if (section == 6)
            {

                if (values[0] > 0) { this.currentSum["Творец"] += 1; }
                if (values[1] > 0) { this.currentSum["Оценщик"] += 1; }
                if (values[2] > 0) { this.currentSum["Исполнитель"] += 1; }
                if (values[3] > 0) { this.currentSum["Исследователь"] += 1; }
                if (values[4] > 0) { this.currentSum["Реализатор"] += 1; }
                if (values[5] > 0) { this.currentSum["Генератор идей"] += 1; }
                if (values[6] > 0) { this.currentSum["Координатор"] += 1; }
                if (values[7] > 0) { this.currentSum["Коллективист"] += 1; }

            }

            return true;

        }

        private IOrderedEnumerable<KeyValuePair<string,int>> showResults()
        {

            var sorted = from t in this.currentSum orderby t.Value descending select t;

            string title = sorted.ElementAt(0).Key;

            int sum = this.currentSum.Sum(t => t.Value);

            string txt = string.Empty;
            txt += $"{rolesByBelbin[title]}\n\n";

            for(int i = 0; i < this.currentSum.Count; i++)
            {
                txt += $"{i+1}. {sorted.ElementAt(i).Key} [{Math.Round(double.Parse( this.currentSum[sorted.ElementAt(i).Key].ToString() ) / sum, 4) * 100}%]\n";
            }
            //$"";
            MessageBox.Show(txt, $"Ваша ключевая роль: {title}");

            return sorted;

        }

        private void setRoleByBelbin()
        {

            string query = $"select * from is_testresult where user_id = '{this.role.Item2}'";

            MySqlConnection connection = DBUtils.getConnection();

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {

                connection.Close();

                return;
            
            }

            connection.Close();

            string insert = $"insert into is_testresult(result, user_id) values('{JsonConvert.SerializeObject(this.currentSum)}', '{this.role.Item2}') ";

            DBUtils.execQuery(insert);

        }

        private bool checkFields()
        {

            for(int i = 0; i < textBoxes.Count; i++)
            {

                int value = int.Parse(textBoxes[i].Text);

                if(value < 0)
                {

                    MessageBox.Show($"Ответ не может быть меньше 0 [Ошибка в поле #{i + 1}]");

                    return false;

                }

                if(value != 0 && value < 2)
                {

                    MessageBox.Show($"Ответ, отличный от нуля, не может быть меньше 2 [Ошибка в поле #{i + 1}]");

                    return false;

                }

                if(value > 10)
                {


                    MessageBox.Show($"Ответ, отличный от нуля, не может быть больше 10 [Ошибка в поле #{i + 1}]");

                    return false;

                }

            }

            int sum = textBoxes.Sum(t => int.Parse(t.Text));
            
            if(sum != 10) {

                MessageBox.Show("Сумма распределенных очков должна быть равна 10");

                return false;
            
            }

            return true;

        }

        private void Button_Click(object sender, EventArgs e)
        {

            if (!checkFields()) { 

                return;

            }

            calcRes(this.currentPage);

            Container.Controls.Clear();

            this.currentPage++;

            if (!buildUnits(currentPage))
            {

                var sorted = showResults();

                setRoleByBelbin();

                this.Close();

            }

        }

    }

}
