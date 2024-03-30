--¬ивести номери корпус≥в, €кщо сумарний фонд ф≥нансуванн€ розташованих у них кафедр перевищуЇ 100 000.

--SELECT DISTINCT Building 
--FROM Departments 
--GROUP BY Building 
--HAVING SUM(Financing) > 100000;

--¬ивести назви груп 5-го курсу кафедри УSoftware DevelopmentФ, €к≥ мають понад 10 пар на перший тиждень.

--SELECT DISTINCT G.Name 
--FROM Groups G
--JOIN GroupsLectures GL ON G.Id = GL.GroupId
--JOIN Lectures L ON GL.LectureId = L.Id
--JOIN Subjects S ON L.SubjectId = S.Id
--JOIN Departments D ON G.DepartmentId = D.Id
--WHERE G.Year = 5 
--AND D.Name = 'Software Development'
--AND DATEPART(dw, L.Date) = 2
--GROUP BY G.Name
--HAVING COUNT(*) > 10;

--¬ивести назви груп, €к≥ мають рейтинг б≥льший, н≥ж рейтинг групи УD221Ф.

--SELECT G.Name 
--FROM Groups G
--JOIN Students S ON G.Id = S.GroupId
--WHERE AVG(S.Rating) > (SELECT AVG(S2.Rating) FROM Students S2 WHERE S2.GroupId = (SELECT Id FROM Groups WHERE Name = 'D221'));

--¬ивести пр≥звища та ≥мена викладач≥в, ставка €ких вища за середню ставку професор≥в.

--SELECT Name, Surname 
--FROM Teachers 
--WHERE Salary > (SELECT AVG(Salary) FROM Teachers WHERE IsProfessor = 1);

--¬ивести назви груп, €к≥ мають б≥льше одного куратора.

--SELECT G.Name 
--FROM Groups G
--JOIN GroupsCurators GC ON G.Id = GC.GroupId
--GROUP BY G.Name
--HAVING COUNT(*) > 1;

--¬ивести назви груп, €к≥ мають рейтинг менший, н≥ж м≥н≥мальний рейтинг груп 5-го курсу.

--SELECT G.Name 
--FROM Groups G
--JOIN Students S ON G.Id = S.GroupId
--WHERE G.Year = 5
--AND AVG(S.Rating) < (SELECT MIN(AVG(S2.Rating)) FROM Students S2 JOIN Groups G2 ON S2.GroupId = G2.Id WHERE G2.Year = 5 GROUP BY G2.Id);

--¬ивести назви факультет≥в, сумарний фонд ф≥нансуванн€ кафедр €ких б≥льший за сумарний фонд ф≥нансуванн€ кафедр факультету УComputer ScienceФ.

--SELECT F.Name 
--FROM Faculties F
--JOIN Departments D ON F.Id = D.FacultyId
--GROUP BY F.Name
--HAVING SUM(D.Financing) > (SELECT SUM(D2.Financing) FROM Departments D2 JOIN Faculties F2 ON D2.FacultyId = F2.Id WHERE F2.Name = 'Computer Science');

--¬ивести назви дисципл≥н та повн≥ ≥мена викладач≥в, €к≥ читають найб≥льшу к≥льк≥сть лекц≥й з них.

--SELECT S.Name AS Discipline, T.Name + ' ' + T.Surname AS TeacherName 
--FROM Subjects S
--JOIN Lectures L ON S.Id = L.SubjectId
--JOIN Teachers T ON L.TeacherId = T.Id
--GROUP BY S.Name, T.Name, T.Surname
--HAVING COUNT(*) = (SELECT MAX(LectureCount) FROM (SELECT COUNT(*) AS LectureCount FROM Lectures GROUP BY SubjectId) AS LectureCounts);

--¬ивести назву дисципл≥ни, за €кою читаЇтьс€ найменше лекц≥й.

--SELECT S.Name AS Discipline
--FROM Subjects S
--JOIN Lectures L ON S.Id = L.SubjectId
--GROUP BY S.Name
--HAVING COUNT(*) = (SELECT MIN(LectureCount) FROM (SELECT COUNT(*) AS LectureCount FROM Lectures GROUP BY SubjectId) AS LectureCounts);

--¬ивести к≥льк≥сть студент≥в та дисципл≥н, що читаютьс€ на кафедр≥ УSoftware DevelopmentФ.

--SELECT COUNT(*) AS StudentCount, COUNT(DISTINCT L.SubjectId) AS DisciplineCount
--FROM Groups G
--JOIN Students S ON G.Id = S.GroupId
--JOIN Departments D ON G.DepartmentId = D.Id
--JOIN Lectures L ON D.Id = L.SubjectId
--WHERE D.Name = 'Software Development';
