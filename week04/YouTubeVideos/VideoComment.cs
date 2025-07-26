using System;
using System.Collections.Generic;

class VideoComment
{
    private string _commentText;
    private string _commenterName;

    public VideoComment(string commentText, string commenterName)
    {
        _commentText = commentText;
        _commenterName = commenterName;
    }


    public string commenterName
    {
        get { return commenterName;}
        set { _commenterName = value;}
    }

    public string GetFormattedComment()
    {
        return $" - {_commenterName}: {_commentText}";
    }
}