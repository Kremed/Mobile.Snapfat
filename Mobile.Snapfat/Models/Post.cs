using System;

namespace Mobile.Snapfat.Models;

public class Post
{
    public int ID { get; set; }
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string ShortContent
    {
        get
        {
            if (Content.Length < 200)
                return Content;
            return Content.Substring(0, 200) + " ...";
        }
        private set { }
    }

    public int Likes { get; set; }

}
