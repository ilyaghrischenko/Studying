--select Name + ' ' + Surname as 'PIB', max(Salary) as 'Salary'
--from Teachers
--group by Name,Surname,Salary
--having Salary = (select max(Salary) from Teachers)

--select Name, Surname, (select avg(Salary) from Teachers) as avgSalary
--from Teachers

--select Name, Surname, Salary
--from Teachers
--group by Name, Surname, Salary
--having Salary = (select max(Salary) from Teachers)

--select Building, sum(Financing) as fin
--from Departments
--group by Financing
--having sum(Financing) > 100000

--select *
--from Groups, Lectures, GroupsLectures
--where Groups.Id=GroupsLectures.GroupId
--and GroupsLectures.LectureId =Lectures.Id
--and (Groups.Year = 4 or Groups.Year = 5)
--and Lectures.Date between '2023-06-08' and '2023-06-21'
--order by Date

select Groups.Name, avg(Students.Rating)
from Groups, Students, GroupsStudents
where Groups.Id=GroupsStudents.GroupId
and GroupsStudents.StudentId=Students.Id
group by Groups.Name
having avg(Students.Rating) > 
		(select avg(Students.Rating)
		from Groups, Students, GroupsStudents
		where Groups.Id=GroupsStudents.GroupId
		and GroupsStudents.StudentId=Students.Id
		and Groups.Name='ET01-19')