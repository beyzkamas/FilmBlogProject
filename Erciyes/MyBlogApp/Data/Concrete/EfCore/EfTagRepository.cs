using MyBlogApp.Data.Abstract;
using MyBlogApp.Data.Concrete.EfCore;
using MyBlogApp.Entity;

namespace MyBlogApp.Data.Concrete{
    public class EfTagRepository : ITagRepository
    {
        private BlogContext _context;
        public EfTagRepository(BlogContext context){
            _context=context;
        }
        public IQueryable<Tag> Tags => _context.Tags;

        //public IQueryable<Tag> Posts => throw new NotImplementedException();

        public void CreateTag(Tag Tag)
        {
            _context.Tags.Add(Tag);
            _context.SaveChanges();

        }

    }
}