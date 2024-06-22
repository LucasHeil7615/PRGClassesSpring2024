using System;

class Reflect : Activity
{
    private string activity = "Reflection activity";
    private string description ="In this activity you will be practicing the art of calm by refelcting on time in your life when you have shown strength or resilience. You are stronger and wiser than you know. \nWhen prompted for an amount of time please give yourself ample time to complete this activty. You will need at minimum 30seconds for each reflection. Aka (1 reflection =30) (2 reflections =60) etc.";
    
    private List<string> reflectionsprompts = new List<string>
{
    "Think of a time when you overcame a significant challenge at work",
    "Think of a time when you persevered through a difficult personal situation",
    "Think of a time when you supported a friend or family member through a tough time",
    "Think of a time when you faced a major setback and bounced back",
    "Think of a time when you stood up for yourself in a difficult situation",
    "Think of a time when you completed a challenging project under tight deadlines",
    "Think of a time when you maintained your composure in a high-pressure situation",
    "Think of a time when you adapted to unexpected changes in your plans",
    "Think of a time when you pushed through physical or mental exhaustion to achieve a goal",
    "Think of a time when you tackled a problem that seemed insurmountable at first",
    "Think of a time when you navigated through a period of uncertainty",
    "Think of a time when you learned from a failure and used it to improve",
    "Think of a time when you managed stress and kept going despite feeling overwhelmed",
    "Think of a time when you took on a new responsibility and excelled",
    "Think of a time when you stayed motivated despite facing multiple obstacles",
    "Think of a time when you helped others stay resilient during a challenging period",
    "Think of a time when you demonstrated patience and persistence in achieving a long-term goal",
    "Think of a time when you dealt with criticism or rejection and remained determined",
    "Think of a time when you overcame self-doubt to accomplish something important",
    "Think of a time when you used creativity to solve a difficult problem"
};

    private List<string> questions = new List<string>
    {
            "What was the situation, and what made it challenging?",
            "How did you feel during this experience?",
            "What specific steps did you take to address the challenge?",
            "What resources or support did you use?",
            "What obstacles did you encounter, and how did you overcome them?",
            "What did you learn about yourself from this experience?",
            "How has this experience influenced your approach to similar situations?",
            "What were the key factors that helped you succeed?",
            "What would you do differently if faced with a similar situation again?",
            "How did this experience impact your personal or professional growth?",
            "How did you stay motivated throughout the challenge?",
            "What skills or qualities did you develop as a result?",
            "How did this experience affect your confidence?",
            "What positive outcomes resulted from this experience?",
            "How did you manage any stress or pressure during this time?"
    };

     

    public void Run()
    {
        Wait(3);
        Start(activity, description);
        Wait(3);
        int seconds = Seconds();
        Wait(3);
        Duration(Reflection, seconds);
        End(activity, seconds);
    }

    private void Reflection()
    {
        Random(reflectionsprompts);
        Wait(8);
        Random(questions);
        Wait(22);
    }
}