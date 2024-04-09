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
}