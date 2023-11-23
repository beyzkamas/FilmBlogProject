namespace MyBlogApp.Entity
  {
    public class Tag{

        public int TagID { get; set; }
        public string? Text { get; set; }
        public string? Url { get; set; }
        public List<Post> Posts {get;set;} = new List<Post>();
        //public List<Comment> Comments {get;set;}=new List<Comment>();
    }

}