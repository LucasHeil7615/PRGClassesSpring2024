using System;
using Microsoft.VisualBasic;

class Grateful : Activity
{
    private string activity = "Gratitude activity";

    private string description = "In this activity you will be practicing the art of calm by listing things that you are grateful for.";

private List<string> gratitudePrompts = new List<string>
{
    "Sources from recent laughter?",
    "Lessons from a recent challenge?",
    "Recent kindnesses received?",
    "Talents or skills you appreciate?",
    "Happy childhood memories?",
    "Beauties in nature you cherish?",
    "Impactful books read?",
    "Witnessed or received generosity?",
    "Taken-for-granted blessings?",
    "Memorable recent places visited?",
    "Admired people?",
    "Impactful teacher or mentor?",
    "Appreciated aspects of home?",
    "Small daily pleasures?",
    "Joyful recent conversations?",
    "favorite meals?",
    "What are you looking forward to do?",
    "Long-time friend and memories?",
    "Grateful for recent technology?",
    "Newly acquired skills?",
    "Inspiring uplifting songs?",
    "Recent act of kindness done?",
    "Appreciated qualities about yourself?",
    "Received forgiveness?",
    "Joyful hobbies or interest?",
    "Beloved pets or animals?",
    "Valued local businesses or services?",
    "Recent achievements or milestones?",
    "Beautiful sunrise or sunset?",
    "Grateful for these historical figures?",
    "Impactful volunteer experience?",
    "Inspiring art or literature?",
    "Improved health or well-being?",
    "Comforting tradition or ritual?",
    "Cherished vacation memory?",
    "Impactful cultural or social event?",
    "Lesson from mistake or failure?",
    "Supportive family member?",
    "Positive change or challenge?",
    "Personal growth in past year?",
    "Valuable recent advice?",
    "Awe-inspiring nature experiences?",
    "Life-improving technology or innovation?",
    "Luxury or comfort appreciated?",
    "Unexpected help or support?",
    "loved one's accomplishments?",
    "Recent acts of helping others?",
    "favorite charitable causes?",
    "Grateful for social gatherings?",
    "membership in communities or groups?",
    "Impactful realizations or insights?",
    "recent gifts?",
};
    private List<string> gratitudes = new();

    public void Run()
    {
        Start(activity, description);
        int seconds = Seconds();
        Console.WriteLine("Begin Listing items baised on the prompt given:");
        CountdownTen();
        Console.WriteLine("\nStart:");
        Duration(GratefulActivty, seconds);
        int numstrings = gratitudes.Count;
        Console.WriteLine($"You have listed {numstrings} items.");
        End(activity, seconds);
    }

    private void GratefulActivty()
    {
        Random(gratitudePrompts);
        Duration(AddItem,10);
       
    }
    private void AddItem()
    {
        string item = Console.ReadLine();
        gratitudes.Add(item);
    }   
}