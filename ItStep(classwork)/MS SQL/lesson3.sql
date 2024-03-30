--select Groups.*, Curators.* from Groups,Curators,GroupsCurators
--where Groups.Id=GroupsCurators.GroupId
--and GroupsCurators.CuratorId=Curators.Id
--and Groups.Year=5;

--select Departments.Name,Faculties.Name
--from Faculties,Departments
--where Faculties.Id=Departments.FacultyId;

--select Groups.Name,Subjects.Name
--from Groups,GroupsLectures,Lectures,Subjects
--where Groups.Id=GroupsLectures.GroupId
--and GroupsLectures.LectureId=Lectures.Id
--and Lectures.SubjectId=Subjects.Id
--and Groups.Name='AT03-22';

--select distinct(Subjects.Name),Teachers.Name+' '+Teachers.Surname
--from Teachers,Lectures,Subjects
--where Subjects.Id=Lectures.SubjectId
--and Lectures.TeacherId=Teachers.Id