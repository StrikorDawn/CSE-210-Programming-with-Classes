public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comments;
    int _numComments = 0;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title:{_title} | Author:{_author} | Length:{_length} Seconds | Comment Number:{_numComments}.");
    }

    public void AddComment(string author, string comment)
    {
        Comment c = new Comment(author, comment);
        _comments.Add(c);
        _numComments += 1;
    }
    public void DispalyNumComments()
    {
        Console.WriteLine($"There are {_numComments} Comments on this Video.");
    }

    public void DisplayComments()
    {
        foreach (var comment in _comments)
        {
            comment.Display();
        }
    }
}