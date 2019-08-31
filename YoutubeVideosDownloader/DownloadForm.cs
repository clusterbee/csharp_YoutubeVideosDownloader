using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;

namespace clusterbee_YoutubeVideosDownloader
{
    public partial class DownloadForm : Form
    {
        YoutubeVideo myYoutubeVideo = new YoutubeVideo();

        public DownloadForm()
        {
            InitializeComponent();
        }

        private void TxtURLYoutube_TextChanged(object sender, EventArgs e)
        {         
            this.myYoutubeVideo.Loading(txtURLYoutube.Text.Trim());

            if (myYoutubeVideo.Loaded())
            {
                lblTitle.Text = $"Title : {this.myYoutubeVideo.GETinfo().Title}";
                this.ActivateDownloadControls(true);
            }
            else
            {
                lblTitle.Text = "Title :";
                this.ActivateDownloadControls(false);
            }
        }

        async Task<string> DownloadVideoAsync(string id, string dstFolder, IProgress<int> progress)
        {
            var client = new YoutubeClient();

            // Get metadata for all streams in this video
            var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(id);

            // Select one of the streams, e.g. highest quality muxed stream
            var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality();

            // ...or highest bitrate audio stream
            // var streamInfo = streamInfoSet.Audio.WithHighestBitrate();

            // ...or highest quality & highest framerate MP4 video stream
            // var streamInfo = streamInfoSet.Video
            //    .Where(s => s.Container == Container.Mp4)
            //    .OrderByDescending(s => s.VideoQuality)
            //    .ThenByDescending(s => s.Framerate)
            //    .First();
            
            // Get file extension based on stream's container
            var ext = streamInfo.Container.GetFileExtension();

            // Download stream to file
            string pathFileout = Path.Combine(dstFolder, $"{id}.{ext}");

            this.lblDownload.Text = $"Path to file : {pathFileout}";

            await client.DownloadMediaStreamAsync(streamInfo, pathFileout, new Progress<double>(d =>
                {
                    int downloaded = (int)(100 * d);
                    progress.Report(downloaded);
                    lblPercentage.Text = $"{downloaded} %";
                }
            ));

            return "¡COMPLETE!";
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string dstFolder;

            if (this.chkbDirectDownload.Checked == true)
            {
                if (rbVideosFolder.Checked) dstFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                else if (rbDocumentsFolder.Checked) dstFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                else dstFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            }
            else
            {
                FolderBrowserDialog selectedFolder = new FolderBrowserDialog();
                if (selectedFolder.ShowDialog() != DialogResult.OK) return;
                dstFolder = selectedFolder.SelectedPath.ToString();
            }

            myYoutubeVideo.SETdstFolder(dstFolder);

            this.pbarDownload.Value = 0;

            var progress = new Progress<int>(percent =>
            {
                this.pbarDownload.Value = percent;
            });

            string message = await DownloadVideoAsync(this.myYoutubeVideo.GETinfo().Id, this.myYoutubeVideo.GETdstFolder(), progress);

            this.txtURLYoutube.Text = "";
            this.txtURLYoutube.Focus();
            MessageBox.Show(message, "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActivateDownloadControls(bool activate)
        {
            this.btnDownload.Enabled = activate;
            this.btnRemoveVideo.Enabled = activate;
            this.chkbDirectDownload.Enabled = activate;
            this.gbDstFolders.Enabled = activate;

            this.chkbDirectDownload.Checked = activate;
            this.rbVideosFolder.Checked = activate;

            if (activate)
            {
                this.PlayYoutubeVideo(this.myYoutubeVideo.GETinfo().Id, this.webBrowser);
            }
            else
            {
                this.rbDocumentsFolder.Checked = this.rbDesktopFolder.Checked = activate;
                this.ClearWebBrowser(this.webBrowser);
            }
        }         

        private void ChkbDownload_CheckedChanged(object sender, EventArgs e)
        {
            if (gbDstFolders.Enabled = chkbDirectDownload.Checked)
                rbVideosFolder.Checked = true;
            else
                rbVideosFolder.Checked = rbDocumentsFolder.Checked = rbDesktopFolder.Checked = false;
        }

        private void LblByClusterbee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/clusterbee");
        }

        private void ClearWebBrowser(WebBrowser myWebBrowser) => myWebBrowser.DocumentText = "";

        private void PlayYoutubeVideo(string idVideo, WebBrowser myWebBrowser)
        {
            myWebBrowser.DocumentText =
                $"<html><head><meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/></head><body><iframe width=\"100%\" height=\"330\" src=\"https://www.youtube.com/embed/{idVideo}?rel=0&autoplay=0&loop=0&playlist={idVideo}\" frameborder = \"0\" allow = \"encrypted-media\" allowfullscreen></iframe></body></html>";
        }

        private void BtnRemoveVideo_Click(object sender, EventArgs e)
        {
            this.txtURLYoutube.Text = "";
        }
    }
}