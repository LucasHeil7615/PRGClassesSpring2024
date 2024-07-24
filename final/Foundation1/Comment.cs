using System;

public class Comment
{
    // Auto-implemented properties for the name of the person and the text of the comment.
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor that initializes the Comment object with the provided name and text.
    public Comment(string name, string text)
    {
        // Assign the provided name to the Name property.
        Name = name;
        
        // Assign the provided text to the Text property.
        Text = text;
    }

    // Override the ToString method to provide a string representation of the Comment object.
    public override string ToString()
    {
        return $"{Name}: {Text}";
    }
}
