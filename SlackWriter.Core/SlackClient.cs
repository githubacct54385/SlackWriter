using SlackWriter.Core.Models;

namespace SlackWriter
{
  public class SlackClient
  {
    private readonly ISlackActionHandler _actionHandler;
    public SlackClient(ISlackActionHandler actionHandler)
    {
      _actionHandler = actionHandler;
    }
    public SlackResponse WriteToChannel(string webhookSecret, string message)
    {
      return _actionHandler.PostMessageToChannel(webhookSecret, message);
    }
  }
}