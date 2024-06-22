using System;
using System.ComponentModel;

class List : Activity
{
    private string activity = "Listing activity";
    private string description ="In this activity you will be practicing the art of calm reflecting on the joyful things in your life. Simply think of as many joyful or pleasnt things and write them down according to the prompts"; 
    protected List<string> ListPrompts = new List<string>
{
    "Who are people that you appreciate?",
    "When have you felt at peace?",
    "What are moments when you felt truly happy?",
    "What accomplishments are you proud of?",
    "Who has made a positive impact on your life?",
    "What are some of your favorite memories?",
    "What activities bring you joy and satisfaction?",
    "When have you felt the most loved?",
    "What are the things you are grateful for today?",
    "What are places that make you feel relaxed and content?",
    "Who are friends or family members who support you?",
    "What are the experiences that have brought you the most fulfillment?",
    "What qualities do you admire in yourself?",
    "What are the positive changes you’ve made in your life?",
    "When have you felt the most inspired?",
    "What are the things you look forward to?",
    "What are the things you enjoy about your daily routine?",
    "What are the achievements that have given you the most satisfaction?",
    "Who are the mentors or role models you appreciate?",
    "What are the simple pleasures in life that you cherish?"
};

private List<string> usersStrings =new();


       public void Run()
    {
        Start(activity,description);
        int seconds = Seconds();
        Wait(3);
        Random(ListPrompts);
        CountdownTen();
        Console.WriteLine("Begin writing:");
        Duration(Listing,seconds);
        int numstrings = usersStrings.Count;
        Console.WriteLine($"You have listed {numstrings} items.");
        End(activity,seconds);
    }

    private void Listing()
    {
            string line = Console.ReadLine();
            usersStrings.Add(line);
    }

}