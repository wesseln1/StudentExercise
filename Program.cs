using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Cohort cohort32 = new Cohort("Cohort 32");
            Cohort cohort33 = new Cohort("Cohort 33");
            Cohort cohort34 = new Cohort("Cohort 34");
            Cohort cohort35 = new Cohort("Cohort 35");

            Student student1 = new Student("Nick", "Wessel", "wesseln1", cohort32);
            Student student2 = new Student("Dave", "Cornish", "heidi1", cohort32);
            Student student3 = new Student("Heidi", "Smith", "smith1", cohort32);
            Student student4 = new Student("Mark", "McCann", "mccann1", cohort33);
            Student student5 = new Student("Seth", "Williams", "willIam", cohort34);
            Student student6 = new Student("Keaton", "Heights", "higherThanKeaton", cohort34);
            Student student7 = new Student("Phil", "Philly", "PhillyPhil", cohort35);
            Student student8 = new Student("Stephan", "Walgreens", "Walgreens1", cohort35);
            Student student9 = new Student("James", "Kay", "KayJames", cohort35);

            Instructor AdamSheaffer = new Instructor("Adam", "Sheaffer", "adam-sheaffer", "back-end", cohort32);
            Instructor BrendaLong = new Instructor("Brenda", "Long", "brenda-long", "front-end", cohort33);
            Instructor MoSilvera = new Instructor("Mo", "Silvera", "mo-silvera", "front-end", cohort34);
            Instructor MadiPiper = new Instructor("Mady", "Piper", "madi-piper", "back-end", cohort35);

            Exercise exercise1 = new Exercise("Create a for each loop.", "JS");
            Exercise exercise2 = new Exercise("Stylize the index.", "CSS");
            Exercise exercise3 = new Exercise("Develop an app.", "React");
            Exercise exercise4 = new Exercise("Build a website.", "HTML");
            Exercise exercise5 = new Exercise("Study If Else stataments", "JS");

            List<Student> students = new List<Student>()
            {
                student1,
                student2,
                student3,
                student4,
                student5,
                student6,
                student7,
                student8,
                student9
            };

            List<Cohort> cohorts = new List<Cohort>()
            {
                cohort32,
                cohort33,
                cohort34,
                cohort35
            };

            List<Instructor> instructors = new List<Instructor>()
            {
                AdamSheaffer,
                BrendaLong,
                MadiPiper,
                MoSilvera
            };

            List<Exercise> exercises = new List<Exercise>()
            {
                exercise1,
                exercise2,
                exercise3,
                exercise4,
                exercise5
            };

            cohort32.CohortStudents.Add(student1);
            cohort32.CohortStudents.Add(student2);
            cohort32.CohortStudents.Add(student3);
            cohort33.CohortStudents.Add(student4);
            cohort34.CohortStudents.Add(student5);
            cohort34.CohortStudents.Add(student6);
            cohort35.CohortStudents.Add(student7);
            cohort35.CohortStudents.Add(student8);
            cohort35.CohortStudents.Add(student9);

            cohort32.CohortInstructors.Add(AdamSheaffer);
            cohort33.CohortInstructors.Add(BrendaLong);
            cohort34.CohortInstructors.Add(MoSilvera);
            cohort35.CohortInstructors.Add(MadiPiper);

            AdamSheaffer.AssignExercise(student1, exercise5);
            AdamSheaffer.AssignExercise(student1, exercise3);
            AdamSheaffer.AssignExercise(student2, exercise1);
            AdamSheaffer.AssignExercise(student3, exercise1);
            BrendaLong.AssignExercise(student4, exercise2);
            MoSilvera.AssignExercise(student5, exercise3);
            MoSilvera.AssignExercise(student6, exercise3);
            MadiPiper.AssignExercise(student7, exercise4);
            MadiPiper.AssignExercise(student8, exercise4);

            Console.WriteLine();
            Console.WriteLine("Student Reports");
            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
                Console.WriteLine($"From: {student.Cohort.Name}");
                Console.WriteLine();
                foreach (var exercise in student.StudentExercises)
                {
                    Console.WriteLine($"Exercise: {exercise.Name}");
                    Console.WriteLine($"Language: {exercise.Language}");
                    Console.WriteLine();
                }

                List<Exercise> javaScriptExercises = exercises.Where(exercise => exercise.Language == "JS").ToList();

                foreach (var exercise in javaScriptExercises)
                {
                    Console.WriteLine($"{exercise.Name} is a {exercise.Language} language!");
                }

                List<Student> cohortStudents = students.Where(student => student.Cohort.Name == "Cohort 35").ToList();

                Console.WriteLine($"Cohort Student List: ");
                Console.WriteLine();
                foreach (var cohortStudent in cohortStudents)
                {
                    Console.WriteLine($"{cohortStudent.FirstName} {cohortStudent.LastName}");
                    Console.WriteLine();
                }

                List<Instructor> cohortInstructors = instructors.Where(instructor => instructor.Cohort.Name == "Cohort 35").ToList();

                Console.WriteLine($"Instructor: ");
                foreach (var cohortInstructor in cohortInstructors)
                {
                    Console.WriteLine($"{cohortInstructor.FirstName} {cohortInstructor.LastName}");
                    Console.WriteLine();
                }

                var orderedStudnetList = students.OrderBy(student => student.LastName);

                foreach (var s in orderedStudnetList)
                {
                    Console.WriteLine($"{s.LastName}, {s.FirstName}");
                }
                Console.WriteLine();

                var noExercises = students.Where(student => student.StudentExercises.Count == 0);

                Console.WriteLine("Currently no exercises assigned:");
                foreach (var s in noExercises)
                {
                    Console.WriteLine($"{s.FirstName} {s.LastName}");
                }

                var studentWithMostExercises = students.Select(student => new
                {
                    firstName = student.FirstName,
                        lastName = student.LastName,
                        numberOfExercises = student.StudentExercises.Count()
                }).OrderByDescending(ex => ex.numberOfExercises).FirstOrDefault();

                Console.WriteLine();
                Console.WriteLine($"{studentWithMostExercises.firstName} {studentWithMostExercises.lastName} has the most active assignments!");

                foreach (var cohort in cohorts)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{cohort.Name}:");
                    Console.WriteLine($"{cohort.CohortStudents.Count}");
                }
            }
        }
    }
}