using LearnEnglish.Domain.Aggregate.TopicTrees;

namespace LearnEnglish.Domain.Aggregate.Vocabs
{
    public partial class Vocab
    {
        public int Id { get; set; }

        public string? Eng { get; set; }
        public string? Vie { get; set; }
        public byte[]? Audio { get; set; }

        //FK
        public int TopicTreeId { get; set; }
        public TopicTree? TopicTree { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public Vocab()
        {

        }

        public Vocab(string eng, string vie, byte[] audio, int topicTreeId)
            : this()
        {
            this.TopicTreeId = topicTreeId;
            this.Vie = vie;
            this.Eng = eng;
            this.Audio = audio;
        }
    }
}
