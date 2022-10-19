using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube;
using Google.Apis.YouTube.v3.Data;
using MediaToolkit.Model;
using MediaToolkit;
using System.IO;
using VideoLibrary;
using System.Windows.Forms;

namespace SMD_PROJECT.model
{
    internal class YoutubeApiModel
    {
        const string ApiKey = "AIzaSyAc19wQkCwc-eHUFKlVhscm-6kmcV-ap1E";

        public YouTubeService getYoutubeService(String apiKey)
        {
            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey
            });

            return service;
        }

        public string search(String keyWord)
        {
            var service = getYoutubeService(ApiKey);
            SearchResource.ListRequest listRequest = service.Search.List("snippet");
            listRequest.Q  = keyWord;
            SearchListResponse searchResponse = listRequest.Execute();

            List<string> videosId = new List<string>();

            foreach (SearchResult searchResult in searchResponse.Items)
            {
                if (searchResult.Id.Kind == "youtube#video")
                {
                    videosId.Add(searchResult.Id.VideoId);
                }
            }
            return "https://www.youtube.com/watch?v=" + videosId[0];
        }

        public string videoDownloader(String link, String savePath)
        {
            var youTube = YouTube.Default;
            
            try
            {
                var video = youTube.GetVideo(link);
                File.WriteAllBytes(savePath + video.FullName, video.GetBytes());
                var url = savePath + video.FullName;
                return url;
            }
            catch (Exception ex) {
               
               MessageBox.Show($"Erro na aplicação.\n {ex}");
               return null;
            }
        }

        public String convertToMp3(String path)
        {
            var inputFile = new MediaFile { Filename = path };
            var mp3path = path.Remove(path.Length - 4);
            var outputFile = new MediaFile { Filename = mp3path + ".mp3" };

            using (var engine = new Engine())
            {
                engine.Convert(inputFile, outputFile);
            }
            File.Delete(path);
            return mp3path + ".mp3";

        }
    }
}
