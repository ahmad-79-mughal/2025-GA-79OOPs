using System;

class Bicycle
{
    protected int cadence;
    protected int gear;
    protected int speed;

    public Bicycle(int cadence, int speed, int gear)
    {
        this.cadence = cadence;
        this.speed = speed;
        this.gear = gear;
    }

    public void setCadence(int cadence)
    {
        this.cadence = cadence;
    }

    public void setGear(int gear)
    {
        this.gear = gear;
    }

    public void applyBrake(int decrement)
    {
        speed -= decrement;
    }

    public void speedUp(int increment)
    {
        speed += increment;
    }

    public void Show()
    {
        Console.WriteLine("Cadence: " + cadence);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine("Gear: " + gear);
    }
}

class MountainBike : Bicycle
{
    private int seatHeight;

    public MountainBike(int seatHeight, int cadence, int speed, int gear)
        : base(cadence, speed, gear)
    {
        this.seatHeight = seatHeight;
    }

    public void setSeatHeight(int seatHeight)
    {
        this.seatHeight = seatHeight;
    }

    public void ShowAll()
    {
        Show();
        Console.WriteLine("Seat Height: " + seatHeight);
    }
}

class Program
{
    static void Main()
    {
        MountainBike bike = new MountainBike(10, 50, 20, 3);

        bike.speedUp(10);
        bike.applyBrake(5);
        bike.setSeatHeight(15);

        bike.ShowAll();
    }
}