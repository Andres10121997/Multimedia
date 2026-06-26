namespace DTO.Video
{
    public sealed record VideoDTO
    {
        public required string Title { get; init; }
        public required string Description { get; init; }
        public DateOnly CreationDate { get; init; }
        public TimeOnly CreationTime { get; init; }
    }
}