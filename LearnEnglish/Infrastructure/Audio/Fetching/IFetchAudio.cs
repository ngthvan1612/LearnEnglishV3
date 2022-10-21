using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.Audio.Fetching
{
    public interface IFetchAudio
    {
        void Prepare(string text);
        byte[] DownloadWAV();
    }
}
