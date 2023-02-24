using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTube_Downloader
{
    abstract class Command_YouTube
    {
        public abstract void Info(string url);
        public abstract void Download(string url, string place);
    }
}
