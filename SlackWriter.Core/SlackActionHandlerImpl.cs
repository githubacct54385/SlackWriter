using System;
using RestSharp;
using SlackWriter.Core.Models;

namespace SlackWriter
{
  public sealed class SlackActionHandlerImpl : ISlackActionHandler
  {
    private readonly Uri host = new Uri("https://hooks.slack.com");

    public SlackResponse PostMessageToChannel(string webhookSecret, string message)
    {
      string path = $"services/{webhookSecret}";

      RestClient client = new RestClient(host);
      RestRequest request = new RestRequest(path, Method.POST, DataFormat.Json);

      request.AddJsonBody(new { text = message });

      IRestResponse response = client.Execute(request);
      if (response.IsSuccessful)
      {
        return new SlackResponse(response.Content, true, response.StatusCode);
      }
      return new SlackResponse("", false, response.StatusCode);
    }
  }
}