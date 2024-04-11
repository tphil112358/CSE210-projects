using System;
class Video
{
    public string title;
    public string creator;
    public int duration;
    public List<Comment> comments = new List<Comment>();
    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    public void PrintOutput(Video v)
    {
        Console.WriteLine("Title: " + v.title);
        Console.WriteLine("Creator: " + v.creator);
        Console.WriteLine("Length: " + v.duration + " seconds");
        Console.WriteLine("Number of comments: " + v.GetNumberOfComments());
        Console.WriteLine("Comments:");
        foreach (Comment c in v.comments)
        {
            Console.WriteLine("     " + c.commenterName + ": " + c.commentText);
        }
    }
}