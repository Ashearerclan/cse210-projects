using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates base Assignment object
        Assignment a1 = new Assignment("John Adams", "Writing");
        Console.WriteLine(a1.GetSummary());

        // Creates derived class assignments
        MathAssignment a2 = new MathAssignment("John Brown", "Multiplication", "10.2", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("John Mclain", "US History", "The American Civil Wars Battle Tactics");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}