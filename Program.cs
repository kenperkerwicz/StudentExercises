using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //create 4 or more exercises

           Exercise firstEx = new Exercise() {
               language = "JavaScript"
           };
            Exercise secondEx = new Exercise() {
               language = "Python"
           };
            Exercise thirdEx = new Exercise() {
               language = "Ruby"
           };
            Exercise fourthEx = new Exercise() {
               language = "HTML"
           };



            //create cohorts//

           Cohort Cohort30 = new Cohort("Cohort 30");

           Cohort Cohort31 = new Cohort("Cohort 31");

           Cohort Cohort32 = new Cohort("Cohort 32");


            //create 4 or more students//


           Student Ken = new Student() {
                firstName = "Ken",
                lastName = "Perkerwicz",
                slackHandle = "kenPerkerwicz",
                cohort = Cohort30,

           };

           Student Chad = new Student() {
                firstName = "Chad",
                lastName = "Kroger",
                slackHandle = "chadKroger",
                cohort = Cohort31,
           };

           Student Bob = new Student() {
                firstName = "Bob",
                lastName = "Ross",
                slackHandle = "bobRoss",
                cohort = Cohort32,
           };

            Student Jeff = new Student() {
                firstName = "Jeff",
                lastName = "Goldblum",
                slackHandle = "jeffGoldblum",
                cohort = Cohort30
           };

// create instructors//

           Instructor Steven = new Instructor() {
                firstName = "Steven",
                lastName = "Brownlee",
                slackHandle = "steveB",
                instructorCohort = Cohort30,

           };

           Instructor Meg = new Instructor() {
                firstName = "Meg",
                lastName = "Ducharme",
                slackHandle = "MegD",
               instructorCohort = Cohort31
           };

           Instructor Biff = new Instructor() {
                firstName = "Biff",
                lastName = "Trump",
                slackHandle = "biffB",
                instructorCohort = Cohort31
           };


Biff.ExerciseAssignment(Bob, firstEx);
Biff.ExerciseAssignment(Bob, secondEx);


 List<Student> students = new List<Student>();

 students.Add(Ken);
 students.Add(Bob);

Cohort30.studentList.Add(Ken);
Cohort30.studentList.Add(Jeff);


foreach (Student student in Cohort30.studentList) {
 Console.WriteLine($"the students first name is {student.firstName}, and their last name is  {student.lastName}");
}

        }
    }
}
