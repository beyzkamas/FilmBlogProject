namespace MyBlogApp.Entity{
    public class Comment{
        public int CommentID{get;set;}
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }
        public int PostID { get; set; }
        public Post Post{get;set;} = null!;
        public int UserID { get; set; }
        public User User{get;set;} = null!;
    }
}