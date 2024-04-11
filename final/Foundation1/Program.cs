// Scenario
// You have been hired by a company that does product awareness monitoring by tracking the placement of their products in YouTube videos. They want you to write a 
// program that can help them work with the tens of thousands of videos they have identified as well as the comments on them.
// 
// Program Specification
// Write a program to keep track of YouTube videos and comments left on them. As mentioned this could be part of a larger project to analyze them, but for this 
// assignment, you will only need to worry about storing the information about a video and the comments.
// 
// Your program should have a class for a Video that has the responsibility to track the title, author, and length (in seconds) of the video. Each video also has 
// responsibility to store a list of comments, and should have a method to return the number of comments. A comment should be defined by the Comment class which has 
// the responsibility for tracking both the name of the person who made the comment and the text of the comment.
// 
// Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the 
// commenter's name and text). Put each of these videos in a list.
// 
// Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list 
// out all of the comments for that video. Repeat this display for each video in the list.
// 
// Note: The YouTube example is just to give you a context for creating classes to store information. You will not actually be connecting to YouTube or downloading 
// content in any way.
using System;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video{title = "Burger King Foot Lettuce", creator = "Anon", duration = 36};
        video1.comments.Add(new Comment{commenterName = "Anon[Creator]", commentText = "This is the lettuce you eat at Burger King."});
        video1.comments.Add(new Comment{commenterName = "Phialster17", commentText = "Gross."});
        video1.comments.Add(new Comment{commenterName = "Bob1", commentText = "Nice feet"});
        videos.Add(video1);

        Video video2 = new Video{title = "The Moon is Our Door to Forever", creator = "ex1ruba",duration = 12182};
        video2.comments.Add(new Comment{commenterName = "Meme_lord", commentText = "ACTUALLY, the Moon has such a tragically limited habitation and this long-term toxic atmosphere that's totally inferior to Earth's. Can you even imagine living in such basic conditions? We're totally doomed if we even try. It's just sad that people still cling to this whole Moon colonization thing. Get real, guys. Let's not waste our precious time and resources on some far-fetched sci-fi dream. We should be focusing on solving real problems, you know? Why even bother with the Moon when we have perfectly good Earth to live on? Seriously, it's like some people just want to play space cowboys instead of facing reality. So lame."});
        video2.comments.Add(new Comment{commenterName = "Tyler Phillips", commentText = "This creator is postmoderism incarnate and his philosophy half-baked"});
        video2.comments.Add(new Comment{commenterName = "Not_NASA_Recruiting", commentText = "Imagine being NASA lol; they are so smart and being an aerospace engineer is probably the coolest job ever"});
        videos.Add(video2);

        Video video3 = new Video{title = "Minecraft is the PERFECT game", creator = "Some_KING",duration = 19250};
        video3.comments.Add(new Comment{commenterName = "1111111", commentText = "minecraft"});
        video3.comments.Add(new Comment{commenterName = "LadyEva", commentText = "This video made me cry. I'm gonna go play mc"});
        video3.comments.Add(new Comment{commenterName = "Steve", commentText = "minecraft"});
        video3.comments.Add(new Comment{commenterName = "Tyler Phillips", commentText = "Minecraft is KING"});
        videos.Add(video3);

        foreach (Video v in videos)
        {
            v.PrintOutput(v);
            Console.WriteLine();
        }
    }
}