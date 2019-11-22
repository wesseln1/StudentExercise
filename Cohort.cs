using System;
using System.Collections.Generic;

namespace StudentExercise
{
    public class Cohort
    {
        public string Name { get; set; }

        public List<Student> CohortStudents = new List<Student>();
        public List<Instructor> CohortInstructors = new List<Instructor>();

        public Cohort(string name)
        {
            Name = name;
        }

    }
}