namespace Api.GraphQLTypes
{
    public class Query
    {
        public IEnumerable<User> GetUsers() => new List<User>() { new User(), new User(), new User() };
    }
}
