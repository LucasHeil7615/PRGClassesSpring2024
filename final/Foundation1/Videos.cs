using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    
    public List<Comment> Comments { get; private set; }

    //creates the Video object with the provided title, author, and length.
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        
        Comments = new List<Comment>();
    }

    //Adds comments to the list of comments 
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Counts the amount of comments
    public int GetNumComments()
    {
        return Comments.Count;
    }

    //turns our videos into strings
    public override string ToString()
    {
        string commentsString = string.Join("\n", Comments);
        return $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\n" +
               $"Number of comments: {GetNumComments()}\nComments:\n{commentsString}";
    }
}
