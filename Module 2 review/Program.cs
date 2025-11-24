using System.Data.Common;

namespace Module_2_review;

public class Program
{
    static void Main(string[] args)
    {
       List<Student> students = new List<Student>();
       string ListOfGrades="";
       Student student1 = new Student("Carl", 5967839, new List<double>());
       Student student2 = new Student("Jesse", 3297420, new List<double>());
       Student student3 = new Student("Mike", 1294923, new List<double>());
       Student student4 = new Student("Jack", 2395547, new List<double>());
       students.Add(student1);
       students.Add(student2);
       students.Add(student3);
       students.Add(student4);
       student1.AddGrade(98.5);
       student1.AddGrade([89.7, 92.9, 98.6]);
       student2.AddGrade(96.6);
       student2.AddGrade([88.6, 99.7, 88.6]);
       student3.AddGrade(78.9);
       student3.AddGrade([95.4, 85.2, 79.0]);
       student4.AddGrade(84.5);
       student4.AddGrade([87.7, 86.4, 95.6]);
       foreach (var student in students)
       {
           foreach (var grade in student.Grades)
           {
               ListOfGrades += grade;
               ListOfGrades += ", ";
           }
           Console.WriteLine($"Student {student.Name} has id of {student.ID} and has grade of {ListOfGrades} and the average grade is {student.CalculateAverageGrade()}");
           ListOfGrades = "";
       }
    }
}