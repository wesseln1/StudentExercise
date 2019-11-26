using System;

namespace StudentExercise
{
    public interface IPerson
    {
        Cohort Cohort { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}