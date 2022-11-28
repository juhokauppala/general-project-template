namespace Api.GraphQLTypes
{
    public class User
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Name { get; init; } = $"User {Random.Shared.Next()}";
        public Guid? GoogleId { get; init; } = null;

    }
}
