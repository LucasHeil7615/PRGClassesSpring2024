using System;
using System.Runtime.ConstrainedExecution;

class Fillings 
{
    public string Prompt()
    {
        List<string> Prompts = new List<string>
        {
            "Describe a moment when you felt truly alive.",
            "Write about a goal you accomplished and how it made you feel.",
            "What are you grateful for today?",
            "Reflect on a mistake you made and what you learned from it.",
            "Describe a person who has had a significant impact on your life.",
            "What is something you want to learn and why?",
            "Write about a place that holds special memories for you.",
            "What is your biggest fear and why?",
            "Reflect on a time when you felt proud of yourself.",
            "Describe your ideal day from start to finish.",
            "Write about a book or movie that has influenced you.",
            "What does success mean to you?",
            "Write a letter to your future self.",
            "Reflect on a challenge you've overcome.",
            "Describe a moment when you felt inspired.",
            "What is something you want to change about yourself?",
            "Write about a hobby or passion you have.",
            "Describe a happy childhood memory.",
            "Reflect on a time when you felt overwhelmed and how you coped.",
            "What are you afraid to ask for?",
            "Write about a time when you felt proud of someone else.",
            "Describe a dream you've had recently.",
            "What are you avoiding and why?",
            "Reflect on a decision you regret.",
            "Write about a lesson you learned the hard way.",
            "Describe a time when you felt out of your comfort zone.",
            "What motivates you to keep going when things get tough?",
            "Write about a person you admire and why.",
            "Reflect on a time when you felt truly happy.",
            "What is something you want to achieve in the next year?",
            "Describe a moment when you felt deeply connected to someone.",
            "Write about a time when you felt lost and how you found your way.",
            "What is something that always makes you smile?",
            "Reflect on a time when you felt misunderstood.",
            "Describe a place you've always wanted to visit.",
            "Write about a goal you've been procrastinating on.",
            "What is something you wish you could tell your younger self?",
            "Reflect on a time when you felt like giving up.",
            "Describe a moment when you felt at peace.",
            "What is something you're passionate about changing in the world?",
            "Write about a risk you took and whether it paid off.",
            "Reflect on a time when you felt rejected.",
            "What is something you've been avoiding confronting?",
            "Describe a time when you felt like you belonged.",
            "Write about a goal you achieved against all odds.",
            "What is something you want to forgive yourself for?",
            "Reflect on a time when you felt betrayed.",
            "Describe a moment when you felt inspired by nature.",
            "What is something you want to let go of?",
            "Write about a challenge you're currently facing.",
            "What is something you want to say 'yes' to?",
            "Reflect on a time when you felt like you didn't belong.",
        };

        
        Random rand = new Random();
       
        int randomIndex = rand.Next(0, Prompts.Count);  

        string Prompt = Prompts[randomIndex];

        return Prompt;                                                 
    }

    public string Inspiration()
    {
        List<string> Quotes = new List<string>
        {
        "“Journaling is like whispering to one's self and listening at the same time. - Mina Murray",
        "“Fill your paper with the breathings of your heart. - William Wordsworth",
        "“Journal writing is a voyage to the interior. - Christina Baldwin",
        "“Writing is the painting of the voice. - Voltaire",
        "“Journaling is the single most effective tool you may ever find for deeper intimacy with Father God and Jesus. - Linda Boone",
        "“Journaling helps you to remember the things you don`t want to forget. - Anon",
        "“Writing in a journal reminds you of your goals and of your learning in life. It offers a place where you can hold a deliberate, thoughtful conversation with yourself. - Robin S. Sharma",
        "“Journal writing gives us insights into who we are, who we were, and who we can become. - Sandra Marinella",
        "“Journaling is like a whisper to the soul, and the scratches of pen on paper are the whispers that echo back. - Anon",
        "“Keeping a journal of what`s going on in your life is a good way to help you distill what`s important and what`s not. - Martina Navratilova",
        "Believe you can and you're halfway there. - Theodore Roosevelt",
        "The only way to do great work is to love what you do. - Steve Jobs",
        "The best way to predict the future is to create it. - Abraham Lincoln",
        "Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill",
        "Success is not the key to happiness. Happiness is the key to success. If you love what you are doing, you will be successful. - Albert Schweitzer",
        "Your time is limited, don't waste it living someone else's life. - Steve Jobs",
        "The only limit to our realization of tomorrow will be our doubts of today. - Franklin D. Roosevelt",
        "Every moment is a fresh beginning. - T.S. Eliot",
        "Change your thoughts and you change your world. - Norman Vincent Peale",
        "What you get by achieving your goals is not as important as what you become by achieving your goals. - Zig Ziglar",
        "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
        "Believe in yourself! Have faith in your abilities! Without a humble but reasonable confidence in your own powers you cannot be successful or happy. - Norman Vincent Peale",
        "Act as if what you do makes a difference. It does. - William James",
        "You are never too old to set another goal or to dream a new dream. - C.S. Lewis",
        "To see what is right and not do it is a lack of courage. - Confucius",
        "Life is 10% what happens to us and 90% how we react to it. - Charles R. Swindoll",
        "Good, better, best. Never let it rest. 'Til your good is better and your better is best. - St. Jerome"
        };

        Random rand = new Random();
        
        int randomIndex = rand.Next(0, Quotes.Count);  

        string Quote = Quotes[randomIndex];

        return Quote;

    }

    public string GetDateTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateTimeText = theCurrentTime.ToString("g");

        return dateTimeText;
    }

}