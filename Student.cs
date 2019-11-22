using System;
using System.Collections.Generic;

namespace StudentExercise
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        public List<Exercise> StudentExercises = new List<Exercise>();

        public Student(string firstName, string lastName, string slack, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slack;
            Cohort = cohort;
        }

    }
}