using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Student
{
    public string Name;
    public int RollNumber;
    public float CGPA;
    public int MatricMarks;
    public int FSCMarks;
    public int ECATMarks;
    public bool isHostelite;
    public bool isScholarship;

    public Student(string name, int roll, float cgpa, int matric, int fsc, int ecat)
    {
        Name = name;
        RollNumber = roll;
        CGPA = cgpa;
        MatricMarks = matric;
        FSCMarks = fsc;
        ECATMarks = ecat;
    }

    public float CalculateMerit()
    {
        return (MatricMarks * 0.3f) + (FSCMarks * 0.3f) + (ECATMarks * 0.4f);
    }

    public bool IsEligibleForScholarship()
    {
        return CalculateMerit() > 80;
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Ali", 1, 3.5f, 900, 850, 300);

        Console.WriteLine(s.CalculateMerit());
        Console.WriteLine(s.IsEligibleForScholarship());
    }
}