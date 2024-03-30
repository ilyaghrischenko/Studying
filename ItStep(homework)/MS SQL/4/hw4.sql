--Вивести кількість викладачів кафедри "Кафедра економіки"
--select Teachers.Name,count(Teachers.Name)
--from Teachers,Lectures,GroupsLectures,Groups,Departments
--where Lectures.TeacherId=Teachers.Id 
--and Lectures.Id=GroupsLectures.LectureId
--and GroupsLectures.GroupId=Groups.Id
--and Groups.DepartmentId=Departments.Id
--and Departments.Name='Кафедра економіки'
--group by Teachers.Name

--Вивести кількість лекцій, які читає викладач “Йовілла	Бадлак”.
--select count(Subjects.Id),Teachers.Name
--from Teachers,Lectures,Subjects
--where Lectures.TeacherId=Teachers.Id 
--and Lectures.SubjectId=Subjects.Id
--and Teachers.Name='Йовілла' and Teachers.Surname='Бадлак'
--group by Teachers.Name

--Вивести кількість занять, які проводяться в аудиторії “510”.
--select count(Subjects.Id),Subjects.Name
--from Subjects,Lectures
--where Lectures.SubjectId=Subjects.Id 
--and Lectures.LectureRoom='510'
--group by Subjects.Name

--Вивести назви аудиторій та кількість лекцій, що прово-
--дяться в них.
--select Lectures.LectureRoom,count(Subjects.Id)
--from Lectures,Subjects
--where Lectures.SubjectId=Subjects.Id 
--group by Lectures.LectureRoom

--5. Вивести кількість студентів, які відвідують лекції викладача “Святополк Ружицький”.
--??????????
--select Teachers.Name,Teachers.Surname
--from Teachers
--where Teachers.Name='Святополк'and Teachers.Surname='Ружицький'

--Вивести середню ставку викладачів факультету Computer Science.
--select Teachers.Name,avg(Teachers.Salary)
--from Teachers,Lectures,GroupsLectures,Groups,Departments,Faculties
--where Lectures.TeacherId=Teachers.Id 
--and Lectures.Id=GroupsLectures.LectureId
--and GroupsLectures.GroupId=Groups.Id
--and Groups.DepartmentId=Departments.Id
--and Departments.FacultyId=Faculties.Id
--and Faculties.Name='Факультет права'
--group by Teachers.Name

--7. Вивести мінімальну та максимальну кількість студентів
--серед усіх груп.
--???????????

--Вивести середній фонд фінансування кафедр.
--select avg(Departments.Financing)
--from Departments

--Вивести повні імена викладачів та кількість читаних ними дисциплін.
--select Teachers.Name+' '+Teachers.Surname as'Teacher',count(Subjects.Name)
--from Teachers,Lectures,Subjects
--where Lectures.TeacherId=Teachers.Id 
--and Lectures.SubjectId=Subjects.Id
--group by Teachers.Name+' '+Teachers.Surname 

--Вивести кількість лекцій щодня протягом тижня.
--select GroupsLectures.DayOfWeek,Count(Subjects.Name)
--from GroupsLectures,Lectures,Subjects
--where Lectures.SubjectId=Subjects.Id
--and GroupsLectures.LectureId=Lectures.Id
--group by GroupsLectures.DayOfWeek

--Вивести номери аудиторій та кількість кафедр, чиї лекції в них читаються.
--select Lectures.LectureRoom,Count(Departments.Name)
--from Lectures,GroupsLectures,Groups,Departments
--where Lectures.Id=GroupsLectures.LectureId
--and GroupsLectures.GroupId=Groups.Id
--and Groups.DepartmentId=Departments.Id
--group by Lectures.LectureRoom

--Вивести назви факультетів та кількість дисциплін, які на
--них читаються.
--select Faculties.Name,Count(Subjects.Name)
--from Subjects,Lectures,GroupsLectures,Groups,Departments,Faculties
--where Lectures.SubjectId=Subjects.Id
--and Lectures.Id=GroupsLectures.LectureId
--and GroupsLectures.GroupId=Groups.Id
--and Groups.DepartmentId=Departments.Id
--and Departments.FacultyId=Faculties.Id
--group by Faculties.Name

--Вивести кількість лекцій для кожної пари викладач-аудиторія.
--select count(Subjects.Name),Teachers.Name+' '+Teachers.Surname,Lectures.LectureRoom
--from Subjects,Lectures,Teachers
--where Lectures.SubjectId=Subjects.Id
--and Lectures.TeacherId=Teachers.Id
--group by Teachers.Name+' '+Teachers.Surname,Lectures.LectureRoom