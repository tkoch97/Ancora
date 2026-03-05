using Anchor.Domain.Enums;

namespace Anchor.Domain.Entities
{
    public class ScriptureReference : EntityBase
    {
        public required BibleBook Book { get; set; }
        public int Chapter { get; set; }
        public int VerseStart { get; set; }
        public int? VerseEnd { get; set; }
        public List<EmotionScripture> EmotionScriptures { get; set; } = [];
    }
}
