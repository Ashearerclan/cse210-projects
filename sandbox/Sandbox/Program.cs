using System;
using System.Formats.Tar;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int name = "John";

        Movie favoriteMovie = new Movie();
        favoriteMovie._title = "Star Wars";
        favoriteMovie._year = 1977;
        favoriteMovie._rating = "PG";
        favoriteMovie._runtime = 150;

        Movie otherMovie = new Movie();
        otherMovie._title = "Avatar";
        otherMovie._year = 2009;
        otherMovie._rating = "PG-13";
        otherMovie._runtime = 162;
    }
}