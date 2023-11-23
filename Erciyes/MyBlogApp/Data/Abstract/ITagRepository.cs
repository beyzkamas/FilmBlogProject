using MyBlogApp.Entity;

namespace MyBlogApp.Data.Abstract{
    public interface ITagRepository{
        IQueryable<Tag> Tags{get;}

        void CreateTag(Tag tags);
    }
}