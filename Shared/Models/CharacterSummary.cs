namespace Shared.Models
{
    public sealed class CharacterSummary
    {
        public required string Id { get; init; }           // GUID as string
        public required string Name { get; init; }
        public required string Class { get; init; }
        public int Level { get; init; }
    }
}