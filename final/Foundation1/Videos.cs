using System;
using System.Collections.Generic;

public class Video
{
    // Auto-implemented properties for the title, author, and length of the video.
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    
    // Property to store the list of comments.
    public List<Comment> Comments { get; private set; }

    // Constructor that initializes the Video object with the provided title, author, and length.
    public Video(string title, string author, int length)
    {
        // Assign the provided values to the properties.
        Title = title;
        Author = author;
        Length = length;
        
        // Initialize the list of comments.
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video.
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments on the video.
    public int GetNumComments()
    {
        return Comments.Count;
    }

    // Override the ToString method to provide a string representation of the Video object.
    public override string ToString()
    {
        string commentsString = string.Join("\n", Comments);
        return $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\n" +
               $"Number of comments: {GetNumComments()}\nComments:\n{commentsString}";
    }
}
