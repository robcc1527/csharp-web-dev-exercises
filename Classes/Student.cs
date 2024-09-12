using System;

namespace Classes;

public class Student
{
    private static int nextStudentId = 1;
    public string Name {  get; set; }
    public int studentId { get; set; }
    public int NumberOfCredits { get; set; } = 0;
    public double Gpa { get; set; } = 0.0;


    public Student(string name, int studentID, int NumbCredit, double gpa)
    {
        Name = name;
        studentId = studentID;
        NumberOfCredits = NumbCredit;
        Gpa = gpa;
    }

    public Student(string name, int studentId) : this(name, studentId, 0, 0.0) { }
    
    public Student(string name): this(name, nextStudentId)
    {
        nextStudentId++;
        //adding notes 
    }

}
