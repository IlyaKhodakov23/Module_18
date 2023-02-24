using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube_Downloader
{
    class Sender
    {
        Command_YouTube _commandYT;

        public void SetCommand(Command_YouTube command_YouTube)
        {
            _commandYT = command_YouTube;
        }

        public void Download(string url, string place)
        {
            _commandYT.Download(url, place);
        }

        public void Info(string url)
        {
            _commandYT.Info(url);
        }
    }

}
