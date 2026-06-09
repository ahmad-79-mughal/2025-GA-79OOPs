using System;
class person
{
    protected string name;
    protected string address;
    public person(string name, string address)
    {
        this.name = name;   
        this.address = address;
    }
    public void getname(string name)
    {
        this.name=name; 
    }
    public void getaddress(string address)
    {
        this.address = address;
    }
    public void setaddress(string address)
    {
        this.address = address; 
    }
    public override string  ToString()
    {
        return "person[name=?,address=?]";
    }

}
class Student : person
{
    private string program;
    private int year;
    private double fee;

    public Student(string name, string address, string program, int year, double fee)
        : base(name, address)
    {
        this.program = program;
        this.year = year;
        this.fee = fee;
    }

    public string GetProgram()
    {
        return program;
    }

    public void SetProgram(string program)
    {
        this.program = program;
    }

    public int GetYear()
    {
        return year;
    }

    public void SetYear(int year)
    {
        this.year = year;
    }

    public double GetFee()
    {
        return fee;
    }

    public void SetFee(double fee)
    {
        this.fee = fee;
    }

    public override string ToString()
    {
        return "Student[{base.ToString()}, program={program}, year={year}, fee={fee}]";
    }
}
class Staff : person
{
    private string school;
    private double pay;

    public Staff(string name, string address, string school, double pay)
        : base(name, address)
    {
        this.school = school;
        this.pay = pay;
    }

    public string GetSchool()
    {
        return school;
    }

    public void SetSchool(string school)
    {
        this.school = school;
    }

    public double GetPay()
    {
        return pay;
    }

    public void SetPay(double pay)
    {
        this.pay = pay;
    }

    public override string ToString()
    {
        return "Staff[{base.ToString()}, school={school}, pay={pay}]";
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Ali", "Lahore", "CS", 2, 50000);
        Student s2 = new Student("Ahmed", "Karachi", "IT", 3, 60000);
        Staff st1 = new Staff("Usman", "Islamabad", "Engineering", 80000);
        Staff st2 = new Staff("Hassan", "Multan", "Science", 75000);
        Console.WriteLine(s1.ToString());
        Console.WriteLine(s2.ToString());
        Console.WriteLine(st1.ToString());
        Console.WriteLine(st2.ToString());
    }
}