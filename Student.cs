using System;
using System.Collections.Generic;


namespace StudentExercises {

class Student
{
  public string firstName {get; set;}
  public string lastName {get; set;}
  public string slackHandle {get; set;}
  public Cohort cohort {get; set;}

  public List <Exercise> exercises {get; set;} = new List<Exercise>();

//   public Student(string firstName, string lastName, string slackHandle, Cohort cohort) {


//  }



}}