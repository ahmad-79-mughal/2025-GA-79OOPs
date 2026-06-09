using System;

class Person
{
    protected string name;
    protected string address;

    public Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    public string getName()
    {
        return name;
    }

    public string getAddress()
    {
        return address;
    }

    public void setAddress(string address)
    {
        this.address = address;
    }

    public override string ToString()
    {
        return "Person[name=" + name + ", address=" + address + "]";
    }
}

class Student : Person
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

    public string getProgram()
    {
        return program;
    }

    public void setProgram(string program)
    {
        this.program = program;
    }

    public int getYear()
    {
        return year;
    }

    public void setYear(int year)
    {
        this.year = year;
    }

    public double getFee()
    {
        return fee;
    }

    public void setFee(double fee)
    {
        this.fee = fee;
    }

    public override string ToString()
    {
        return "Student[" + base.ToString() + ", program=" + program + ", year=" + year + ", fee=" + fee + "]";
    }
}

class Staff : Person
{
    private string school;
    private double pay;

    public Staff(string name, string address, string school, double pay)
        : base(name, address)
    {
        this.school = school;
        this.pay = pay;
    }

    public string getSchool()
    {
        return school;
    }

    public void setSchool(string school)
    {
        this.school = school;
    }

    public double getPay()
    {
        return pay;
    }

    public void setPay(double pay)
    {
        this.pay = pay;
    }

    public override string ToString()
    {
        return "Staff[" + base.ToString() + ", school=" + school + ", pay=" + pay + "]";
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Ali", "Lahore", "BSCS", 2, 120000);
        Staff st = new Staff("Ahmed", "Lahore", "CS Dept", 80000);

        Console.WriteLine(s.ToString());
        Console.WriteLine(st.ToString());
    }
}