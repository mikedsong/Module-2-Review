using System;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; set; } = new List<double>();

    public Student()
    {
    }

    public Student(string name, int id,  List<double> grades)
    {
        Name = name;
        ID = id;
        Grades = grades;
    }

    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }
    public void AddGrade(double[] grade)
    {
        Grades.AddRange(grade);
    }

    public double CalculateAverageGrade()
    {
        double sum = 0;
        foreach (var grade in Grades)
        {
            sum += grade;
            
        }
        return sum / Grades.Count;
        
    }
}