using Anchor.Domain.Enums;

namespace Anchor.Domain.Entities
{
    public class ScriptureReference : EntityBase
    {
        public required BibleBook Book { get; set; }
        public int Chapter { get; set; }
        public int VerseStart { get; set; }
        public int? VerseEnd { get; set; }
        public string Reference => VerseEnd == null ? $"{Book} {Chapter}:{VerseStart}" : $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
        public List<EmotionScripture> EmotionScriptures { get; set; } = [];
    }
}
