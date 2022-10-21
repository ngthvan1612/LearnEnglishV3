using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Domain.Aggregate.Vocabs
{
    public class VocabView
    {
        [DisplayName("STT")]
        public int Order { get; set; }

        [DisplayName("Tiếng anh")]
        public string English { get; set; }

        [DisplayName("Tiếng việt")]
        public string Vietnam { get; set; }

        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        public byte[] Audio { get; set; }

        public VocabView()
        {

        }

        public VocabView(Vocab vocab)
        {
            this.English = vocab.Eng;
            this.Vietnam = vocab.Vie;
            this.Id = vocab.Id;
            this.Audio = vocab.Audio;
        }
    }
}
