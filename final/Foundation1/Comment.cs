using System;

public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    //initializes Comment with the provided name and text.
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    //Prints the Name and Text of each comment when called
    public override string ToString()
    {
        return $"{Name}: {Text}";
    }
}
