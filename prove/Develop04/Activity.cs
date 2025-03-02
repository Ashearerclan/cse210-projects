using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected int duration;
    
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine(GetActivityDescription());
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);
        RunActivity();
        Console.WriteLine($"Good job! You completed {GetActivityName()} for {duration} seconds.");
        ShowCountdown(5);
    }
    
    protected abstract void RunActivity();
    protected abstract string GetActivityName();
    protected abstract string GetActivityDescription();
    
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write($"{spinner[i % 4]} ");
            Thread.Sleep(250);
            Console.Write("\b\b");
            i++;
        }
        Console.WriteLine();
    }
}