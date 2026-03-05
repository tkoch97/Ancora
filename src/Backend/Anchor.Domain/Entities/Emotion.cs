namespace Anchor.Domain.Entities
{
    public class Emotion : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public EmotionContent? EmotionContent { get; set; }
        public List<EmotionScripture> EmotionScriptures { get; set; } = [];
        public string Slug { get; set; } = string.Empty;
    }
}