using System.Net;

namespace SlackWriter.Core.Models
{
  /// <summary>
  /// The output of a posted Slack Message
  /// </summary>
  public class SlackResponse
  {
    public SlackResponse(string content, bool isSuccessful, HttpStatusCode statusCode)
    {
      Content = content;
      IsSuccessful = isSuccessful;
      StatusCode = statusCode;
    }

    /// <summary>
    /// The string content of the API response
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// Is the API call successful or not
    /// </summary>
    public bool IsSuccessful { get; set; }
    /// <summary>
    /// The HTTP status code for the API call
    /// </summary>
    public HttpStatusCode StatusCode { get; set; }
  }
}