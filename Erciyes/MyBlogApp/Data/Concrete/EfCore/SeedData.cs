using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using MyBlogApp.Data.Concrete;
using MyBlogApp.Data.Concrete.EfCore;
using MyBlogApp.Entity;
namespace MyBlogApp.Data.Concrete{
    public static class SeedData{
        public static void TestVerileriniDoldur(IApplicationBuilder app){
            var context =app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();

            if(context != null){
                if(context.Database.GetPendingMigrations().Any()){
                    context.Database.Migrate();
                }

                if(!context.Tags.Any()){
                    context.Tags.AddRange(
                    new Entity.Tag{Text = "Shutter Island", Url="shutter-island"},
                    new Entity.Tag{Text = "The Truman Show", Url="truman-show"},
                    new Entity.Tag{Text = "The Shawshank Redemption", Url="shawshank-redemption"}
                    
                    );
                    context.SaveChanges();
                }
                if(!context.Users.Any()){
                    context.Users.AddRange(
                    new Entity.User{UserName="beyza", Name = "Beyza Nur", Email = "beyza@gmail.com", Password="123456", Image="userk.jpg",},
                    new Entity.User{UserName="derya",Name = "Derya Kaya", Email = "derya@gmail.com", Password="123456", Image="userari.jpg",}
                    );
                    context.SaveChanges();
                }
                if(!context.Posts.Any()){
                    context.Posts.AddRange(
                    new Entity.Post{
                        Title="Shutter Island",
                        Content="Shutter Island, Martin Scorsese'nin yönettiği, Dennis Lehane'in romanından uyarlanmış karanlık ve karmaşık bir film. Öncelikle, filmdeki atmosfer ve görsel anlatım oldukça etkileyici. Scorsese'nin kullanımıyla adeta bir rüya gibi gizemli bir ada ortamı yaratılıyor. Karakterlerin psikolojik durumları da izleyiciyi etkileyen bir başka önemli unsur.",
                        IsActive= true,
                        Url="shutter-island",
                        Image="s.jpg",
                        PublishedOn = DateTime.Now.AddDays(-5),
                        Tags = context.Tags.Take(3).ToList(),
                        UserID = 1,
                        Comments = new List<Comment> { 
                                new Comment { Text = "En güzel film", PublishedOn = DateTime.Now.AddDays(-20), UserID = 1},
                                new Comment { Text = "Çok beğendim", PublishedOn = DateTime.Now.AddDays(-10), UserID = 2},
                            }
                    },
                    new Entity.Post{
                        Title="The Truman Show",
                        Content="The Truman Show, oldukça ilginç bir film. Burada da gerçeklik ve sahicilik kavramları üzerine derinlemesine bir bakış açısı bulunuyor. Truman'ın yaşadığı dünya aslında bir televizyon setinde canlı yayınlanan bir yaşamı temsil ediyor.",
                        IsActive= true,
                        Url="truman-show",
                        Image="truman.jpg",
                        PublishedOn = DateTime.Now.AddDays(-15),
                        Tags = context.Tags.Take(3).ToList(),
                        UserID = 1
                    },
                    new Entity.Post{
                        Title="The Shawshank Redemption",
                        Content="The Shawshank Redemption izleyiciyi derinden etkileyen, unutulmaz bir film. Bu filmde, insanın umut, dostluk ve insanlık üzerine derin bir hikaye anlatılıyor. Öncelikle, Andy Dufresne'in haksız yere mahkum edilmesi ve cezaevinde geçirdiği süre boyunca içsel gücü ve kararlılığı üzerinde duruluyor. Bu, izleyiciye hayatta karşılaşılan zorluklarla nasıl başa çıkılacağı konusunda ilham veriyor.",
                        IsActive= true,
                        Url="shawshank-redemption",
                        Image="t.jpg",
                        PublishedOn = DateTime.Now.AddDays(-25),
                        Tags = context.Tags.Take(3).ToList(),
                        UserID = 1
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}