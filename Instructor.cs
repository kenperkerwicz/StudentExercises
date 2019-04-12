using System;
using System.Collections.Generic;



namespace StudentExercises {
class Instructor
{
  public string firstName {get; set;}
  public string lastName {get; set;}
  public string slackHandle {get; set;}
  public Cohort instructorCohort {get; set;}

  public Exercise Exercise {get; set;}


public void ExerciseAssignment(Student student, Exercise exercise) {
  student.exercises.Add(exercise);
}

} }