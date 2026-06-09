using System;

class Circle
{
    protected double radius = 1.0;
    protected string color = "red";

    public Circle() { }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    public double getRadius()
    {
        return radius;
    }

    public void setRadius(double radius)
    {
        this.radius = radius;
    }

    public string getColor()
    {
        return color;
    }

    public void setColor(string color)
    {
        this.color = color;
    }

    public virtual double getArea()
    {
        return Math.PI * radius * radius;
    }

    public override string ToString()
    {
        return "Circle[radius=" + radius + ", color=" + color + "]";
    }
}

class Cylinder : Circle
{
    private double height = 1.0;

    public Cylinder() { }

    public Cylinder(double radius) : base(radius) { }

    public Cylinder(double radius, double height) : base(radius)
    {
        this.height = height;
    }

    public Cylinder(double radius, double height, string color)
        : base(radius, color)
    {
        this.height = height;
    }

    public double getHeight()
    {
        return height;
    }

    public void setHeight(double height)
    {
        this.height = height;
    }

    public double getVolume()
    {
        return getArea() * height;
    }

    public override string ToString()
    {
        return "Cylinder[ " + base.ToString() + ", height=" + height + " ]";
    }
}

class Program
{
    static void Main()
    {
        Cylinder c = new Cylinder(3, 5, "blue");

        Console.WriteLine(c.ToString());
        Console.WriteLine("Area: " + c.getArea());
        Console.WriteLine("Volume: " + c.getVolume());
    }
}