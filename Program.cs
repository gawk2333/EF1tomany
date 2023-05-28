namespace EF1tomany
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using(MyDbContext ctx =  new MyDbContext())
            {
                ctx.Database.EnsureCreated();
                Article a1 = new Article();
                a1.Title = "Kang is the most handsome programmer";
                a1.Content = "As the media said bla bla bla";
                a1.Author = "Kang";
                a1.Description = "It is truely yes";

                Comment c1 = new Comment { Message = "awesome",Name="guagua" };
                Comment c2 = new Comment { Message = "Agree", Name = "haha" };

                a1.Comments.Add(c1);
                a1.Comments.Add(c2);

                ctx.Articles.Add(a1);
                await ctx.SaveChangesAsync();
            }
        }
    }
}