using System;
using System.Reflection;

class Activty
{
protected string Start(String activity, string description)
{
    //stock start message and description
    string startmessage = $"welcome to the {activity}\n\n{description}"; 
    Wait(2);
    return startmessage;
}

protected int Seconds() 
{
    //ask the user for the time
    Console.WriteLine("How many seconds would you like to do the activty for?");
    Console.Write("Number of Seconds: ");
    int seconds = int.Parse(Console.ReadLine());
    return seconds;
}

protected void Duration(Action filler,int seconds)
{
    DateTime currentime = DateTime.Now;
    DateTime endtime = currentime.AddSeconds(seconds);
    do 
    {
        filler();
        currentime = DateTime.Now;
    } while(currentime < endtime);
}

protected void Wait(int seconds)
{
    //waiting animation
    for (int i=0; i < seconds; i++)
    {
    Console.Write(".");
    Thread.Sleep(125);
    Console.Write(".");
    Thread.Sleep(125);
    Console.Write(".");
    Thread.Sleep(125);
    Console.Write(".");
    Thread.Sleep(125);
    Console.Write("\b \b");
    Thread.Sleep(125);
    Console.Write("\b \b");
    Thread.Sleep(125);
    Console.Write("\b \b");
    Thread.Sleep(125);
    Console.Write("\b \b");
    Thread.Sleep(125);
    }
}

protected void End(string activity, int seconds)
{
    //stock end message
    Console.WriteLine($"Congrats, you have completed {activity} for {seconds} seconds.");
    Wait(5);
}

}