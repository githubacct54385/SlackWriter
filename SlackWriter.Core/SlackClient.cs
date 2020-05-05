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
    public SlackResponse WriteToChannel(string webhookSecret, string message)
    {
      SlackMessager slackMessager = new SlackMessager(new SlackActionHandlerImpl());
      return slackMessager.SendMessage(webhookSecret, message);
    }
  }
}