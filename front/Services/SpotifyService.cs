public class SpotifyService
{
    public async void SendToken(SpotifyToken token)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://localhost:7008");
        await client.PostAsJsonAsync("spotify", token);
    }
}