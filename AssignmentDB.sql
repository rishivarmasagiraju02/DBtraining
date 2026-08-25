create table school.students( student_id integer primary key ,first_name varchar(50) not null,last_name varchar (50) not null,email varchar(50) unique ,city varchar(50),joined_date Date );
create table school.courses( course_id integer primary key,course_name varchar(100) not null,instructor varchar(100), fee decimal (10,2))
create table school.enrollments( enrollement_id integer primary key, student_id integer,course_id integer,enrollment_date date, grade integer,
foreign key(student_id) references school.students(student_id),
foreign key(course_id) references school.courses(course_id))

INSERT INTO school.students
(student_id, first_name, last_name, email, city, joined_date)
VALUES
(1, 'John', 'Smith', 'john.smith@gmail.com', 'Dallas', '2026-01-10'),
(2, 'Amy', 'Jones', 'amy.jones@gmail.com', 'Chicago', '2026-02-15'),
(3, 'David', 'Lee', 'david.lee@gmail.com', 'Kansas City', '2026-03-20'),
(4, 'Sara', 'Wilson', 'sara.wilson@gmail.com', 'Houston', '2026-04-05'),
(5, 'Mike', 'Brown', 'mike.brown@gmail.com', 'Austin', '2026-05-12');

select* from school.students

INSERT INTO school.courses
(course_id, course_name, instructor, fee)
VALUES
(101, 'PostgreSQL', 'David', 600.00),
(102, 'Java', 'Robert', 750.00),
(103, 'C#', 'Michael', 550.00),
(104, '.NET', 'Sarah', 500.00);

select* from school.courses

INSERT INTO school.enrollments
(enrollment_id, student_id, course_id, enrollment_date, grade)
VALUES
(1, 1, 101, '2026-06-01', 90),
(2, 1, 102, '2026-06-02', 85),
(3, 2, 101, '2026-06-03', 88),
(4, 2, 103, '2026-06-04', 92),
(5, 3, 102, '2026-06-05', 80),
(6, 3, 104, '2026-06-06', 87),
(7, 4, 101, '2026-06-07', 91),
(8, 4, 104, '2026-06-08', 89);

alter table school.enrollments rename column enrollement_id to enrollment_id;
select* from school.enrollments;

insert into school.students(student_id,first_name,last_name,email,city,joined_date)
values (6,'Emma','davis','emma.davis@gmail.com','boston','2026-07-01');

update school.students set city='New york' where student_id=2;
SELECT *
FROM school.students
WHERE student_id = 2;

update school.courses set fee=800.00 where course_id=102;

delete from school.enrollments where enrollment_id=8;
SELECT *
FROM school.enrollments
ORDER BY enrollment_id;

SELECT *
FROM school.students;
select first_name,last_name,email from school.students s
select* from school.students;
select*from school.courses where fee>500;
select*from school.courses order by fee desc;
select avg(fee) as average_fee from school.courses;
select min(fee) as minimum_fee,max(fee) as maximum_fee from school.courses;
select count(*) as total_students from school.students;
select course_id,count(student_id) as total_students from school.enrollments group by course_id;
select s.first_name,s.last_name,c.course_id,c.instructor,e.grade from school.students s join school.enrollments e on s.student_id=e.student_id join school.courses c on e.course_id=c.course_id;

SELECT
    s.first_name,
    s.last_name,
    c.course_name,
    c.instructor,
    e.grade
FROM school.students s
JOIN school.enrollments e
    ON s.student_id = e.student_id
JOIN school.courses c
    ON e.course_id = c.course_id;



SELECT s.first_name, s.last_name, e.grade
FROM school.students s
JOIN school.enrollments e
    ON s.student_id = e.student_id
ORDER BY e.grade DESC
LIMIT 1;


SELECT
    c.course_name,
    AVG(e.grade) AS average_grade
FROM school.courses c
JOIN school.enrollments e
    ON c.course_id = e.course_id
GROUP BY c.course_name;



SELECT
    s.student_id,
    s.first_name,
    s.last_name,
    COUNT(e.course_id) AS number_of_courses
FROM school.students s
JOIN school.enrollments e
    ON s.student_id = e.student_id
GROUP BY s.student_id, s.first_name, s.last_name
HAVING COUNT(e.course_id) > 1;


SELECT
    s.student_id,
    s.first_name,
    s.last_name
FROM school.students s
LEFT JOIN school.enrollments e
    ON s.student_id = e.student_id
WHERE e.student_id IS NULL;


SELECT *
FROM school.courses
ORDER BY fee DESC
LIMIT 1;