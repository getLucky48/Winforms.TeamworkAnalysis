-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: remotemysql.com
-- Время создания: Май 15 2021 г., 16:41
-- Версия сервера: 8.0.13-4
-- Версия PHP: 7.2.24-0ubuntu0.18.04.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `nwst3qKymu`
--

-- --------------------------------------------------------

--
-- Структура таблицы `is_alert`
--

CREATE TABLE `is_alert` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `alert` text COLLATE utf8_unicode_ci NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_attachedfile`
--

CREATE TABLE `is_attachedfile` (
  `id` int(11) NOT NULL,
  `name` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `file` longblob NOT NULL,
  `token` varchar(36) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_course`
--

CREATE TABLE `is_course` (
  `id` int(11) NOT NULL,
  `name` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `num` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `is_course`
--

INSERT INTO `is_course` (`id`, `name`, `num`) VALUES
(1, 'Курс 1', 1),
(2, 'Курс 2', 2),
(3, 'Курс 3', 3),
(4, 'Курс 4', 4),
(5, 'Курс 5', 5);

-- --------------------------------------------------------

--
-- Структура таблицы `is_discipline`
--

CREATE TABLE `is_discipline` (
  `id` int(11) NOT NULL,
  `name` varchar(128) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_faculty`
--

CREATE TABLE `is_faculty` (
  `id` int(11) NOT NULL,
  `name` varchar(128) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `is_faculty`
--

INSERT INTO `is_faculty` (`id`, `name`) VALUES
(4, 'АВТФ'),
(5, 'ИСТ'),
(6, 'ФЛА'),
(7, 'МТФ'),
(8, 'ФМА'),
(9, 'ФПМИ'),
(10, 'РЭФ'),
(11, 'ФТФ'),
(12, 'ФЭН'),
(13, 'ФБ'),
(14, 'ФГО');

-- --------------------------------------------------------

--
-- Структура таблицы `is_group`
--

CREATE TABLE `is_group` (
  `id` int(11) NOT NULL,
  `name` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `faculty_id` int(11) NOT NULL,
  `course_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_project`
--

CREATE TABLE `is_project` (
  `id` int(11) NOT NULL,
  `teacher_id` int(11) DEFAULT NULL,
  `student_Id` int(11) DEFAULT NULL,
  `discipline_id` int(11) DEFAULT NULL,
  `deadline` date DEFAULT NULL,
  `name` varchar(512) COLLATE utf8_unicode_ci NOT NULL,
  `descr` varchar(512) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fl_completed` tinyint(1) NOT NULL DEFAULT '0',
  `fl_unique` bit(1) NOT NULL DEFAULT b'0',
  `token` varchar(36) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `step1` int(11) DEFAULT NULL,
  `step2` int(11) DEFAULT NULL,
  `step3` int(11) DEFAULT NULL,
  `step4` int(11) DEFAULT NULL,
  `step5` int(11) DEFAULT NULL,
  `step6` int(11) DEFAULT NULL,
  `score` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_role`
--

CREATE TABLE `is_role` (
  `id` int(11) NOT NULL,
  `name` varchar(128) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `is_role`
--

INSERT INTO `is_role` (`id`, `name`) VALUES
(1, 'Преподаватель'),
(2, 'Студент');

-- --------------------------------------------------------

--
-- Структура таблицы `is_score`
--

CREATE TABLE `is_score` (
  `id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `discipline_id` int(11) NOT NULL,
  `score` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_solution`
--

CREATE TABLE `is_solution` (
  `id` int(11) NOT NULL,
  `status_id` int(11) NOT NULL,
  `token` varchar(36) COLLATE utf8_unicode_ci NOT NULL,
  `solution` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `checkarray` text CHARACTER SET utf8 COLLATE utf8_unicode_ci,
  `descr` text COLLATE utf8_unicode_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_status`
--

CREATE TABLE `is_status` (
  `id` int(11) NOT NULL,
  `name` varchar(128) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `is_status`
--

INSERT INTO `is_status` (`id`, `name`) VALUES
(1, 'Принято'),
(2, 'Отклонено'),
(3, 'Просмотрено'),
(4, 'Отправлено');

-- --------------------------------------------------------

--
-- Структура таблицы `is_survey`
--

CREATE TABLE `is_survey` (
  `id` int(11) NOT NULL,
  `name` varchar(512) COLLATE utf8_unicode_ci NOT NULL,
  `result` text COLLATE utf8_unicode_ci NOT NULL,
  `date` date NOT NULL,
  `fl_array` bit(1) NOT NULL DEFAULT b'0',
  `group_id` int(11) NOT NULL,
  `discipline_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_team`
--

CREATE TABLE `is_team` (
  `id` int(11) NOT NULL,
  `designation` varchar(36) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `num` int(128) NOT NULL,
  `leader` bit(1) NOT NULL DEFAULT b'0',
  `user_id` int(11) NOT NULL,
  `project_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_test`
--

CREATE TABLE `is_test` (
  `id` int(11) NOT NULL,
  `name` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `content` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `is_test`
--

INSERT INTO `is_test` (`id`, `name`, `content`) VALUES
(1, 'Тест Белбина', '{\r\n   \"steps\":[\r\n      {\r\n         \"title\":\"Какой вклад я могу внести в работу команды:\",\r\n         \"variants\":[\r\n            \"Я думаю, что способен быстро замечать новые возможности и извлекать из них выгоды.\",\r\n            \"Я могу успешно работать с самыми разными людьми.\",\r\n            \"Генерация идей — моё врожденное достоинство.\",\r\n            \"Моим достоинством является умение находить людей, способных принести пользу команде.\",\r\n            \"Моя способность доводить всё до конца во многом обеспечила мою профессиональную эффективность.\",\r\n            \"Я готов перенести временную непопулярность, если вижу, что мои действия принесут в конечном счете полезные результаты.\",\r\n            \"Я быстро выясняю, что сработает в данной ситуации, если в подобную ситуацию я уже попадал.\",\r\n            \"Личные заблуждения и предубеждения не мешают мне находить и доказывать преимущества альтернативных действий.\"\r\n         ]\r\n      },\r\n      {\r\n         \"title\":\"Мои недостатки, которые могут проявиться в командной работе:\",\r\n         \"variants\":[\r\n            \"Я чувствую себя неуверенно на совещании, если отсутствуют четкая повестка дня и контроль за её соблюдением.\",\r\n            \"Я склонен быть слишком великодушным к людям, имеющим правильную точку зрения, но не высказывающим её открыто.\",\r\n            \"Я склонен слишком много говорить, когда в группе обсуждаются новые идеи.\",\r\n            \"Вследствие моей осмотрительности я не склонен быстро и с энтузиазмом присоединяться к мнению коллег.\",\r\n            \"Я иногда выгляжу авторитарным и нетерпимым, когда чувствую необходимость достичь чего-то.\",\r\n            \"Мне трудно повести людей за собой, поскольку я слишком подвержен влиянию атмосферы, царящей в группе.\",\r\n            \"Я слишком захвачен идеями, которые мне приходят в голову, и поэтому плохо слежу за тем, что происходит вокруг.\",\r\n            \"Мои коллеги находят, что я слишком много внимания уделяю деталям и чрезмерно беспокоюсь о том, что дела идут неправильно.\"\r\n         ]\r\n      },\r\n      {\r\n         \"title\":\"Участие в совместном проекте:\",\r\n         \"variants\":[\r\n            \"Я умею влиять на людей, не оказывая на них давления.\",\r\n            \"Врожденная осмотрительность предохраняет меня от ошибок, возникающих из-за невнимательности.\",\r\n            \"Я готов оказать давление, чтобы совещание не превращалось в пустую трату времени и не терялась из виду основная цель обсуждения.\",\r\n            \"Можно рассчитывать на поступление от меня оригинальных предложений.\",\r\n            \"Я всегда готов поддержать любое предложение, если оно служит общим интересам.\",\r\n            \"Я энергично ищу среди новых идей и разработок свежайшие.\",\r\n            \"Я надеюсь, что моя способность выносить беспристрастные суждения признаётся всеми, кто меня знает.\",\r\n            \"На меня можно возложить обязанности следить за тем, чтобы наиболее существенная работа была организована должным образом.\"\r\n         ]\r\n      },\r\n      {\r\n         \"title\":\"Особенности моего стиля работы в команде:\",\r\n         \"variants\":[\r\n            \"Я постоянно стараюсь лучше узнать своих коллег.\",\r\n            \"Я неохотно возражаю своим коллегам и не люблю сам быть в меньшинстве.\",\r\n            \"Я обычно нахожу вескую аргументацию против плохих предложений.\",\r\n            \"Я полагаю, что обладаю талантом быстро организовать исполнение одобренных планов.\",\r\n            \"Я обладаю способностью избегать очевидных решений и умею находить неожиданные.\",\r\n            \"Я стремлюсь добиться совершенства при исполнении любой роли в командной работе.\",\r\n            \"Я умею устанавливать контакты с внешним окружением команды.\",\r\n            \"Я способен воспринимать любые высказываемые мнения, но без колебаний подчиняюсь мнению большинства после принятия решения.\"\r\n         ]\r\n      },\r\n      {\r\n         \"title\":\"Я получаю удовлетворение от работы, потому что:\",\r\n         \"variants\":[\r\n            \"Мне доставляет удовольствие анализ ситуаций и взвешивание всех шансов.\",\r\n            \"Мне нравится находить практические решения проблем.\",\r\n            \"Мне нравиться сознавать, что я создаю хорошие рабочие взаимоотношения.\",\r\n            \"Я способен оказывать сильное влияние на принятие решений.\",\r\n            \"Я получаю возможность встретиться с людьми, способными предложить что-то новое для меня.\",\r\n            \"Я способен добиться согласия людей на реализацию необходимого курса действий.\",\r\n            \"Я чувствую себя в своей стихии, когда могу уделить задаче все мое внимание.\",\r\n            \"Мне нравится находить задачи, требующие напряжения воображения.\"\r\n         ]\r\n      },\r\n      {\r\n         \"title\":\"Если мне неожиданно предложат решить трудную задачу за ограниченное время с незнакомыми людьми, то:\",\r\n         \"variants\":[\r\n            \"Я бы почувствовал необходимость сначала в одиночестве обдумать пути выхода из тупика, прежде чем начать действовать.\",\r\n            \"Я был бы готов работать с человеком, указавшим наиболее позитивный подход, каковы бы ни были связанные с этим трудности.\",\r\n            \"Я бы попытался найти способ разбиения задачи на части в соответствии с тем, что лучше всего умеют делать отдельные члены команды.\",\r\n            \"Присущая мне обязательность помогла бы нам не отстать от графика.\",\r\n            \"Я надеюсь, мне бы удалось сохранить хладнокровие и способность логически мыслить.\",\r\n            \"Я бы упорно добивался достижения цели, несмотря ни на какие помехи.\",\r\n            \"Я был бы готов действовать силой положительного примера при появлении признаков отсутствия прогресса в командной работе.\",\r\n            \"Я бы организовал дискуссию, чтобы стимулировать выдвижение новых идей и придать начальный импульс командной работе.\"\r\n         ]\r\n      },\r\n      {\r\n         \"title\":\"Проблемы, с которыми я сталкиваюсь, работая в команде:\",\r\n         \"variants\":[\r\n            \"Я склонен проявлять нетерпимость по отношению к людям, мешающим, по моему мнению, прогрессу в делах группы.\",\r\n            \"Окружающие иногда критикуют меня за чрезмерный рационализм и неспособность к интуитивным решениям.\",\r\n            \"Мое стремление обеспечить условия, чтобы работа выполнялась правильно, может приводить к снижению темпов.\",\r\n            \"Я слишком быстро утрачиваю энтузиазм и стараюсь почерпнуть его у наиболее активных членов группы.\",\r\n            \"Я тяжел на подъем, если не имею ясных целей.\",\r\n            \"Мне иногда бывает очень трудно разобраться во встретившихся мне сложностях.\",\r\n            \"Я стесняюсь обратиться за помощью к другим, когда не могу что-либо сделать сам.\",\r\n            \"Я испытываю затруднения при обосновании своей точки зрения, когда сталкиваюсь с серьезными возражениями.\"\r\n         ]\r\n      }\r\n   ]\r\n}');

-- --------------------------------------------------------

--
-- Структура таблицы `is_testresult`
--

CREATE TABLE `is_testresult` (
  `id` int(11) NOT NULL,
  `rolebybelbin` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `rolebybelbin_s` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `rolebybelbin_t` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `user_Id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `is_user`
--

CREATE TABLE `is_user` (
  `id` int(11) NOT NULL,
  `login` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(128) COLLATE utf8_unicode_ci NOT NULL,
  `role_id` int(11) NOT NULL,
  `group_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `is_user`
--

INSERT INTO `is_user` (`id`, `login`, `password`, `name`, `role_id`, `group_id`) VALUES
(142, 'admin', 'ISMvKXpXpadDiUoOSoAfww==', 'Администратор', 1, NULL);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `is_alert`
--
ALTER TABLE `is_alert`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Индексы таблицы `is_attachedfile`
--
ALTER TABLE `is_attachedfile`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `is_course`
--
ALTER TABLE `is_course`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `is_discipline`
--
ALTER TABLE `is_discipline`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `is_faculty`
--
ALTER TABLE `is_faculty`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `is_group`
--
ALTER TABLE `is_group`
  ADD PRIMARY KEY (`id`),
  ADD KEY `faculty_id` (`faculty_id`,`course_id`),
  ADD KEY `course_id` (`course_id`);

--
-- Индексы таблицы `is_project`
--
ALTER TABLE `is_project`
  ADD PRIMARY KEY (`id`),
  ADD KEY `discipline_id` (`discipline_id`,`teacher_id`,`student_Id`),
  ADD KEY `teacher_id` (`teacher_id`),
  ADD KEY `student_Id` (`student_Id`),
  ADD KEY `step1` (`step1`,`step2`,`step3`,`step4`,`step5`,`step6`),
  ADD KEY `step6` (`step6`),
  ADD KEY `step4` (`step4`),
  ADD KEY `step5` (`step5`),
  ADD KEY `step3` (`step3`),
  ADD KEY `step2` (`step2`);

--
-- Индексы таблицы `is_role`
--
ALTER TABLE `is_role`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `is_score`
--
ALTER TABLE `is_score`
  ADD PRIMARY KEY (`id`),
  ADD KEY `discipline_id` (`discipline_id`,`student_id`),
  ADD KEY `user_id` (`student_id`);

--
-- Индексы таблицы `is_solution`
--
ALTER TABLE `is_solution`
  ADD PRIMARY KEY (`id`),
  ADD KEY `student_id` (`status_id`);

--
-- Индексы таблицы `is_status`
--
ALTER TABLE `is_status`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `is_survey`
--
ALTER TABLE `is_survey`
  ADD PRIMARY KEY (`id`),
  ADD KEY `group_id` (`group_id`),
  ADD KEY `discipline_id` (`discipline_id`);

--
-- Индексы таблицы `is_team`
--
ALTER TABLE `is_team`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_Id` (`user_id`),
  ADD KEY `project_id` (`project_id`);

--
-- Индексы таблицы `is_test`
--
ALTER TABLE `is_test`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `is_testresult`
--
ALTER TABLE `is_testresult`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_Id` (`user_Id`);

--
-- Индексы таблицы `is_user`
--
ALTER TABLE `is_user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `role` (`role_id`),
  ADD KEY `group_id` (`group_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `is_alert`
--
ALTER TABLE `is_alert`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT для таблицы `is_attachedfile`
--
ALTER TABLE `is_attachedfile`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT для таблицы `is_course`
--
ALTER TABLE `is_course`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `is_discipline`
--
ALTER TABLE `is_discipline`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT для таблицы `is_faculty`
--
ALTER TABLE `is_faculty`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT для таблицы `is_group`
--
ALTER TABLE `is_group`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `is_project`
--
ALTER TABLE `is_project`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=337;

--
-- AUTO_INCREMENT для таблицы `is_role`
--
ALTER TABLE `is_role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `is_score`
--
ALTER TABLE `is_score`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `is_solution`
--
ALTER TABLE `is_solution`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT для таблицы `is_status`
--
ALTER TABLE `is_status`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `is_survey`
--
ALTER TABLE `is_survey`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT для таблицы `is_team`
--
ALTER TABLE `is_team`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=290;

--
-- AUTO_INCREMENT для таблицы `is_test`
--
ALTER TABLE `is_test`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `is_testresult`
--
ALTER TABLE `is_testresult`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT для таблицы `is_user`
--
ALTER TABLE `is_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=143;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `is_alert`
--
ALTER TABLE `is_alert`
  ADD CONSTRAINT `is_alert_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `is_user` (`id`);

--
-- Ограничения внешнего ключа таблицы `is_group`
--
ALTER TABLE `is_group`
  ADD CONSTRAINT `is_group_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `is_course` (`id`),
  ADD CONSTRAINT `is_group_ibfk_2` FOREIGN KEY (`faculty_id`) REFERENCES `is_faculty` (`id`);

--
-- Ограничения внешнего ключа таблицы `is_project`
--
ALTER TABLE `is_project`
  ADD CONSTRAINT `is_project_ibfk_1` FOREIGN KEY (`discipline_id`) REFERENCES `is_discipline` (`id`),
  ADD CONSTRAINT `is_project_ibfk_2` FOREIGN KEY (`teacher_id`) REFERENCES `is_user` (`id`),
  ADD CONSTRAINT `is_project_ibfk_3` FOREIGN KEY (`student_Id`) REFERENCES `is_user` (`id`),
  ADD CONSTRAINT `is_project_ibfk_4` FOREIGN KEY (`step6`) REFERENCES `is_solution` (`id`),
  ADD CONSTRAINT `is_project_ibfk_5` FOREIGN KEY (`step4`) REFERENCES `is_solution` (`id`),
  ADD CONSTRAINT `is_project_ibfk_6` FOREIGN KEY (`step5`) REFERENCES `is_solution` (`id`),
  ADD CONSTRAINT `is_project_ibfk_7` FOREIGN KEY (`step3`) REFERENCES `is_solution` (`id`),
  ADD CONSTRAINT `is_project_ibfk_8` FOREIGN KEY (`step1`) REFERENCES `is_solution` (`id`),
  ADD CONSTRAINT `is_project_ibfk_9` FOREIGN KEY (`step2`) REFERENCES `is_solution` (`id`);

--
-- Ограничения внешнего ключа таблицы `is_score`
--
ALTER TABLE `is_score`
  ADD CONSTRAINT `is_score_ibfk_1` FOREIGN KEY (`discipline_id`) REFERENCES `is_discipline` (`id`),
  ADD CONSTRAINT `is_score_ibfk_2` FOREIGN KEY (`student_id`) REFERENCES `is_user` (`id`);

--
-- Ограничения внешнего ключа таблицы `is_solution`
--
ALTER TABLE `is_solution`
  ADD CONSTRAINT `is_solution_ibfk_1` FOREIGN KEY (`status_id`) REFERENCES `is_status` (`id`);

--
-- Ограничения внешнего ключа таблицы `is_survey`
--
ALTER TABLE `is_survey`
  ADD CONSTRAINT `is_survey_ibfk_1` FOREIGN KEY (`group_id`) REFERENCES `is_group` (`id`),
  ADD CONSTRAINT `is_survey_ibfk_2` FOREIGN KEY (`discipline_id`) REFERENCES `is_discipline` (`id`);

--
-- Ограничения внешнего ключа таблицы `is_team`
--
ALTER TABLE `is_team`
  ADD CONSTRAINT `is_team_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `is_user` (`id`),
  ADD CONSTRAINT `is_team_ibfk_2` FOREIGN KEY (`project_id`) REFERENCES `is_project` (`id`);

--
-- Ограничения внешнего ключа таблицы `is_testresult`
--
ALTER TABLE `is_testresult`
  ADD CONSTRAINT `is_testresult_ibfk_1` FOREIGN KEY (`user_Id`) REFERENCES `is_user` (`id`);

--
-- Ограничения внешнего ключа таблицы `is_user`
--
ALTER TABLE `is_user`
  ADD CONSTRAINT `is_user_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `is_role` (`id`),
  ADD CONSTRAINT `is_user_ibfk_2` FOREIGN KEY (`group_id`) REFERENCES `is_group` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
