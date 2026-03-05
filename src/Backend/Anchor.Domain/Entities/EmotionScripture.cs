namespace Anchor.Domain.Entities
{
    public class EmotionScripture
    {
        public long EmotionId { get; set; }
        public Emotion Emotion { get; set; } = null!;
        public long ScriptureReferenceId { get; set; }
        public ScriptureReference ScriptureReference { get; set; } = null!;
    }
}
