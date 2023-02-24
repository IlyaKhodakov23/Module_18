using AngleSharp.Dom;
using AngleSharp.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Search;
using YoutubeExplode.Videos;

namespace YouTube_Downloader
{
    class CommandOne : Command_YouTube
    {

        Receiver receiver;

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public override async void Download(string url, string place)
        {
            try
            {
                var youtube = new YoutubeClient();
                await youtube.Videos.DownloadAsync(url, place, builder => builder.SetPreset(ConversionPreset.UltraFast));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void Info(string url)
        {
            try
            {
                var youtube = new YoutubeClient();
                Console.WriteLine(youtube.Videos.GetAsync(url));

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
