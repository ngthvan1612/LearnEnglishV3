using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Infrastructure.Audio
{
    public class AudioProcessing
    {
        /// <summary>
        /// Chuyển định dạng mp3 thành wav
        /// <br/>
        /// Lớp SoundPlayer chỉ phát được định dạng wav, không phát được mp3
        /// </summary>
        /// <param name="mp3">Trả về mảng[] của âm thanh wave</param>
        /// <returns></returns>
        public static byte[] ConvertMp3ToWAV(byte[] mp3)
        {
            using (var srcMs = new MemoryStream(mp3))
            {
                using (Mp3FileReader reader = new Mp3FileReader(srcMs))
                {
                    using (WaveStream pcmStream = WaveFormatConversionStream.CreatePcmStream(reader))
                    {
                        using (var dstMs = new MemoryStream())
                        {
                            WaveFileWriter.WriteWavFileToStream(dstMs, pcmStream);
                            return dstMs.ToArray();
                        }
                    }
                }
            }
        }
    }
}
