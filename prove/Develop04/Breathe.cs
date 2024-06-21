using System;

class Breathe : Activty
{
    private string activty = "Breathing activity";
    private string descripion ="In this activty you will be practicing the art of clam by breathing in and out deeply. Clear your mind and rest."; 
    public void Run()
    {
        Start(activty, descripion);
        int seconds = Seconds();
        Duration(Breathing, seconds);
        End(activty, seconds);
    }
    // Breathing exercise
    private void Breathin()
    {
            Console.WriteLine("Breathe in ... {}");
            Wait(5);
    }
    private void Breathout()
    {
            Console.WriteLine("Breathe out ... {}");
            Wait(5);
    }
    private void Breathing()
    {
        Breathin();
        Breathout();
    }
}