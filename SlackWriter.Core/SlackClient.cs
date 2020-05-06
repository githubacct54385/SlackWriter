using SlackWriter.Core.Models;

namespace SlackWriter
{
  public class SlackClient
  {
    /// <summary>
    /// Sends a text message to a Slack Channel using Incoming Webhooks
    /// </summary>
    /// <param name="webhookSecret">Your incoming webhook secret code</param>
    /// <param name="message">The text message you want to send to the Slack Channel</param>
    /// <returns>SlackResponse</returns>
    public SlackResponse WriteTextMessageToChannel(string webhookSecret, string message)
    {
      SlackMessager slackMessager = new SlackMessager(new TextBasedSlackActionHandlerImpl());
      return slackMessager.SendMessage(webhookSecret, message);
    }

    /// <summary>
    /// Sends a Block message to a Slack Channel using Incoming Webhooks
    /// </summary>
    /// <param name="webhookSecret">Your incoming webhook secret code</param>
    /// <param name="message">The block message you want to send to the Slack Channel</param>
    /// <returns>SlackResponse</returns>
    public SlackResponse WriteBlockMessageToChannel(string webhookSecret, string message)
    {
      SlackMessager slackMessager = new SlackMessager(new BlockBasedSlackActionHandler());
      return slackMessager.SendMessage(webhookSecret, message);
    }
  }
}