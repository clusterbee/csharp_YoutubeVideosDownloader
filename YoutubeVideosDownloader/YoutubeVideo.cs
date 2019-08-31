using System.IO;
using System.Threading.Tasks;
using YoutubeExplode;

namespace clusterbee_YoutubeVideosDownloader
{
    class YoutubeVideo
    {
        private string url;
        private string dstFolder;
        private YoutubeExplode.Models.Video info;

        /* constructors */

        public YoutubeVideo()
        {
            this.Erase();
            this.dstFolder = Directory.GetCurrentDirectory();
        }

        /* getter & setters */

        private void Erase()
        {
            this.url = "";
            this.dstFolder = "";
            this.info = null;
        }

        public string GETdstFolder() => this.dstFolder;

        public string SETdstFolder(string carpeta) => this.dstFolder = carpeta;

        public string GETurl() => this.url;

        public YoutubeExplode.Models.Video GETinfo() => this.info;

        /* other methods */

        // Retrieve video information from Youtube
        public void Loading(string url)
        {
            this.url = url.Trim();

            Task.Run(async () => {
                await this.LoadInfoVideoAsync();
            }).GetAwaiter().GetResult();
        }

        // Indicates whether video information was obtained
        public bool Loaded() => this.info != null;

        // Asynchronous method for obtaining video information
        private async Task LoadInfoVideoAsync()
        {
            try
            {
                string idVideo = YoutubeClient.ParseVideoId(this.url);

                var client = new YoutubeClient();
                this.info = await client.GetVideoAsync(idVideo);
            }
            catch
            {
                this.info = null;
            }
        }
    }
}