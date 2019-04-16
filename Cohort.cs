using System;
using System.Collections.Generic;



namespace StudentExercises {
class Cohort
{
  public string Cohortname {get; set;}

// a COLLECTION of students in the cohort

    public List <Student> studentList {get; set;} = new List<Student>();


// a COLLECTION of instructors. not populated yet but the list is ready to be.
   public List <Instructor> instructors {get; set;} = new List <Instructor>();

  //  public Cohort(string name) {
  //       CohortName = name;
  //  }

public Cohort (string name) {
  Cohortname = name;
}

public Cohort() {
  
}

}
}