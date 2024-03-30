--Вивести всі можливі пари рядків викладачів та груп.
--select distinct Groups.Name,Teachers.Name
--from Teachers,Lectures,GroupsLectures,Groups
--where Lectures.TeacherId=Teachers.Id 
--and Lectures.Id=GroupsLectures.LectureId
--and GroupsLectures.GroupId=Groups.Id

--Вивести назви факультетів, фонд фінансування кафедр
--яких перевищує фонд фінансування факультету.
--select distinct Faculties.Name
--from Faculties,Departments
--where Faculties.Id=Departments.FacultyId and Departments.Financing>Faculties.Financing

--Вивести прізвища кураторів груп та назви груп, які вони курирують.
--select Curators.Surname,Groups.Name
--from Curators,GroupsCurators,Groups
--where Curators.Id=GroupsCurators.CuratorId
--and Groups.Id=GroupsCurators.GroupId

--Вивести імена та прізвища викладачів, які читають лекції у групі “UR01-21”.
--select distinct Teachers.Name+' '+Teachers.Surname as 'Teacher',Groups.Name
--from Teachers,Lectures,GroupsLectures,Groups
--where Lectures.TeacherId=Teachers.Id 
--and Lectures.Id=GroupsLectures.LectureId
--and GroupsLectures.GroupId=Groups.Id
--and Groups.Name='UR01-21'

--Вивести прізвища викладачів та назви факультетів, на яких
--вони читають лекції
--select distinct Teachers.Surname,Faculties.Name
--from Teachers,Lectures,GroupsLectures,Groups,Departments,Faculties
--where Lectures.TeacherId=Teachers.Id 
--and Lectures.Id=GroupsLectures.LectureId
--and GroupsLectures.GroupId=Groups.Id
--and Groups.DepartmentId=Departments.Id
--and Departments.FacultyId=Faculties.Id

--Вивести назви кафедр та назви груп, які до них належать.
--select Departments.Name,Groups.Name
--from Groups,Departments
--where Groups.DepartmentId=Departments.Id

--Вивести назви дисциплін, які читає викладач “В`ячеслав Желіба”.
--select Subjects.Name,Teachers.Name,Teachers.Surname
--from Teachers,Lectures,Subjects
--where Teachers.Id=Lectures.TeacherId
--and Lectures.SubjectId=Subjects.Id
--and Teachers.Name='В`ячеслав' and Teachers.Surname= 'Желіба'

--Вивести назви кафедр, де читається дисципліна “Економіка”.
--select Departments.Name
--from Subjects ,Lectures,GroupsLectures,Groups,Departments
--where Lectures.SubjectId=Subjects.Id
--and Lectures.Id=GroupsLectures.LectureId
--and GroupsLectures.GroupId=Groups.Id
--and Groups.DepartmentId=Departments.Id
--and Subjects.Name='Економіка'

--Вивести назви груп, що належать до факультету Факультет економіки і управління.
--select Groups.Name
--from Faculties,Departments,Groups
--where  Groups.DepartmentId=Departments.Id
--and Departments.FacultyId=Faculties.Id
--and Faculties.Name='Факультет економіки і управління'

--Вивести назви груп 5-го курсу, а також назву факультетів,
--до яких вони належать.
--select Groups.Name,Faculties.Name
--from Faculties,Departments,Groups
--where  Groups.DepartmentId=Departments.Id
--and Departments.FacultyId=Faculties.Id
--and Groups.Year=5

--Вивести повні імена викладачів та лекції, які вони читають (назви дисциплін та груп), причому відібрати лише ті
--лекції, що читаються в аудиторії “510”.
--select Teachers.Name+' '+Teachers.Surname,Subjects.Name
--from Teachers,Lectures,Subjects
--where Lectures.SubjectId=Subjects.Id 
--and Lectures.TeacherId=Teachers.Id
--and Lectures.LectureRoom=510