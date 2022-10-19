using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;

namespace SMD_PROJECT.model
{
    internal class SpotifyApiModel
    {
        private static EmbedIOAuthServer _server;
        private static String _apiClient = "61dc4d67951947ccbe2cebb98e5ff82c";
        private static String _apiSecret = "2061ef4d611049b48280517cebccfac4";

        public static async Task Main()
        {

            _server = new EmbedIOAuthServer(new Uri("http://localhost:5000/callback"), 5000);
            await _server.Start();

            _server.AuthorizationCodeReceived += OnAuthorizationCodeReceived;
            _server.ErrorReceived += OnErrorReceived;

            var request = new LoginRequest(_server.BaseUri, _apiClient, LoginRequest.ResponseType.Code)
            {
                Scope = new List<string> { Scopes.UserReadEmail }
            };
            BrowserUtil.Open(request.ToUri());
        }

        private static async Task OnAuthorizationCodeReceived(object sender, AuthorizationCodeResponse response)
        {
            await _server.Stop();

            var config = SpotifyClientConfig.CreateDefault();
            var tokenResponse = await new OAuthClient(config).RequestToken(
              new AuthorizationCodeTokenRequest(
               _apiClient, _apiSecret, response.Code, new Uri("http://localhost:5000/callback")
              )
            );

            var spotify = new SpotifyClient(tokenResponse.AccessToken);

        }

        private static async Task OnErrorReceived(object sender, string error, string state)
        {
            Console.WriteLine($"Aborting authorization, error received: {error}");
            await _server.Stop();
        }

        public SpotifyClient getClient()
        {
            var config = SpotifyClientConfig.CreateDefault();

            var request = new ClientCredentialsRequest("61dc4d67951947ccbe2cebb98e5ff82c", "2061ef4d611049b48280517cebccfac4");
            var response = new OAuthClient(config).RequestToken(request);

            var spotify = new SpotifyClient(config.WithToken(response.Result.AccessToken));
            return spotify;
        }
        public void getTrack()
        {
            var spotify = this.getClient();
            var track = spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
            Console.WriteLine(track.Result.Name);

        }

        public void getLikedSongs()
        {
            var spotify = this.getClient();
            var list = spotify.Library.GetTracks();
            var teste = list.Result.Total;
            Console.WriteLine(teste);

        }
    }
}
