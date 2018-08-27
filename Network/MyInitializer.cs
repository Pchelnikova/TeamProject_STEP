using System.Data.Entity;

namespace Network_DAL
{
    internal class MyInitializer<T> : DropCreateDatabaseAlways<Model_Network>
    {
        protected override void Seed(Model_Network context)
        {
            User user = new User()
            {
                Name = "Name"
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}