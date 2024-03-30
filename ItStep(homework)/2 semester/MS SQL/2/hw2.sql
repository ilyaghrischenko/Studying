--Вивести таблицю кафедр, але розташувати її поля у зворотному порядку.
--select Departments.Name 
--from Departments
--Order by Departments.ID desc;

--Вивести назви груп та їх рейтинги, використовуючи, як
--назви полів, що виводяться, “Group Name” та “Group Rating” відповідно.
--select Groups.Name,Groups.Rating
--from Groups

--Вивести для викладачів їхнє прізвище, відсоток ставки по
--відношенню до надбавки та відсоток ставки по відношенню
--до зарплати (сума ставки та надбавки).
--select Teachers.Surname,sum(Teachers.Salary+Teachers.Premium)as'sum'
--from Teachers
--Group by  Teachers.Surname

--Вивести таблицю факультетів у вигляді одного поля у такому форматі: “The dean of faculty [faculty] is [dean].”.
--select CONCAT('The dean of faculty ', faculties.name, ' is ',faculties.Dean, '.') as 'faculty info'
--from Faculties

--Вивести прізвища викладачів, які є професорами та ставка
--яких перевищує 1050.
--select Teachers.Surname
--from Teachers
--where Teachers.IsProfessor=1 and Teachers.Salary>1050

--Вивести назви кафедр, фонд фінансування яких менший
--за 11000 або більше 25000.
--select Departments.Name
--from Departments
--where Departments.Financing>25000or Departments.Financing<11000

--Вивести назви факультетів, окрім факультету “Факультет IT”.
--select Faculties.Name
--from Faculties
--where Faculties.Name!='Факультет ІТ'

--Вивести прізвища та посади викладачів, які не є професорами.
--select Teachers.Surname,Teachers.Position
--from Teachers
--where Teachers.IsProfessor!=1

--Вивести прізвища, посади, ставки та надбавки асистентів,
--у яких надбавка у діапазоні від 160 до 550.
--select Teachers.Surname,Teachers.Position,Teachers.Salary,Teachers.Premium
--from Teachers
--where Teachers.IsAssistant=1 and Teachers.Premium>160 and Teachers.Premium<550

--Вивести прізвища та ставки асистентів.
--select Teachers.Surname,Teachers.Salary
--from Teachers
--where Teachers.IsAssistant=1

--Вивести прізвища та посади викладачів, які були прийняті
--на роботу до 01.01.2000.
--select Teachers.Surname,Teachers.Position
--from Teachers
--where Teachers.EmploymentDate>'2000-01-01'

--Вивести назви кафедр, які в алфавітному порядку розміщуються 
--до кафедри “Кафедра обліку і фінансів”. Поле, що виводиться повинно мати назву “Name of Department”.
--select Departments.Name as 'Name of Department'
--from Departments
--where Departments.Name<'Кафедра обліку і фінансів'
--order by Departments.Name

--Вивести прізвища асистентів, які мають зарплату (сума
--ставки та надбавки) не більше 1200.
--select Teachers.Surname
--from Teachers
--where Teachers.IsAssistant=1 
--group by Teachers.Surname
--having sum(Teachers.Salary+Teachers.Premium)<1200

--Вивести назви груп 5-го курсу, які мають рейтинг у діапазоні від 2 до 4.
--select Groups.Name
--from Groups
--where Groups.Year=5 and Groups.Rating between 2 and 4

--Вивести прізвища асистентів зі ставкою менше 550 або
--надбавкою менше 200.
--select Teachers.Surname
--from Teachers
--where Teachers.IsAssistant=1 and Teachers.Salary<550 or Teachers.Premium<200