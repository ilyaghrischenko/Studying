--select Teachers.Name + ' ' + Teachers.Surname as 'ПІБ',
--	   count(Teachers.Surname) as 'К-сть лекцій'
--from Teachers,Lectures,Subjects
--where Teachers.Id=Lectures.TeacherId
--and Subjects.Id=Lectures.SubjectId
--group by Teachers.Name + ' ' + Teachers.Surname;

--select Teachers.Name + ' ' + Teachers.Surname as 'ПІБ',
--	   count(Teachers.Surname) as 'К-сть лекцій'
--from Teachers,Lectures,Subjects
--where Teachers.Id=Lectures.TeacherId
--and Subjects.Id=Lectures.SubjectId
--group by Teachers.Name + ' ' + Teachers.Surname
--having count(Teachers.Surname)>=2;

--select Faculties.name as 'Название',
--	   count(Departments.Id) as 'К-сть кафедр'
--from Departments,Faculties
--where Departments.FacultyId=Faculties.Id
--group by Faculties.Name;

--select Departments.Name as 'Назва кафедри',
--	   count(Groups.Id) as 'К-сть груп'
--from Groups,Departments
--where Groups.DepartmentId=Departments.Id
--group by Departments.Name;

--select Faculties.Name as 'Назва факультету',
--	   count(Groups.Id) as 'count'
--from Groups,Departments, Faculties
--where Groups.DepartmentId=Departments.Id
--and Departments.FacultyId=Faculties.Id
--group by Faculties.Name;

--select Faculties.Name as 'Назва фак',
--	   sum(distinct(Teachers.Salary)) as 'Фонд зп'
--from Faculties,Departments,Teachers,Groups,GroupsLectures,Lectures
--where Faculties.Id=Departments.FacultyId
--and Departments.Id=Groups.DepartmentId
--and Groups.Id=GroupsLectures.GroupId
--and GroupsLectures.LectureId=Lectures.Id
--and Lectures.TeacherId=Teachers.Id
--group by Faculties.Name;

--select Faculties.Name, 
--	   max(Departments.Financing) as 'Макс бюджет'
--from Faculties, Departments
--where Faculties.Id=Departments.FacultyId
--group by Faculties.Name;

--select Name,Surname,Salary
--from Teachers
--group by Name,Surname,Salary
--having Salary = (select max(salary) from Teachers);