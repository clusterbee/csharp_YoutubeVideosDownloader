using System;

namespace clusterbee_YoutubeVideosDownloader
{
    partial class DownloadForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadForm));
            this.lblYoutubeLink = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.pbarDownload = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtURLYoutube = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkbDirectDownload = new System.Windows.Forms.CheckBox();
            this.gbDstFolders = new System.Windows.Forms.GroupBox();
            this.rbDesktopFolder = new System.Windows.Forms.RadioButton();
            this.rbDocumentsFolder = new System.Windows.Forms.RadioButton();
            this.rbVideosFolder = new System.Windows.Forms.RadioButton();
            this.lblByClusterbee = new System.Windows.Forms.LinkLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnRemoveVideo = new System.Windows.Forms.Button();
            this.gbDstFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYoutubeLink
            // 
            this.lblYoutubeLink.AutoSize = true;
            this.lblYoutubeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYoutubeLink.Location = new System.Drawing.Point(26, 18);
            this.lblYoutubeLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYoutubeLink.Name = "lblYoutubeLink";
            this.lblYoutubeLink.Size = new System.Drawing.Size(120, 24);
            this.lblYoutubeLink.TabIndex = 1;
            this.lblYoutubeLink.Text = "Youtube Link";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownload.Location = new System.Drawing.Point(25, 294);
            this.lblDownload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(105, 24);
            this.lblDownload.TabIndex = 2;
            this.lblDownload.Text = "Path to file :";
            // 
            // pbarDownload
            // 
            this.pbarDownload.Location = new System.Drawing.Point(24, 338);
            this.pbarDownload.Margin = new System.Windows.Forms.Padding(2);
            this.pbarDownload.Name = "pbarDownload";
            this.pbarDownload.Size = new System.Drawing.Size(645, 27);
            this.pbarDownload.TabIndex = 3;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(326, 367);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(40, 24);
            this.lblPercentage.TabIndex = 4;
            this.lblPercentage.Text = "0 %";
            // 
            // txtURLYoutube
            // 
            this.txtURLYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURLYoutube.Location = new System.Drawing.Point(25, 44);
            this.txtURLYoutube.Margin = new System.Windows.Forms.Padding(2);
            this.txtURLYoutube.Name = "txtURLYoutube";
            this.txtURLYoutube.Size = new System.Drawing.Size(478, 29);
            this.txtURLYoutube.TabIndex = 5;
            this.txtURLYoutube.TextChanged += new System.EventHandler(this.TxtURLYoutube_TextChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Enabled = false;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Image = global::clusterbee_YoutubeVideosDownloader.Properties.Resources.descarga;
            this.btnDownload.Location = new System.Drawing.Point(30, 203);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(223, 59);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "   Donwload";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(21, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 24);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title :";
            // 
            // chkbDirectDownload
            // 
            this.chkbDirectDownload.AutoSize = true;
            this.chkbDirectDownload.Enabled = false;
            this.chkbDirectDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbDirectDownload.Location = new System.Drawing.Point(70, 163);
            this.chkbDirectDownload.Name = "chkbDirectDownload";
            this.chkbDirectDownload.Size = new System.Drawing.Size(142, 24);
            this.chkbDirectDownload.TabIndex = 9;
            this.chkbDirectDownload.Text = "Direct download";
            this.chkbDirectDownload.UseVisualStyleBackColor = true;
            this.chkbDirectDownload.CheckedChanged += new System.EventHandler(this.ChkbDownload_CheckedChanged);
            // 
            // gbDstFolders
            // 
            this.gbDstFolders.Controls.Add(this.rbDesktopFolder);
            this.gbDstFolders.Controls.Add(this.rbDocumentsFolder);
            this.gbDstFolders.Controls.Add(this.rbVideosFolder);
            this.gbDstFolders.Enabled = false;
            this.gbDstFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDstFolders.Location = new System.Drawing.Point(295, 163);
            this.gbDstFolders.Name = "gbDstFolders";
            this.gbDstFolders.Size = new System.Drawing.Size(374, 99);
            this.gbDstFolders.TabIndex = 10;
            this.gbDstFolders.TabStop = false;
            this.gbDstFolders.Text = "Select the user folder";
            // 
            // rbDesktopFolder
            // 
            this.rbDesktopFolder.AutoSize = true;
            this.rbDesktopFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDesktopFolder.Location = new System.Drawing.Point(266, 49);
            this.rbDesktopFolder.Name = "rbDesktopFolder";
            this.rbDesktopFolder.Size = new System.Drawing.Size(87, 24);
            this.rbDesktopFolder.TabIndex = 2;
            this.rbDesktopFolder.TabStop = true;
            this.rbDesktopFolder.Text = "Desktop";
            this.rbDesktopFolder.UseVisualStyleBackColor = true;
            // 
            // rbDocumentsFolder
            // 
            this.rbDocumentsFolder.AutoSize = true;
            this.rbDocumentsFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocumentsFolder.Location = new System.Drawing.Point(140, 49);
            this.rbDocumentsFolder.Name = "rbDocumentsFolder";
            this.rbDocumentsFolder.Size = new System.Drawing.Size(109, 24);
            this.rbDocumentsFolder.TabIndex = 1;
            this.rbDocumentsFolder.TabStop = true;
            this.rbDocumentsFolder.Text = "Documents";
            this.rbDocumentsFolder.UseVisualStyleBackColor = true;
            // 
            // rbVideosFolder
            // 
            this.rbVideosFolder.AutoSize = true;
            this.rbVideosFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVideosFolder.Location = new System.Drawing.Point(47, 49);
            this.rbVideosFolder.Name = "rbVideosFolder";
            this.rbVideosFolder.Size = new System.Drawing.Size(76, 24);
            this.rbVideosFolder.TabIndex = 0;
            this.rbVideosFolder.TabStop = true;
            this.rbVideosFolder.Text = "Videos";
            this.rbVideosFolder.UseVisualStyleBackColor = true;
            // 
            // lblByClusterbee
            // 
            this.lblByClusterbee.AutoSize = true;
            this.lblByClusterbee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblByClusterbee.Location = new System.Drawing.Point(576, 750);
            this.lblByClusterbee.Name = "lblByClusterbee";
            this.lblByClusterbee.Size = new System.Drawing.Size(93, 17);
            this.lblByClusterbee.TabIndex = 12;
            this.lblByClusterbee.TabStop = true;
            this.lblByClusterbee.Text = "by clusterbee";
            this.lblByClusterbee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblByClusterbee_LinkClicked);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(25, 400);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(644, 350);
            this.webBrowser.TabIndex = 13;
            // 
            // btnRemoveVideo
            // 
            this.btnRemoveVideo.Enabled = false;
            this.btnRemoveVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveVideo.Location = new System.Drawing.Point(525, 44);
            this.btnRemoveVideo.Name = "btnRemoveVideo";
            this.btnRemoveVideo.Size = new System.Drawing.Size(144, 29);
            this.btnRemoveVideo.TabIndex = 14;
            this.btnRemoveVideo.Text = "Remove video";
            this.btnRemoveVideo.UseVisualStyleBackColor = true;
            this.btnRemoveVideo.Click += new System.EventHandler(this.BtnRemoveVideo_Click);
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 776);
            this.Controls.Add(this.btnRemoveVideo);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lblByClusterbee);
            this.Controls.Add(this.chkbDirectDownload);
            this.Controls.Add(this.gbDstFolders);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtURLYoutube);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.pbarDownload);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.lblYoutubeLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DownloadForm";
            this.Text = "Youtube Videos Downloader  v.1.0";
            this.gbDstFolders.ResumeLayout(false);
            this.gbDstFolders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYoutubeLink;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.ProgressBar pbarDownload;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtURLYoutube;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkbDirectDownload;
        private System.Windows.Forms.GroupBox gbDstFolders;
        private System.Windows.Forms.RadioButton rbDesktopFolder;
        private System.Windows.Forms.RadioButton rbDocumentsFolder;
        private System.Windows.Forms.RadioButton rbVideosFolder;
        private System.Windows.Forms.LinkLabel lblByClusterbee;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnRemoveVideo;
    }
}

