using System;
using System.Diagnostics.Tracing;

Random random = new Random(); //Initialise Random

int correctNum = random.Next(1, 6); //1-5 random number

int guess;

Console.WriteLine("Pick a number between 1 and 5...\nIf you guess correctly you can play Doom!");

int.TryParse(Console.ReadLine(), out guess); //Parses guess as an integer (So nothing other than an integer is allowed)

while (guess != correctNum)
{
    Console.WriteLine("Wrong! Try again!");
    int.TryParse(Console.ReadLine(), out guess); //Retries the parsing
}

Console.WriteLine("\nCorrect! Enjoy Doom!\n");

System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://ustymukhman.github.io/WebDOOM/public/") { UseShellExecute = true }); //Sends default browser to WebDOOM

Console.WriteLine("""
    Credits:
        Created By: holypinko
        WebDOOM: https://ustymukhman.github.io/WebDOOM/public/
    """); //Credits, of course