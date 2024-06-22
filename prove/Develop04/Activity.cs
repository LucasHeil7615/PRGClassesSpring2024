using System;
using System.Reflection;

class Activity
{
protected void Start(string activity, string description)
{
    //stock start message and description
    Console.WriteLine($"welcome to the {activity}\n\n{description}"); 
    Wait(2);
}

protected int Seconds() 
{
    //ask the user for the time
    Console.WriteLine("How many seconds would you like to do the activity for?");
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
    Console.Write("Loading ");
    for (int i=0; i < seconds; i++)
    {
    Console.Write("|");
    Thread.Sleep(250);
    Console.Write("\b \b");
    Console.Write("/");
    Thread.Sleep(250);
    Console.Write("\b \b");
    Console.Write("-");
    Thread.Sleep(250);
    Console.Write("\b \b");
    Console.Write("\\");
    Thread.Sleep(250);
    Console.Write("\b \b");
    }
    //removes loading
    string back = new string('\b',8);
    Console.WriteLine($"{back}        {back}");
}

protected void CountdownTen()
{
    Console.Write("Countdown: ");
    for (int i = 10; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        if (i>9)
        {
        string back = new string('\b',2);
        Console.Write($"{back}  {back}");
        }
        else
        {
        string back = new string('\b',1);
        Console.Write($"{back} {back}");
        }
    }
}


protected void End(string activity, int seconds)
{
    //stock end message
    Console.WriteLine($"Congrats, you have completed {activity} for {seconds} seconds.");
    Wait(5);
}

protected void Random(List<string> list)
{
    Random random = new Random();
        int index = random.Next(list.Count);
        string randomPrompt = list[index];
        Console.WriteLine($"{randomPrompt}");
}
}