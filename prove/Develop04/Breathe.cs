using System;

class Breathe : Activity
{
    private string activity = "Breathing activity";
    private string description ="In this activity you will be practicing the art of calm by breathing in and out deeply. Clear your mind and rest."; 
    public void Run()
    {
        Start(activity, description);
        int seconds = Seconds();
        Duration(Breathing, seconds);
        End(activity, seconds);
    }
    // Breathing exercise
    private void Breathin()
    {
            Console.WriteLine("Breathe in");
            Wait(5);
    }
    private void Breathout()
    {
            Console.WriteLine("Breathe out");
            Wait(5);
    }
    private void Breathing()
    {
        Breathin();
        Breathout();
    }
}