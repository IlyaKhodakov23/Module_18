using AngleSharp.Dom;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Search;
using YoutubeExplode.Videos;

namespace YouTube_Downloader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ссылку на видео YouTube для скачивания");
            string url = Convert.ToString(Console.ReadLine());

            string path = @"C:\\Users\\user\\Desktop\\IT\\Code\\Module_18\\Practic_Command\\YouTube_Downloader\\YouTube_Downloader\\bin\\Debug\\net6.0";

            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

            // создадим команду
            var commandOne = new CommandOne(receiver);

            // инициализация команды
            sender.SetCommand(commandOne);

            //  выполнение
            sender.Info(url);
            sender.Download(url, path);

            Console.ReadKey();
        }
    }
}