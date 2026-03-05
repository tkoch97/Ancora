namespace Anchor.Domain.Entities
{
    public class EmotionContent : EntityBase
    {
        public string ShortExplanation { get; set; } = string.Empty;
        public string PracticalApplication { get; set; } = string.Empty;
        public string PrayerSuggestion { get; set; } = string.Empty;
        public long EmotionId { get; set; }
        public Emotion Emotion { get; set; } = null!;
    }
}