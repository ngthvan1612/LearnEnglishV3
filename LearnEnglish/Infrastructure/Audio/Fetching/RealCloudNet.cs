using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace LearnEnglish.Infrastructure.Audio.Fetching
{
    public class RealCloudNet : IFetchAudio
    {
        private string text;
        public byte[] DownloadWAV()
        {
            string html = "https://readloud.net/"
                .PostUrlEncodedAsync(new
                {
                    but1 = this.text,
                    fruits = "Brian",
                    but = "Submit",
                    butS = 0,
                    butP = 0,
                    butPauses = 0
                })
                .ReceiveString()
                .GetAwaiter()
                .GetResult();
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            var audios = doc.DocumentNode.SelectNodes("//audio[@style='width: 80%;  vertical-align: middle;']");
            var source = audios.First().SelectSingleNode("//source");
            string src = source.GetAttributeValue("src", "");
            byte[] audio = $"https://readloud.net{src}"
                .GetBytesAsync()
                .GetAwaiter()
                .GetResult();
            return AudioProcessing.ConvertMp3ToWAV(audio);
        }

        public void Prepare(string text)
        {
            this.text = text;
        }
    }
}
