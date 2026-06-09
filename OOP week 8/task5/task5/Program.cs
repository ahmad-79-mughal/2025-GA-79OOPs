using System;

class Car
{
    protected string model;
    protected string color;
    protected double price;

    public Car(string model, string color, double price)
    {
        this.model = model;
        this.color = color;
        this.price = price;
    }

    public virtual double FuelConsumption(double distance)
    {
        return 0; // base case
    }

    public virtual void Show()
    {
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Price: " + price);
    }
}

class BMW : Car
{
    public BMW(string model, string color, double price)
        : base(model, color, price) { }

    public override double FuelConsumption(double distance)
    {
        return distance / 15; // BMW avg
    }

    public override void Show()
    {
        Console.WriteLine("=== BMW ===");
        base.Show();
    }
}

class Audi : Car
{
    public Audi(string model, string color, double price)
        : base(model, color, price) { }

    public override double FuelConsumption(double distance)
    {
        return distance / 12; // Audi avg
    }

    public override void Show()
    {
        Console.WriteLine("=== Audi ===");
        base.Show();
    }
}

class GLI : Car
{
    public GLI(string model, string color, double price)
        : base(model, color, price) { }

    public override double FuelConsumption(double distance)
    {
        return distance / 10; // GLI avg
    }

    public override void Show()
    {
        Console.WriteLine("=== GLI ===");
        base.Show();
    }
}

class Program
{
    static void Main()
    {
        Car c1 = new BMW("BMW X5", "Black", 20000000);
        Car c2 = new Audi("Audi A6", "White", 18000000);
        Car c3 = new GLI("GLI 2022", "Grey", 7000000);

        double distance = 150;

        c1.Show();
        Console.WriteLine("Fuel Used: " + c1.FuelConsumption(distance));

        Console.WriteLine();

        c2.Show();
        Console.WriteLine("Fuel Used: " + c2.FuelConsumption(distance));

        Console.WriteLine();

        c3.Show();
        Console.WriteLine("Fuel Used: " + c3.FuelConsumption(distance));
    }
}