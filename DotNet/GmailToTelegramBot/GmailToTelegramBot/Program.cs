using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

class Program
{
    static string[] Scopes = { GmailService.Scope.GmailReadonly };
    static string ApplicationName = "Gmail API .NET Quickstart";

    static async Task Main(string[] args)
    {
        UserCredential credential;

        using (var stream = new FileStream("some_code_Here", FileMode.Open, FileAccess.Read))
        {
            string credPath = "token.json";
            credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true));
        }

        var service = new GmailService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });

        await ListMessages(service, "me", "from:Макс Макс");
    }

    static async Task ListMessages(GmailService service, string userId, string query)
    {
        var request = service.Users.Messages.List(userId);
        request.Q = query;

        var response = await request.ExecuteAsync();
        if (response.Messages != null && response.Messages.Count > 0)
        {
            foreach (var messageItem in response.Messages)
            {
                var message = await service.Users.Messages.Get(userId, messageItem.Id).ExecuteAsync();
                Console.WriteLine($"Message snippet: {message.Snippet}");
                
                foreach (var part in message.Payload.Headers)
                {
                    if (part.Name == "Subject")
                    {
                        Console.WriteLine($"Subject: {part.Value}");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No messages found.");
        }
    }
}