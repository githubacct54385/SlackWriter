using SlackWriter.Core.Models;

namespace SlackWriter
{
  public class SlackMessager
  {
    private readonly ISlackActionHandler _actionHandler;

    public SlackMessager(ISlackActionHandler actionHandler)
    {
      _actionHandler = actionHandler;
    }

    public SlackResponse SendMessage(string webhookSecret, string message)
    {
      return _actionHandler.PostMessageToChannel(webhookSecret, message);
    }
  }
}