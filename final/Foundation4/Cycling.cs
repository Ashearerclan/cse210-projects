using System;

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed() => speed;

    public override double GetDistance() => (speed / 60) * LengthInMinutes;

    public override double GetPace() => 60 / speed;
}
