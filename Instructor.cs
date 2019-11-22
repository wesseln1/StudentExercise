using System;
using System.Collections.Generic;

namespace StudentExercise
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public string Specialty { get; set; }

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.StudentExercises.Add(exercise);
        }

        public Instructor(string firstName, string lastName, string slack, string specialty, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slack;
            Cohort = cohort;
            Specialty = specialty;
        }

    }
}