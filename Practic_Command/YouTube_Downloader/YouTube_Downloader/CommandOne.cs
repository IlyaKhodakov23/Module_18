using AngleSharp.Dom;
using AngleSharp.Html;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Search;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

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
                //клиент, через который пойдет вся работа
                var youtube = new YoutubeClient();
                //Модель видео
                var video = youtube.Videos.GetAsync(url);
                //Получим стрим видео. Манифест потока - объект который содержит список потоков
                var streamManifest = youtube.Videos.Streams.GetManifestAsync(video.Result.Id).Result;
                //возьмем поток с самым высоким возможным качеством
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                //прогресс загруженности
                var progress = new Progress<double>();
                progress.ProgressChanged += (s, e) => Debug.WriteLine($"Загружено: {e:P2}");
                //загружаем видео
                var download = youtube.Videos.Streams.DownloadAsync(streamInfo, $"{place}/{video.Result.Id}.{streamInfo.Container}", progress);
                //await youtube.Videos.DownloadAsync(url, place);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override async void Info(string url)
        {
            try
            {
                var youtube = new YoutubeClient();
                var video = youtube.Videos.GetAsync(url).Result;
                Console.WriteLine($"Название: {video.Title}");
                Console.WriteLine($"Продолжительность: {video.Duration}");
                Console.WriteLine($"Автор: {video.Author}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
