namespace EF1tomany
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using(MyDbContext ctx =  new MyDbContext())
            {
                User user1 = new User { Name="Kang" };

                Leave leave1 = new Leave();
                leave1.Requester = user1;
                leave1.Remarks = "I'm sick, I need to go to hospital";
                leave1.Status = 0;
                leave1.From = DateTime.Now;
                leave1.To = new DateTime(2023, 9, 11);
                
                ctx.Users.Add( user1 );
                ctx.Leaves.Add( leave1 );
                await ctx.SaveChangesAsync();
            }
        }
    }
}