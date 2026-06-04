using System;
public class Comment
{
    public string _commenterName;
    public string _commentText;
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
    public string GetCommenterName()
    {
        return _commenterName;
    }
    public string GetText()
    {
        return _commentText;
    }
}