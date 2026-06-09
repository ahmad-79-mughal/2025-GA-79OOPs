using System;
class circle
{
    protected double radius = 1.0;
    protected string color = "red";
    public circle()
    {

    }
    public circle(double radius)
    {
        this.radius = radius;
    }
    public circle(double radius, string color)
    {
        this.radius=radius;
        this.color = color;
    }
    public double Getradius()
    {
        return radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override string ToString()
    {
        return "Circle[radius={radius}, color={color}]";
    }
}

class Cylinder : circle
{
    private double height = 1.0;
    public Cylinder() : base()
    {
    }
    public Cylinder(double radius) : base(radius)
    {
    }
    public Cylinder(double radius, double height) : base(radius)
    {
        this.height = height;
    }
    public Cylinder(double radius, double height, string color) : base(radius, color)
    {
        this.height = height;
    }

    public double GetHeight()
    {
        return height;
    }
     public void SetHeight(double height)
    {
        this.height = height;
    }
    public double GetVolume()
    {
        return GetArea() * height;
    }
    public override string ToString()
    {
        return "Cylinder[{base.ToString()}, height={height}]";
    }
}
class program
{
    static void Main()
    {
        Cylinder c1 = new Cylinder();
        Console.WriteLine("cylinder 1 volume is " + c1.GetVolume());
        Cylinder c2=new Cylinder(3,7);
        Console.WriteLine("cylinder 2 volume is " + c2.GetVolume());
        Cylinder c3 = new Cylinder(2.5,10,"blue");
        Console.WriteLine("cylinder 3 volume is " + c3.GetVolume());

    }



}


